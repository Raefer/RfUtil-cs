namespace RfUtil_cs.Data
{
    class Matrix<T>
    {
        private int cursor;
        private int sizeX;
        private int sizeY;
        private T[] list;
        // 0  1  2  3  4
        // 5  6  8  8  9
        // 10 11 12 13 14
        // 15 16 17 18 19
        // 20 21 22 23 24

        public Matrix(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.list = new T[sizeX * sizeY];
        }

        public Matrix(int sizeX, int sizeY, T initialValue)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.list = new T[sizeX * sizeY];
            for (int i = 0; i < sizeX * sizeY; i++)
            {
                list[i] = initialValue;
            }
        }

        public void Set(int X, int Y, T value)
        {
            if (IsInRange(X, Y))
            {
                SetCursor(X, Y);
                list[cursor] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
        }

        public T Get(int X, int Y)
        {
            if (IsInRange(X, Y))
            {
                SetCursor(X, Y);
                return list[cursor];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
        }

        private bool IsInRange(int X, int Y)
        {
            if ((X > sizeX - 1 || X < 0) || (Y > sizeY - 1 || Y < 0))
            {
                return false;
            }
            return true;
        }

        private void SetCursor(int X, int Y)
        {
            cursor = X * sizeX + Y;
        }
    }
}