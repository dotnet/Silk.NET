// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics
{
    public interface IRegister<T> where T:unmanaged
    {
        unsafe WorkUnit<T>* LengthSquared(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Length(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Normalize2(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* NormalizeApprox2(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Normalize3(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* NormalizeApprox3(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Normalize4(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* NormalizeApprox4(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Conjugate(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Inverse(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* DotProduct2(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* DotProduct3(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* DotProduct4(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Add(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* Subtract(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* Equal(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* NotEqual(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* Negate(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Lerp(WorkUnit<T>* left, WorkUnit<T>* right, WorkUnit<T>* amount);
        unsafe WorkUnit<T>* Slerp(WorkUnit<T>* left, WorkUnit<T>* right, WorkUnit<T>* amount);
        unsafe WorkUnit<T>* Concatenate(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* Multiply(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* Transform2(WorkUnit<T>* value, WorkUnit<T>* quaternion);
        unsafe WorkUnit<T>* Transform3(WorkUnit<T>* value, WorkUnit<T>* quaternion);
        unsafe WorkUnit<T>* Transform4(WorkUnit<T>* value, WorkUnit<T>* quaternion);
        unsafe WorkUnit<T>* Abs(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* HorizontalAdd(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* Shuffle(WorkUnit<T>* value, byte control);
        unsafe WorkUnit<T>* X(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Y(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Z(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* W(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Sin(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* SinApprox(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Cos(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* CosApprox(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Tan(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* TanApprox(WorkUnit<T>* vector);
        unsafe void SinCos(WorkUnit<T>* vector, out WorkUnit<T>* sin, out WorkUnit<T>* cos);
        unsafe WorkUnit<T>* Shuffle(WorkUnit<T>* left, WorkUnit<T>* right, byte control);
        unsafe WorkUnit<T>* MultiplyAddFused(WorkUnit<T>* x, WorkUnit<T>* y, WorkUnit<T>* z);
        unsafe WorkUnit<T>* MultiplyAddFast(WorkUnit<T>* x, WorkUnit<T>* y, WorkUnit<T>* z);
        unsafe WorkUnit<T>* NegateMultiplyAddFused(WorkUnit<T>* x, WorkUnit<T>* y, WorkUnit<T>* z);
        unsafe WorkUnit<T>* NegateMultiplyAddFast(WorkUnit<T>* x, WorkUnit<T>* y, WorkUnit<T>* z);
        unsafe WorkUnit<T>* MultiplySubtractFused(WorkUnit<T>* x, WorkUnit<T>* y, WorkUnit<T>* z);
        unsafe WorkUnit<T>* MultiplySubtractFast(WorkUnit<T>* x, WorkUnit<T>* y, WorkUnit<T>* z);
        unsafe WorkUnit<T>* NegateMultiplySubtractFused(WorkUnit<T>* x, WorkUnit<T>* y, WorkUnit<T>* z);
        unsafe WorkUnit<T>* NegateMultiplySubtractFast(WorkUnit<T>* x, WorkUnit<T>* y, WorkUnit<T>* z);
        unsafe WorkUnit<T>* Divide(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* Sqrt(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Max(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* Min(WorkUnit<T>* vector);
        unsafe WorkUnit<T>* GreaterThan(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* LessThan(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* GreaterThanOrEqualTo(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe WorkUnit<T>* LessThanOrEqualTo(WorkUnit<T>* left, WorkUnit<T>* right);
        unsafe void StoreScalar(WorkUnit<T>* vector, T* ptr);
        unsafe void StoreVector2(WorkUnit<T>* vector, T* ptr);
        unsafe void StoreVector3(WorkUnit<T>* vector, T* ptr);
        unsafe void StoreVector4(WorkUnit<T>* vector, T* ptr);
        unsafe WorkUnit<T>* ToScalar(T* ptr);
        unsafe WorkUnit<T>* ToVector2(T* ptr);
        unsafe WorkUnit<T>* ToVector3(T* ptr);
        unsafe WorkUnit<T>* ToVector4(T* ptr);
    }
}
