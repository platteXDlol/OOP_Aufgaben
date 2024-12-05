namespace WPF_Tutorial
{
    internal class Rechteck
    {
        double height;
        double width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        
        public double Width
        {
            get { return width; }
            set { width = value; }
        }


        public double GetArea()
        {
            return height * width;
        }



    }

  
    
}