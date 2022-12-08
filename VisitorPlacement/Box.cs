namespace VisitorPlacement
{
    public class Box
    {
        private string boxLetter;
        public Chair[,] chairs;

        public Box(string letter, int rows, int chairsPerRow)
        {
            if (rows < 1 || rows > 3 || chairsPerRow < 3 || chairsPerRow > 10)
            {
                throw new InvalidOperationException("Invalid rows or chairs per row");
            }
            boxLetter = letter;
            chairs = new Chair[rows, chairsPerRow];
        }

        public string GetRowInfo(int row)
        {
            string rowInfo = "";
            for (int i = 0; i < chairs.GetLength(1); i++)
            {
                if (chairs[row, i] == null)
                {
                    rowInfo += $"{boxLetter}{row + 1}-{i + 1} empty| ";
                }
                else
                {
                    rowInfo += $"{boxLetter}{row + 1}-{i + 1} visitor({chairs[row, i].assignedVisitor.visitorNumber})| ";
                }
            }
            return rowInfo;
        }

        public void PlaceVisitor(List<Visitor> visitors)
        {
            foreach (Visitor visitor in visitors)
            {
                if (visitor.registered == true)
                {
                    GetFirstFreeChair().AssignVisitor(visitor);
                }

            }
        }

        private Chair GetFirstFreeChair()
        {
            for (int i = 0; i < chairs.GetLength(0); i++)
            {
                for (int x = 0; x < chairs.GetLength(1); x++)
                {
                    if (chairs[i, x] == null)
                    {
                        chairs[i, x] = new Chair();
                    }
                    if (chairs[i, x].assignedVisitor == null)
                    {
                        return chairs[i, x];
                    }
                }
            }

            return null;
        }
    }
}
