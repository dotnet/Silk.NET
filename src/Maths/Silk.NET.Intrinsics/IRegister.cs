// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics
{
    public interface IRegister<T> where T:unmanaged
    {
        WorkUnit<T> LengthSquared(WorkUnit<T> vector);
        WorkUnit<T> Length(WorkUnit<T> vector);
        WorkUnit<T> Normalize2(WorkUnit<T> vector);
        WorkUnit<T> NormalizeApprox2(WorkUnit<T> vector);
        WorkUnit<T> Normalize3(WorkUnit<T> vector);
        WorkUnit<T> NormalizeApprox3(WorkUnit<T> vector);
        WorkUnit<T> Normalize4(WorkUnit<T> vector);
        WorkUnit<T> NormalizeApprox4(WorkUnit<T> vector);
        WorkUnit<T> Conjugate(WorkUnit<T> vector);
        WorkUnit<T> Inverse(WorkUnit<T> vector);
        WorkUnit<T> DotProduct2(WorkUnit<T> vector);
        WorkUnit<T> DotProduct3(WorkUnit<T> vector);
        WorkUnit<T> DotProduct4(WorkUnit<T> vector);
        WorkUnit<T> Add(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> Subtract(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> Equal(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> NotEqual(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> Negate(WorkUnit<T> vector);
        WorkUnit<T> Lerp(WorkUnit<T> left, WorkUnit<T> right, WorkUnit<T> amount);
        WorkUnit<T> Slerp(WorkUnit<T> left, WorkUnit<T> right, WorkUnit<T> amount);
        WorkUnit<T> Concatenate(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> Multiply(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> Transform2(WorkUnit<T> value, WorkUnit<T> quaternion);
        WorkUnit<T> Transform3(WorkUnit<T> value, WorkUnit<T> quaternion);
        WorkUnit<T> Transform4(WorkUnit<T> value, WorkUnit<T> quaternion);
        WorkUnit<T> Abs(WorkUnit<T> vector);
        WorkUnit<T> HorizontalAdd(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> Shuffle(WorkUnit<T> value, byte control);
        WorkUnit<T> X(WorkUnit<T> vector);
        WorkUnit<T> Y(WorkUnit<T> vector);
        WorkUnit<T> Z(WorkUnit<T> vector);
        WorkUnit<T> W(WorkUnit<T> vector);
        WorkUnit<T> Sin(WorkUnit<T> vector);
        WorkUnit<T> SinApprox(WorkUnit<T> vector);
        WorkUnit<T> Cos(WorkUnit<T> vector);
        WorkUnit<T> CosApprox(WorkUnit<T> vector);
        WorkUnit<T> Tan(WorkUnit<T> vector);
        WorkUnit<T> TanApprox(WorkUnit<T> vector);
        void SinCos(WorkUnit<T> vector, out WorkUnit<T> sin, out WorkUnit<T> cos);
        WorkUnit<T> Shuffle(WorkUnit<T> left, WorkUnit<T> right, byte control);
        WorkUnit<T> MultiplyAddFused(WorkUnit<T> x, WorkUnit<T> y, WorkUnit<T> z);
        WorkUnit<T> MultiplyAddFast(WorkUnit<T> x, WorkUnit<T> y, WorkUnit<T> z);
        WorkUnit<T> NegateMultiplyAddFused(WorkUnit<T> x, WorkUnit<T> y, WorkUnit<T> z);
        WorkUnit<T> NegateMultiplyAddFast(WorkUnit<T> x, WorkUnit<T> y, WorkUnit<T> z);
        WorkUnit<T> MultiplySubtractFused(WorkUnit<T> x, WorkUnit<T> y, WorkUnit<T> z);
        WorkUnit<T> MultiplySubtractFast(WorkUnit<T> x, WorkUnit<T> y, WorkUnit<T> z);
        WorkUnit<T> NegateMultiplySubtractFused(WorkUnit<T> x, WorkUnit<T> y, WorkUnit<T> z);
        WorkUnit<T> NegateMultiplySubtractFast(WorkUnit<T> x, WorkUnit<T> y, WorkUnit<T> z);
        WorkUnit<T> Divide(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> Sqrt(WorkUnit<T> vector);
        WorkUnit<T> Max(WorkUnit<T> vector);
        WorkUnit<T> Min(WorkUnit<T> vector);
        WorkUnit<T> GreaterThan(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> LessThan(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> GreaterThanOrEqualTo(WorkUnit<T> left, WorkUnit<T> right);
        WorkUnit<T> LessThanOrEqualTo(WorkUnit<T> left, WorkUnit<T> right);
        unsafe void StoreScalar(WorkUnit<T> vector, T* ptr);
        unsafe void StoreVector2(WorkUnit<T> vector, T* ptr);
        unsafe void StoreVector3(WorkUnit<T> vector, T* ptr);
        unsafe void StoreVector4(WorkUnit<T> vector, T* ptr);
        unsafe WorkUnit<T> ToScalar(T* ptr);
        unsafe WorkUnit<T> ToVector2(T* ptr);
        unsafe WorkUnit<T> ToVector3(T* ptr);
        unsafe WorkUnit<T> ToVector4(T* ptr);
    }
}
