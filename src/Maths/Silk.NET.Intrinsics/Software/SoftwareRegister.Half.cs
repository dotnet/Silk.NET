// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Math;

namespace Silk.NET.Intrinsics.Software
{
    public partial struct SoftwareRegister : IRegister<Half>
    {
        public WorkUnit<Half> LengthSquared(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Length(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Normalize2(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> NormalizeApprox2(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Normalize3(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> NormalizeApprox3(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Normalize4(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> NormalizeApprox4(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Conjugate(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Inverse(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> DotProduct2(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> DotProduct3(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> DotProduct4(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Add(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Subtract(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Equal(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> NotEqual(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Negate(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Lerp(WorkUnit<Half> left, WorkUnit<Half> right, WorkUnit<Half> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Slerp(WorkUnit<Half> left, WorkUnit<Half> right, WorkUnit<Half> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Concatenate(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Multiply(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Transform2(WorkUnit<Half> value, WorkUnit<Half> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Transform3(WorkUnit<Half> value, WorkUnit<Half> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Transform4(WorkUnit<Half> value, WorkUnit<Half> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Abs(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> HorizontalAdd(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Shuffle(WorkUnit<Half> value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> X(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Y(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Z(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> W(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Sin(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> SinApprox(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Cos(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> CosApprox(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Tan(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> TanApprox(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public void SinCos(WorkUnit<Half> vector, out WorkUnit<Half> sin, out WorkUnit<Half> cos)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Shuffle(WorkUnit<Half> left, WorkUnit<Half> right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> MultiplyAddFused(WorkUnit<Half> x, WorkUnit<Half> y, WorkUnit<Half> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> MultiplyAddFast(WorkUnit<Half> x, WorkUnit<Half> y, WorkUnit<Half> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> NegateMultiplyAddFused(WorkUnit<Half> x, WorkUnit<Half> y, WorkUnit<Half> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> NegateMultiplyAddFast(WorkUnit<Half> x, WorkUnit<Half> y, WorkUnit<Half> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> MultiplySubtractFused(WorkUnit<Half> x, WorkUnit<Half> y, WorkUnit<Half> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> MultiplySubtractFast(WorkUnit<Half> x, WorkUnit<Half> y, WorkUnit<Half> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> NegateMultiplySubtractFused(WorkUnit<Half> x, WorkUnit<Half> y, WorkUnit<Half> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> NegateMultiplySubtractFast(WorkUnit<Half> x, WorkUnit<Half> y, WorkUnit<Half> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Divide(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Sqrt(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Max(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> Min(WorkUnit<Half> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> GreaterThan(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> LessThan(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> GreaterThanOrEqualTo(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<Half> LessThanOrEqualTo(WorkUnit<Half> left, WorkUnit<Half> right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<Half> vector, Half* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<Half> vector, Half* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<Half> vector, Half* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<Half> vector, Half* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<Half> ToScalar(Half* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<Half> ToVector2(Half* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<Half> ToVector3(Half* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<Half> ToVector4(Half* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
