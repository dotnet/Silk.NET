// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Avx
{
    public partial struct AvxRegister : IRegister<double>
    {
        public WorkUnit<double> LengthSquared(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Length(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Normalize2(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> NormalizeApprox2(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Normalize3(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> NormalizeApprox3(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Normalize4(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> NormalizeApprox4(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Conjugate(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Inverse(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> DotProduct2(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> DotProduct3(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> DotProduct4(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Add(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Subtract(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Equal(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> NotEqual(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Negate(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Lerp(WorkUnit<double> left, WorkUnit<double> right, WorkUnit<double> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Slerp(WorkUnit<double> left, WorkUnit<double> right, WorkUnit<double> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Concatenate(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Multiply(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Transform2(WorkUnit<double> value, WorkUnit<double> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Transform3(WorkUnit<double> value, WorkUnit<double> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Transform4(WorkUnit<double> value, WorkUnit<double> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Abs(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> HorizontalAdd(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Shuffle(WorkUnit<double> value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> X(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Y(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Z(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> W(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Sin(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> SinApprox(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Cos(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> CosApprox(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Tan(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> TanApprox(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public void SinCos(WorkUnit<double> vector, out WorkUnit<double> sin, out WorkUnit<double> cos)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Shuffle(WorkUnit<double> left, WorkUnit<double> right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> MultiplyAddFused(WorkUnit<double> x, WorkUnit<double> y, WorkUnit<double> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> MultiplyAddFast(WorkUnit<double> x, WorkUnit<double> y, WorkUnit<double> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> NegateMultiplyAddFused(WorkUnit<double> x, WorkUnit<double> y, WorkUnit<double> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> NegateMultiplyAddFast(WorkUnit<double> x, WorkUnit<double> y, WorkUnit<double> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> MultiplySubtractFused(WorkUnit<double> x, WorkUnit<double> y, WorkUnit<double> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> MultiplySubtractFast(WorkUnit<double> x, WorkUnit<double> y, WorkUnit<double> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> NegateMultiplySubtractFused(WorkUnit<double> x, WorkUnit<double> y, WorkUnit<double> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> NegateMultiplySubtractFast(WorkUnit<double> x, WorkUnit<double> y, WorkUnit<double> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Divide(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Sqrt(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Max(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> Min(WorkUnit<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> GreaterThan(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> LessThan(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> GreaterThanOrEqualTo(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<double> LessThanOrEqualTo(WorkUnit<double> left, WorkUnit<double> right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<double> vector, double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<double> vector, double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<double> vector, double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<double> vector, double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double> ToScalar(double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double> ToVector2(double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double> ToVector3(double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double> ToVector4(double* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
