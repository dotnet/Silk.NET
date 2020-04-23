// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Avx
{
    public partial struct AvxRegister : IRegister<long>
    {
        public WorkUnit<long> LengthSquared(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Length(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Normalize2(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> NormalizeApprox2(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Normalize3(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> NormalizeApprox3(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Normalize4(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> NormalizeApprox4(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Conjugate(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Inverse(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> DotProduct2(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> DotProduct3(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> DotProduct4(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Add(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Subtract(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Equal(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> NotEqual(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Negate(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Lerp(WorkUnit<long> left, WorkUnit<long> right, WorkUnit<long> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Slerp(WorkUnit<long> left, WorkUnit<long> right, WorkUnit<long> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Concatenate(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Multiply(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Transform2(WorkUnit<long> value, WorkUnit<long> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Transform3(WorkUnit<long> value, WorkUnit<long> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Transform4(WorkUnit<long> value, WorkUnit<long> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Abs(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> HorizontalAdd(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Shuffle(WorkUnit<long> value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> X(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Y(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Z(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> W(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Sin(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> SinApprox(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Cos(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> CosApprox(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Tan(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> TanApprox(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public void SinCos(WorkUnit<long> vector, out WorkUnit<long> sin, out WorkUnit<long> cos)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Shuffle(WorkUnit<long> left, WorkUnit<long> right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> MultiplyAddFused(WorkUnit<long> x, WorkUnit<long> y, WorkUnit<long> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> MultiplyAddFast(WorkUnit<long> x, WorkUnit<long> y, WorkUnit<long> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> NegateMultiplyAddFused(WorkUnit<long> x, WorkUnit<long> y, WorkUnit<long> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> NegateMultiplyAddFast(WorkUnit<long> x, WorkUnit<long> y, WorkUnit<long> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> MultiplySubtractFused(WorkUnit<long> x, WorkUnit<long> y, WorkUnit<long> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> MultiplySubtractFast(WorkUnit<long> x, WorkUnit<long> y, WorkUnit<long> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> NegateMultiplySubtractFused(WorkUnit<long> x, WorkUnit<long> y, WorkUnit<long> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> NegateMultiplySubtractFast(WorkUnit<long> x, WorkUnit<long> y, WorkUnit<long> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Divide(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Sqrt(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Max(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> Min(WorkUnit<long> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> GreaterThan(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> LessThan(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> GreaterThanOrEqualTo(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<long> LessThanOrEqualTo(WorkUnit<long> left, WorkUnit<long> right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<long> vector, long* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<long> vector, long* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<long> vector, long* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<long> vector, long* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<long> ToScalar(long* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<long> ToVector2(long* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<long> ToVector3(long* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<long> ToVector4(long* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
