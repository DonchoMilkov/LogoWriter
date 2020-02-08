namespace LogoHandler
{
    public class MMLogoDesigner : ILogoDesigner
    {
        private int thickness;
        public MMLogoDesigner(int thickness)
        {
            this.thickness = thickness;
        }
        public bool[,] CreateLogo()
        {
            var len = thickness * 5;
            var height = thickness + 1;
            bool[,] arr = new bool[height, len * 2];
            int index = height - 1;
            int move = -1;

            for (int j = 0; j <= len - thickness; j++)
            {
                var secondJ = j + len;
                for (int i = 0; i < thickness; i++)
                {
                    arr[index, j + i] = true;
                    arr[index, secondJ + i] = true;
                }
                index = index + move;
                if (index == height - 1 || index == 0)
                {
                    move *= -1;
                }
            }
            return arr;
        }
    }
}