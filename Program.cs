using System;


namespace ChangeTitle
{
    //Calculating bench size and tile size.
    class CalculateArea
    {
        private int nLength;
        private double wWidth;
        private double lLength;
        private int mWidth;
        private int oLength;
        public CalculateArea(int nLength, double wWidth, double lLength, int mWidth, int oLength) 
        { 
            this.nLength = nLength;
            this.wWidth = wWidth;
            this.lLength = lLength;
            this.mWidth = mWidth;
            this.oLength = oLength;
        }
        public int CalculateBenchArea()
        {
            return mWidth * oLength;
        }

        public double CalculateTileArea()
        {
            return wWidth * lLength;
        }
        public int TotalArea()
        {
            return nLength * nLength;
        }
    
    }
    class Program
    {   
        
        static void Main()
        {
            //Getting the measurements
            //Floor length
            int nLength = int.Parse(Console.ReadLine());
            //Tile width and length
            double wWidth = double.Parse(Console.ReadLine());
            double lLength = double.Parse(Console.ReadLine());
            //Bench width and length
            int mWidth = int.Parse(Console.ReadLine());
            int oLength = int.Parse(Console.ReadLine());

            
            CalculateArea calculator = new CalculateArea(nLength, wWidth, lLength, mWidth, oLength);
            //Cakculating the total area and needed tiles
            int benchArea = calculator.CalculateBenchArea();
            double tileArea = calculator.CalculateTileArea();
            int area = calculator.TotalArea();
            int wholeArea = area - benchArea;
            //The time is roughly 2 sec per tile
            double neededTiles = wholeArea / tileArea;
            double neededTime = (neededTiles * 0.2);
            
            //neededTime = (int)(neededTime / 0.6) + neededTime % 0.6;
            
            //Printing the tile amount and the time needed for placement.
            Console.WriteLine(neededTiles + " pcs");
            Console.WriteLine(neededTime + " minutes");
        
            /*For actual time it should be: neededTime / 0.6 for the minutes
              and neededTime % 0.6 for seconds */
        }
    }
}