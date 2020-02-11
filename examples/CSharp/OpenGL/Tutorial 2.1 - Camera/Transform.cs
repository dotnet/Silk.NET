using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Tutorial
{
    public class Transform
    {

        public Vector3 Position { get; set; } = new Vector3(0, 0, 0);

        public float Scale { get; set; } = 1f;

        public Quaternion Rotation { get; set; } = Quaternion.Identity;
        
        public Matrix4x4 ModelMatrix => Matrix4x4.Identity * Matrix4x4.CreateFromQuaternion(Rotation) * Matrix4x4.CreateScale(Scale) * Matrix4x4.CreateTranslation(Position);
    }
}
