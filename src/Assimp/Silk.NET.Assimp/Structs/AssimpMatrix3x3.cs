// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Numerics;

namespace Silk.NET.Assimp
{
    public struct AssimpMatrix3x3
    {
        public Vector3 Row1;
        public Vector3 Row2;
        public Vector3 Row3;
        public float M11 {get => Row1.X; set => Row1.X = value; }
        public float M12 {get => Row1.Y; set => Row1.Y = value; }
        public float M13 {get => Row1.Z; set => Row1.Z = value; }
        public float M21 {get => Row2.X; set => Row2.X = value; }
        public float M22 {get => Row2.Y; set => Row2.Y = value; }
        public float M23 {get => Row2.Z; set => Row2.Z = value; }
        public float M31 {get => Row3.X; set => Row3.X = value; }
        public float M32 {get => Row3.Y; set => Row3.Y = value; }
        public float M33 {get => Row3.Z; set => Row3.Z = value; }
    }
}
