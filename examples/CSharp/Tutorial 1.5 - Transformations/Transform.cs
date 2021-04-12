using System.Numerics;

namespace Tutorial
{
    public class Transform
    {
        //A transform abstraction.
        //For a transform we need to have a position a scale and a rotation,
        //depending on what application you are creating, the type for these may vary.

        //Here we have chosen a vec3 for position, float for scale and quaternion for rotation,
        //as that is the most normal to go with.
        //Another example could have been vec3, vec3, vec4, so the rotation is an axis angle instead of a quaternion

        public Vector3 Position { get; set; } = new Vector3(0, 0, 0);

        public float Scale { get; set; } = 1f;

        public Quaternion Rotation { get; set; } = Quaternion.Identity;

        //Note: The order here does matter.
        public Matrix4x4 ViewMatrix => Matrix4x4.Identity * Matrix4x4.CreateFromQuaternion(Rotation) * Matrix4x4.CreateScale(Scale) * Matrix4x4.CreateTranslation(Position);
    }
}
