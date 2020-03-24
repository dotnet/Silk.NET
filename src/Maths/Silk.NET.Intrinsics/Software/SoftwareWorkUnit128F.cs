// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace Silk.NET.Intrinsics.Software
{
    public struct SoftwareWorkUnit128F : IWorkUnit<float>
    {
        internal SoftwareWorkUnit128F(Vector128<float> vector128)
        {
            _vector128 = vector128;
        }

        public Vector128<float> _vector128;
        public IWorkUnit<float> Add(IWorkUnit<float> vector)
        {
            Vector128<float> result = default;

            for (var i = 0; i < Vector128<float>.Count; i++)
            {
                result = result.WithElement(i, _vector128.GetElement(i) + _vector128.GetElement(i));
            }

            return new SoftwareWorkUnit128F(result);
        }

        public IWorkUnit<float> BaryCentric
        (
            IWorkUnit<float> secondVector,
            IWorkUnit<float> thirdVector,
            IWorkUnit<float> firstBarycentricScalar,
            IWorkUnit<float> secondBarycentricScalar
        )
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Clamp(IWorkUnit<float> min, IWorkUnit<float> max)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> ComponentMax(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> ComponentMin(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Divide(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> DotProduct(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Equals(IWorkUnit<float> secondVector) => new SoftwareWorkUnit128F
        (
            _vector128.Equals
                (((SoftwareWorkUnit128F) secondVector)._vector128)
                ? Vector128.Create(1f)
                : Vector128.Create(0f)
        );

        public IWorkUnit<float> Lerp(IWorkUnit<float> secondVector, IWorkUnit<float> blend)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> MagnitudeMax(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> MagnitudeMin(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Multiply(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Normalize()
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Normalize(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> NormalizeApprox()
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> NormalizeApprox(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Subtract(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Transform(IWorkUnit<float> row0, IWorkUnit<float> row1, IWorkUnit<float> row2)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Transform(IWorkUnit<float> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Conjugate()
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Invert()
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> FromAxisAngle(IWorkUnit<float> angle)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> FromEulerAngles(IWorkUnit<float> angles)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> FromMatrix3(IWorkUnit<float> row1, IWorkUnit<float> row2)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Slerp(IWorkUnit<float> secondQuaternion, IWorkUnit<float> blend)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> ToAxisAngle()
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> ToAxisAngle(out IWorkUnit<float> angle)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(float* ptr)
        {
            *ptr = _vector128.GetElement(0);
        }

        public unsafe void StoreVector2(float* ptr)
        {
            ptr[0] = _vector128.GetElement(0);
            ptr[1] = _vector128.GetElement(1);
        }

        public unsafe void StoreVector3(float* ptr)
        {
            ptr[0] = _vector128.GetElement(0);
            ptr[1] = _vector128.GetElement(1);
            ptr[2] = _vector128.GetElement(2);
        }

        public unsafe void StoreVector4(float* ptr)
        {
            ptr[0] = _vector128.GetElement(0);
            ptr[1] = _vector128.GetElement(1);
            ptr[2] = _vector128.GetElement(2);
            ptr[3] = _vector128.GetElement(3);
        }
    }
}
