// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Avx
{
    public partial struct AvxRegister : IRegister<int>
    {
        public WorkUnit<int> LengthSquared(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Length(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Normalize2(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> NormalizeApprox2(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Normalize3(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> NormalizeApprox3(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Normalize4(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> NormalizeApprox4(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Conjugate(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Inverse(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> DotProduct2(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> DotProduct3(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> DotProduct4(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Add(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Subtract(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Equal(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> NotEqual(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Negate(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Lerp(WorkUnit<int> left, WorkUnit<int> right, WorkUnit<int> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Slerp(WorkUnit<int> left, WorkUnit<int> right, WorkUnit<int> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Concatenate(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Multiply(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Transform2(WorkUnit<int> value, WorkUnit<int> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Transform3(WorkUnit<int> value, WorkUnit<int> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Transform4(WorkUnit<int> value, WorkUnit<int> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Abs(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> HorizontalAdd(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Shuffle(WorkUnit<int> value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> X(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Y(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Z(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> W(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Sin(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> SinApprox(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Cos(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> CosApprox(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Tan(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> TanApprox(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public void SinCos(WorkUnit<int> vector, out WorkUnit<int> sin, out WorkUnit<int> cos)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Shuffle(WorkUnit<int> left, WorkUnit<int> right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> MultiplyAddFused(WorkUnit<int> x, WorkUnit<int> y, WorkUnit<int> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> MultiplyAddFast(WorkUnit<int> x, WorkUnit<int> y, WorkUnit<int> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> NegateMultiplyAddFused(WorkUnit<int> x, WorkUnit<int> y, WorkUnit<int> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> NegateMultiplyAddFast(WorkUnit<int> x, WorkUnit<int> y, WorkUnit<int> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> MultiplySubtractFused(WorkUnit<int> x, WorkUnit<int> y, WorkUnit<int> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> MultiplySubtractFast(WorkUnit<int> x, WorkUnit<int> y, WorkUnit<int> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> NegateMultiplySubtractFused(WorkUnit<int> x, WorkUnit<int> y, WorkUnit<int> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> NegateMultiplySubtractFast(WorkUnit<int> x, WorkUnit<int> y, WorkUnit<int> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Divide(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Sqrt(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Max(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> Min(WorkUnit<int> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> GreaterThan(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> LessThan(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> GreaterThanOrEqualTo(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<int> LessThanOrEqualTo(WorkUnit<int> left, WorkUnit<int> right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<int> vector, int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<int> vector, int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<int> vector, int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<int> vector, int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int> ToScalar(int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int> ToVector2(int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int> ToVector3(int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int> ToVector4(int* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
