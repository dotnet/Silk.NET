// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
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

        public IWorkUnit<float> Clamp(IWorkUnit<float> min, IWorkUnit<float> max) => new SoftwareWorkUnit128F
        (
            Vector128.Create
            (
                Math.Clamp
                (
                    _vector128.X(), ((SoftwareWorkUnit128F) min)._vector128.X(),
                    ((SoftwareWorkUnit128F) max)._vector128.X()
                ),
                Math.Clamp
                (
                    _vector128.X(), ((SoftwareWorkUnit128F) min)._vector128.Y(),
                    ((SoftwareWorkUnit128F) max)._vector128.Y()
                ),
                Math.Clamp
                (
                    _vector128.X(), ((SoftwareWorkUnit128F) min)._vector128.Z(),
                    ((SoftwareWorkUnit128F) max)._vector128.Z()
                ),
                Math.Clamp
                (
                    _vector128.X(), ((SoftwareWorkUnit128F) min)._vector128.W(),
                    ((SoftwareWorkUnit128F) max)._vector128.W()
                )
            )
        );

        public IWorkUnit<float> ComponentMax(IWorkUnit<float> secondVector)
        {
            float lX = _vector128.X(), rX = ((SoftwareWorkUnit128F)secondVector).X();
            float lY = _vector128.Y(), rY = ((SoftwareWorkUnit128F)secondVector).Y();
            float lZ = _vector128.Z(), rZ = ((SoftwareWorkUnit128F)secondVector).Z();
            float lW = _vector128.W(), rW = ((SoftwareWorkUnit128F)secondVector).W();

            if (float.IsNaN(lX)) lX = rX;
            if (float.IsNaN(lY)) lY = rY;
            if (float.IsNaN(lZ)) lZ = rZ;
            if (float.IsNaN(lW)) lW = rW;

            if (float.IsNaN(rX)) rX = lX;
            if (float.IsNaN(rY)) rY = lY;
            if (float.IsNaN(rZ)) rZ = lZ;
            if (float.IsNaN(rW)) rW = lW;

            return new SoftwareWorkUnit128F(Vector128.Create(
                MathF.Max(lX, rX),
                MathF.Max(lY, rY),
                MathF.Max(lZ, rZ),
                MathF.Max(lW, rW)
            ));
        }

        public IWorkUnit<float> ComponentMin(IWorkUnit<float> secondVector)
        {
            float lX = _vector128.X(), rX = ((SoftwareWorkUnit128F)secondVector).X();
            float lY = _vector128.Y(), rY = ((SoftwareWorkUnit128F)secondVector).Y();
            float lZ = _vector128.Z(), rZ = ((SoftwareWorkUnit128F)secondVector).Z();
            float lW = _vector128.W(), rW = ((SoftwareWorkUnit128F)secondVector).W();

            if (float.IsNaN(lX)) lX = rX;
            if (float.IsNaN(lY)) lY = rY;
            if (float.IsNaN(lZ)) lZ = rZ;
            if (float.IsNaN(lW)) lW = rW;

            if (float.IsNaN(rX)) rX = lX;
            if (float.IsNaN(rY)) rY = lY;
            if (float.IsNaN(rZ)) rZ = lZ;
            if (float.IsNaN(rW)) rW = lW;

            return new SoftwareWorkUnit128F(Vector128.Create(
                MathF.Min(lX, rX),
                MathF.Min(lY, rY),
                MathF.Min(lZ, rZ),
                MathF.Min(lW, rW)
            ));
        }

        public IWorkUnit<float> Divide(IWorkUnit<float> secondVector) =>
            new SoftwareWorkUnit128F
            (
                Vector128.Create
                (
                    _vector128.X() / ((SoftwareWorkUnit128F) secondVector).X(),
                    _vector128.Y() / ((SoftwareWorkUnit128F) secondVector).Y(),
                    _vector128.Z() / ((SoftwareWorkUnit128F) secondVector).Z(),
                    _vector128.W() / ((SoftwareWorkUnit128F) secondVector).W()
                )
            );

        public IWorkUnit<float> DotProduct2(IWorkUnit<float> secondVector) => new SoftwareWorkUnit128F(Vector128.Create
        (
            _vector128.X() * ((SoftwareWorkUnit128F)secondVector).X()
            + _vector128.Y() * ((SoftwareWorkUnit128F)secondVector).Y()
        ));

        public IWorkUnit<float> DotProduct3(IWorkUnit<float> secondVector) => new SoftwareWorkUnit128F(Vector128.Create
        (
            _vector128.X() * ((SoftwareWorkUnit128F)secondVector).X()
            + _vector128.Y() * ((SoftwareWorkUnit128F)secondVector).Y()
            + _vector128.Z() * ((SoftwareWorkUnit128F)secondVector).Z()
        ));

        public IWorkUnit<float> DotProduct4(IWorkUnit<float> secondVector) => new SoftwareWorkUnit128F(Vector128.Create
        (
            _vector128.X() * ((SoftwareWorkUnit128F)secondVector).X()
            + _vector128.Y() * ((SoftwareWorkUnit128F)secondVector).Y()
            + _vector128.Z() * ((SoftwareWorkUnit128F)secondVector).Z()
            + _vector128.W() * ((SoftwareWorkUnit128F)secondVector).W()
        ));

        public IWorkUnit<float> Equals(IWorkUnit<float> secondVector) => new SoftwareWorkUnit128F
        (
            _vector128.Equals
                (((SoftwareWorkUnit128F) secondVector)._vector128)
                ? Vector128.Create(1f)
                : Vector128.Create(0f)
        );

        public IWorkUnit<float> Lerp(IWorkUnit<float> secondVector, IWorkUnit<float> blend) => new SoftwareWorkUnit128F
        (
            Vector128.Create
            (
                LerpHelper(_vector128.X(), ((SoftwareWorkUnit128F)secondVector).X(), blend.Scalar()),
                LerpHelper(_vector128.Y(), ((SoftwareWorkUnit128F)secondVector).Y(), blend.Scalar()),
                LerpHelper(_vector128.Z(), ((SoftwareWorkUnit128F)secondVector).Z(), blend.Scalar()),
                LerpHelper(_vector128.W(), ((SoftwareWorkUnit128F)secondVector).W(), blend.Scalar())
            )
        );

        private static float LerpHelper(float left, float right, float weight)
        {
            return left + (right - left) * weight;
        }

        public IWorkUnit<float> MagnitudeMax(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> MagnitudeMin(IWorkUnit<float> secondVector)
        {
            throw new System.NotImplementedException();
        }

        public IWorkUnit<float> Multiply(IWorkUnit<float> secondVector) => new SoftwareWorkUnit128F
        (
            Vector128.Create
            (
                _vector128.X() * ((SoftwareWorkUnit128F) secondVector).X(),
                _vector128.Y() * ((SoftwareWorkUnit128F) secondVector).Y(),
                _vector128.Z() * ((SoftwareWorkUnit128F) secondVector).Z(),
                _vector128.W() * ((SoftwareWorkUnit128F) secondVector).W()
            )
        );

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

        public IWorkUnit<float> Sqrt()
        {
            throw new NotImplementedException();
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
