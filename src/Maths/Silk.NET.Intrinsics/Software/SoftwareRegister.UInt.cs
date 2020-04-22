// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Software
{
    public partial struct SoftwareRegister : IRegister<uint>
    {
        public WorkUnit<uint> LengthSquared(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Length(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Normalize2(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> NormalizeApprox2(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Normalize3(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> NormalizeApprox3(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Normalize4(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> NormalizeApprox4(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Conjugate(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Inverse(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> DotProduct2(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> DotProduct3(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> DotProduct4(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Add(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Subtract(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Equal(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> NotEqual(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Negate(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Lerp(WorkUnit<uint> left, WorkUnit<uint> right, WorkUnit<uint> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Slerp(WorkUnit<uint> left, WorkUnit<uint> right, WorkUnit<uint> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Concatenate(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Multiply(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Transform2(WorkUnit<uint> value, WorkUnit<uint> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Transform3(WorkUnit<uint> value, WorkUnit<uint> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Transform4(WorkUnit<uint> value, WorkUnit<uint> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Abs(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> HorizontalAdd(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Shuffle(WorkUnit<uint> value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> X(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Y(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Z(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> W(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Sin(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> SinApprox(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Cos(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> CosApprox(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Tan(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> TanApprox(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public void SinCos(WorkUnit<uint> vector, out WorkUnit<uint> sin, out WorkUnit<uint> cos)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Shuffle(WorkUnit<uint> left, WorkUnit<uint> right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> MultiplyAddFused(WorkUnit<uint> x, WorkUnit<uint> y, WorkUnit<uint> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> MultiplyAddFast(WorkUnit<uint> x, WorkUnit<uint> y, WorkUnit<uint> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> NegateMultiplyAddFused(WorkUnit<uint> x, WorkUnit<uint> y, WorkUnit<uint> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> NegateMultiplyAddFast(WorkUnit<uint> x, WorkUnit<uint> y, WorkUnit<uint> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> MultiplySubtractFused(WorkUnit<uint> x, WorkUnit<uint> y, WorkUnit<uint> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> MultiplySubtractFast(WorkUnit<uint> x, WorkUnit<uint> y, WorkUnit<uint> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> NegateMultiplySubtractFused(WorkUnit<uint> x, WorkUnit<uint> y, WorkUnit<uint> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> NegateMultiplySubtractFast(WorkUnit<uint> x, WorkUnit<uint> y, WorkUnit<uint> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Divide(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Sqrt(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Max(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> Min(WorkUnit<uint> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> GreaterThan(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> LessThan(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> GreaterThanOrEqualTo(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<uint> LessThanOrEqualTo(WorkUnit<uint> left, WorkUnit<uint> right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<uint> vector, uint* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<uint> vector, uint* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<uint> vector, uint* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<uint> vector, uint* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<uint> ToScalar(uint* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<uint> ToVector2(uint* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<uint> ToVector3(uint* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<uint> ToVector4(uint* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
