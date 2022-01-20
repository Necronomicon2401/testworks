using UnityEngine;

namespace Playtika
{
    public static class SuperTools
    {
        public static void AddXPosition(this Transform t, float x)
        {
            Vector3 newPosition = new Vector3(x, 0, 0);
            t.position += newPosition;
            //t.position += Vector3.right * x;
        }
    }
}
