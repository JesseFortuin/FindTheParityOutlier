namespace FindTheParityOutlier.BL
{
    public class OutlierFinder : IOutlierFinder
    {
        public int Find(int[] integers)
        {
            var uneven = 0;

            foreach (int num in integers)
            {
                if (num % 2 > 0)
                {
                    uneven ++;
                }

                if (uneven >= 2)
                {
                    foreach (int num2 in integers)
                    {
                        if (num2 % 2 == 0)
                        {
                            return num2;
                        }
                    }
                }                
            }
            foreach (int num2 in integers)
            {
                if (num2 % 2 != 0)
                {
                    return num2;
                }
            }

            return 0;
        }
    }
}