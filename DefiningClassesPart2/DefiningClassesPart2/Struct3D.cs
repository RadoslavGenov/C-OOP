namespace DefiningClassesPart2
{
    struct Point3D
    {
        private static readonly Point3D pointZero = new Point3D(0,0,0);
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D PointZero
        {
            get { return pointZero; }
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }

        public Point3D(double x, double y, double z) 
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
