namespace MarsRover.Library.Model
{
    public class Coordinates
    {
        public int coordX { get; set; }

        public int coordY { get; set; }

        public Coordinates()
        {
            coordX = 0;
            coordY = 0;
        }
        public Coordinates(int coordX, int coordY)
        {
            this.coordX = coordX;
            this.coordY = coordY;
        }

        /// <summary>
        /// Returns sum of given Coordinates objects, performs memberwise addition
        /// </summary>
        /// <param name="a">Coordinates object to add</param>
        /// <param name="b">Coordinates object to add</param>
        /// <returns>Returns sum of given Coordinates objects</returns>
        public static Coordinates operator +(Coordinates a, Coordinates b)
        {
            return new Coordinates
            {
                coordX = a.coordX + b.coordX,
                coordY = a.coordY + b.coordY
            };
        }
    }
}
