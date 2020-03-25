// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics
{
    public interface IRegister<T> where T:unmanaged
    {
        // Vector operators
        unsafe WorkUnit<T>* Add(WorkUnit<T>* firstVector, WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Clamp(WorkUnit<T>* firstVector, WorkUnit<T>* min, WorkUnit<T>* max);
        unsafe WorkUnit<T>* ComponentMax(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* ComponentMin(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* Divide(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* DotProduct2(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* DotProduct3(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* DotProduct4(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* Equals(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* Lerp(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector, WorkUnit<T>* blend);
        unsafe WorkUnit<T>* MagnitudeMax(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* MagnitudeMin(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* Multiply(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* Subtract(WorkUnit<T>* firstVector, WorkUnit<T>* secondVector);
        unsafe WorkUnit<T>* Transform(WorkUnit<T>* firstVector, WorkUnit<T>* row0, WorkUnit<T>* row1, WorkUnit<T>* row2);
        unsafe WorkUnit<T>* Transform(WorkUnit<T>* firstVector, WorkUnit<T>* quaternion); // Quaternion operators
        unsafe WorkUnit<T>* Conjugate(WorkUnit<T>* firstVector);
        unsafe WorkUnit<T>* Invert(WorkUnit<T>* firstVector);
        unsafe WorkUnit<T>* FromAxisAngle(WorkUnit<T>* firstVector, WorkUnit<T>* angle);
        unsafe WorkUnit<T>* FromEulerAngles(WorkUnit<T>* firstVector, WorkUnit<T>* angles);
        unsafe WorkUnit<T>* FromMatrix3(WorkUnit<T>* firstVector, WorkUnit<T>* row1, WorkUnit<T>* row2);
        unsafe WorkUnit<T>* Slerp(WorkUnit<T>* firstVector, WorkUnit<T>* secondQuaternion, WorkUnit<T>* blend);
        unsafe WorkUnit<T>* ToAxisAngle(WorkUnit<T>* firstVector);
        unsafe WorkUnit<T>* ToAxisAngle(WorkUnit<T>* firstVector, out WorkUnit<T>* angle); // Common math ops
        unsafe WorkUnit<T>* Sqrt(WorkUnit<T>* firstVector); // TODO port all these methods https://opentk.net/api/OpenTK.MathHelper.html
        unsafe void StoreScalar(WorkUnit<T>* vector, T* ptr); // Storage operators
        unsafe void StoreVector2(WorkUnit<T>* vector, T* ptr);
        unsafe void StoreVector3(WorkUnit<T>* vector, T* ptr);
        unsafe void StoreVector4(WorkUnit<T>* vector, T* ptr);
        unsafe WorkUnit<T>* ToScalar(T* ptr);
        unsafe WorkUnit<T>* ToVector2(T* ptr);
        unsafe WorkUnit<T>* ToVector3(T* ptr);
        unsafe WorkUnit<T>* ToVector4(T* ptr);
    }
}
