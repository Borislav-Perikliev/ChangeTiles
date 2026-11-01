using System;


namespace ChangeTiles {
    
    //Calculating bench size and tile size.
    class CalculateArea {
        
        private int fLength;
        private double tWidth;
        private double tLength;
        private int bWidth;
        private int bLength;

        public CalculateArea(int fLength, double tWidth, double tLength, int bWidth, int bLength) {
            
            this.fLength = fLength;
            this.tWidth = tWidth;
            this.tLength = tLength;
            this.bWidth = bWidth;
            this.bLength = bLength;
        }
        public int CalculateBenchArea() {
            return bWidth * bLength;
        }

        public double CalculateTileArea() {
            return tWidth * tLength;
        }
        public int TotalArea() {
            return fLength * fLength;
        }
    }
    class Program {
        
        static void Main() {
            
            //Getting the measurements
            //Floor length
            int fLength = int.Parse(Console.ReadLine());
            //Tile width and length
            double tWidth = double.Parse(Console.ReadLine());
            double tLength = double.Parse(Console.ReadLine());
            //Bench width and length
            int bWidth = int.Parse(Console.ReadLine());
            int bLength = int.Parse(Console.ReadLine());
            
            CalculateArea calculator = new CalculateArea(fLength, tWidth, tLength, bWidth, bLength);
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
