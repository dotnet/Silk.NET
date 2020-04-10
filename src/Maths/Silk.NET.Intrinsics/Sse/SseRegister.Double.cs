// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Sse
{
    public partial class SseRegister : IRegister<double>
    {
        public unsafe WorkUnit<double>* LengthSquared(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Length(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Normalize2(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* NormalizeApprox2(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Normalize3(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* NormalizeApprox3(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Normalize4(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* NormalizeApprox4(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Conjugate(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Inverse(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* DotProduct2(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* DotProduct3(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* DotProduct4(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Add(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Subtract(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Equal(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* NotEqual(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Negate(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Lerp(WorkUnit<double>* left, WorkUnit<double>* right, WorkUnit<double>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Slerp(WorkUnit<double>* left, WorkUnit<double>* right, WorkUnit<double>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Concatenate(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Multiply(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Transform2(WorkUnit<double>* value, WorkUnit<double>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Transform3(WorkUnit<double>* value, WorkUnit<double>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Transform4(WorkUnit<double>* value, WorkUnit<double>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Abs(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* HorizontalAdd(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Shuffle(WorkUnit<double>* value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* X(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Y(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Z(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* W(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Sin(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* SinApprox(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Cos(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* CosApprox(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Tan(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* TanApprox(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void SinCos(WorkUnit<double>* vector, out WorkUnit<double>* sin, out WorkUnit<double>* cos)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Shuffle(WorkUnit<double>* left, WorkUnit<double>* right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* MultiplyAddFused(WorkUnit<double>* x, WorkUnit<double>* y, WorkUnit<double>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* MultiplyAddFast(WorkUnit<double>* x, WorkUnit<double>* y, WorkUnit<double>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* NegateMultiplyAddFused(WorkUnit<double>* x, WorkUnit<double>* y, WorkUnit<double>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* NegateMultiplyAddFast(WorkUnit<double>* x, WorkUnit<double>* y, WorkUnit<double>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* MultiplySubtractFused(WorkUnit<double>* x, WorkUnit<double>* y, WorkUnit<double>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* MultiplySubtractFast(WorkUnit<double>* x, WorkUnit<double>* y, WorkUnit<double>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* NegateMultiplySubtractFused(WorkUnit<double>* x, WorkUnit<double>* y, WorkUnit<double>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* NegateMultiplySubtractFast(WorkUnit<double>* x, WorkUnit<double>* y, WorkUnit<double>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Divide(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Sqrt(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Max(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* Min(WorkUnit<double>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* GreaterThan(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* LessThan(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* GreaterThanOrEqualTo(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* LessThanOrEqualTo(WorkUnit<double>* left, WorkUnit<double>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<double>* vector, double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<double>* vector, double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<double>* vector, double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<double>* vector, double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* ToScalar(double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* ToVector2(double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* ToVector3(double* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<double>* ToVector4(double* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
