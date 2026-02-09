namespace RectangleLib
{
    public class Rectangle
    {
        private int Width;
        private int Length;

        // default Constructor
        public Rectangle()
        {
            Width = 1;
            Length = 1;
        }

        // non-default Constructor
        public Rectangle(int width, int length)
        {
            SetWidth(width);
            SetLength(length);
        }

        public int GetLength()
        {
            return 1;
        }
        public int SetLength(int length)
        {
            return 1;
        }
        public int GetWidth()
        {
            return Width;
        }
        public int SetWidth(int width)
        {
            if (width > 0 && width <= 1500)
            {
                this.Width = width;
                return this.Width;
            }
            else {
                throw new ArgumentOutOfRangeException("Width must be between 1 and 1500");
            }
        }
        public int GetPerimeter()
        {
            return 1;
        }
        public int GetArea()
        {
            return 1;
        }
    }
}
