// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics
{
    public interface IWorkUnit<T>
        where T:unmanaged
    {
        // Vector operators
        IWorkUnit<T> Add(IWorkUnit<T> vector);

        IWorkUnit<T> BaryCentric
        (
            /* current vector is first vector */
            IWorkUnit<T> secondVector,
            IWorkUnit<T> thirdVector,
            IWorkUnit<T> firstBarycentricScalar,
            IWorkUnit<T> secondBarycentricScalar
        );

        IWorkUnit<T> Clamp(IWorkUnit<T> min, IWorkUnit<T> max);
        IWorkUnit<T> ComponentMax(IWorkUnit<T> secondVector);
        IWorkUnit<T> ComponentMin(IWorkUnit<T> secondVector);
        IWorkUnit<T> Divide(IWorkUnit<T> secondVector);
        IWorkUnit<T> DotProduct2(IWorkUnit<T> secondVector);
        IWorkUnit<T> DotProduct3(IWorkUnit<T> secondVector);
        IWorkUnit<T> DotProduct4(IWorkUnit<T> secondVector);
        IWorkUnit<T> Equals(IWorkUnit<T> secondVector);
        IWorkUnit<T> Lerp(IWorkUnit<T> secondVector, IWorkUnit<T> blend);
        IWorkUnit<T> MagnitudeMax(IWorkUnit<T> secondVector);
        IWorkUnit<T> MagnitudeMin(IWorkUnit<T> secondVector);
        IWorkUnit<T> Multiply(IWorkUnit<T> secondVector);
        IWorkUnit<T> Subtract(IWorkUnit<T> secondVector);
        IWorkUnit<T> Transform(IWorkUnit<T> row0, IWorkUnit<T> row1, IWorkUnit<T> row2);
        IWorkUnit<T> Transform(IWorkUnit<T> quaternion);
        
        // Quaternion operators
        IWorkUnit<T> Conjugate();
        IWorkUnit<T> Invert();
        IWorkUnit<T> FromAxisAngle(IWorkUnit<T> angle);
        IWorkUnit<T> FromEulerAngles(IWorkUnit<T> angles);
        IWorkUnit<T> FromMatrix3(IWorkUnit<T> row1, IWorkUnit<T> row2);
        IWorkUnit<T> Slerp(IWorkUnit<T> secondQuaternion, IWorkUnit<T> blend);
        IWorkUnit<T> ToAxisAngle();
        IWorkUnit<T> ToAxisAngle(out IWorkUnit<T> angle);
        
        // Common math ops
        IWorkUnit<T> Sqrt();
        // TODO port all these methods https://opentk.net/api/OpenTK.MathHelper.html

        // Storage operators
        unsafe void StoreScalar(T* ptr);
        unsafe void StoreVector2(T* ptr);
        unsafe void StoreVector3(T* ptr);
        unsafe void StoreVector4(T* ptr);
    }
}
