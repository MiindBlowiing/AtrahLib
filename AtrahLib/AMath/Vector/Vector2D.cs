using Math = System.Math;

namespace AtrahLib.AMath.Vector
{
    public struct Vector2D
    {
        float x;
        float y;
        
        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector2D Add(Vector2D left,Vector2D right)
        {
            Vector2D result;
            result.x = left.x + right.x;
            result.y = left.y + right.y;
            return result;
        }
        public Vector2D Substract(Vector2D left, Vector2D right)
        {
            return Add(left,  Scale(right, -1));
        }
        public Vector2D Scale(Vector2D vect, float scale)
        {
            Vector2D v;
            v.x = vect.x * scale;
            v.y = vect.y * scale;
	        return v;
        }
        public void MoveBy(Vector2D by,ref Vector2D toMove)
        {
            toMove = Add(toMove, by);
        }
        public double GetPolarAngleDeg(Vector2D vect)
        {
            double angle = Math.Atan2(vect.y, vect.x) * (180 / Math.PI);
            return angle < 0 ? angle += 360 : angle;
        }
    }
}