namespace MindBoxLib
{
    public abstract class Shape
    {
        public Shape(string figure)
        {
            Figure = figure;
        }
        public string Figure { get; set; }
        public abstract double Square();
    }

}