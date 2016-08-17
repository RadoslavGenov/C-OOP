namespace DefiningClassesPart2
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class Path : IEnumerable
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public int Count()
        {
            return points.Count();
        }

        public Point3D this[int index]
        {
            get { return points[index]; }
            set { points[index] = value; }
        }

        public void Add(Point3D point)
        {
            this.points.Add(point);
        }

        public void AddPoints(params Point3D[] range)
        {
            this.points.AddRange(range);
        }

        public void AddPoints(ICollection<Point3D> collection)
        {
            this.points.AddRange(collection);
        }

        public override string ToString()
        {
            return string.Join("->", points);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)points).GetEnumerator();
        }
    }
}
