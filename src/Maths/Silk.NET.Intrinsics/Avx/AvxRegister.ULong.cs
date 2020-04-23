// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Avx
{
    public partial struct AvxRegister : IRegister<ulong>
    {
        public WorkUnit<ulong> LengthSquared(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Length(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Normalize2(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> NormalizeApprox2(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Normalize3(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> NormalizeApprox3(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Normalize4(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> NormalizeApprox4(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Conjugate(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Inverse(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> DotProduct2(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> DotProduct3(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> DotProduct4(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Add(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Subtract(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Equal(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> NotEqual(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Negate(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Lerp(WorkUnit<ulong> left, WorkUnit<ulong> right, WorkUnit<ulong> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Slerp(WorkUnit<ulong> left, WorkUnit<ulong> right, WorkUnit<ulong> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Concatenate(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Multiply(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Transform2(WorkUnit<ulong> value, WorkUnit<ulong> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Transform3(WorkUnit<ulong> value, WorkUnit<ulong> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Transform4(WorkUnit<ulong> value, WorkUnit<ulong> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Abs(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> HorizontalAdd(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Shuffle(WorkUnit<ulong> value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> X(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Y(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Z(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> W(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Sin(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> SinApprox(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Cos(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> CosApprox(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Tan(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> TanApprox(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public void SinCos(WorkUnit<ulong> vector, out WorkUnit<ulong> sin, out WorkUnit<ulong> cos)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Shuffle(WorkUnit<ulong> left, WorkUnit<ulong> right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> MultiplyAddFused(WorkUnit<ulong> x, WorkUnit<ulong> y, WorkUnit<ulong> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> MultiplyAddFast(WorkUnit<ulong> x, WorkUnit<ulong> y, WorkUnit<ulong> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> NegateMultiplyAddFused(WorkUnit<ulong> x, WorkUnit<ulong> y, WorkUnit<ulong> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> NegateMultiplyAddFast(WorkUnit<ulong> x, WorkUnit<ulong> y, WorkUnit<ulong> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> MultiplySubtractFused(WorkUnit<ulong> x, WorkUnit<ulong> y, WorkUnit<ulong> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> MultiplySubtractFast(WorkUnit<ulong> x, WorkUnit<ulong> y, WorkUnit<ulong> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> NegateMultiplySubtractFused(WorkUnit<ulong> x, WorkUnit<ulong> y, WorkUnit<ulong> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> NegateMultiplySubtractFast(WorkUnit<ulong> x, WorkUnit<ulong> y, WorkUnit<ulong> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Divide(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Sqrt(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Max(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> Min(WorkUnit<ulong> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> GreaterThan(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> LessThan(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> GreaterThanOrEqualTo(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<ulong> LessThanOrEqualTo(WorkUnit<ulong> left, WorkUnit<ulong> right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<ulong> vector, ulong* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<ulong> vector, ulong* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<ulong> vector, ulong* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<ulong> vector, ulong* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ulong> ToScalar(ulong* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ulong> ToVector2(ulong* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ulong> ToVector3(ulong* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ulong> ToVector4(ulong* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
