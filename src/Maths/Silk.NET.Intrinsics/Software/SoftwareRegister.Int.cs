// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Software
{
    public partial class SseRegister : IRegister<int>
    {
        public unsafe WorkUnit<int>* LengthSquared(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Length(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Normalize2(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* NormalizeApprox2(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Normalize3(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* NormalizeApprox3(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Normalize4(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* NormalizeApprox4(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Conjugate(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Inverse(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* DotProduct2(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* DotProduct3(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* DotProduct4(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Add(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Subtract(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Equal(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* NotEqual(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Negate(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Lerp(WorkUnit<int>* left, WorkUnit<int>* right, WorkUnit<int>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Slerp(WorkUnit<int>* left, WorkUnit<int>* right, WorkUnit<int>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Concatenate(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Multiply(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Transform2(WorkUnit<int>* value, WorkUnit<int>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Transform3(WorkUnit<int>* value, WorkUnit<int>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Transform4(WorkUnit<int>* value, WorkUnit<int>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Abs(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* HorizontalAdd(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Shuffle(WorkUnit<int>* value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* X(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Y(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Z(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* W(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Sin(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* SinApprox(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Cos(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* CosApprox(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Tan(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* TanApprox(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void SinCos(WorkUnit<int>* vector, out WorkUnit<int>* sin, out WorkUnit<int>* cos)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Shuffle(WorkUnit<int>* left, WorkUnit<int>* right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* MultiplyAddFused(WorkUnit<int>* x, WorkUnit<int>* y, WorkUnit<int>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* MultiplyAddFast(WorkUnit<int>* x, WorkUnit<int>* y, WorkUnit<int>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* NegateMultiplyAddFused(WorkUnit<int>* x, WorkUnit<int>* y, WorkUnit<int>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* NegateMultiplyAddFast(WorkUnit<int>* x, WorkUnit<int>* y, WorkUnit<int>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* MultiplySubtractFused(WorkUnit<int>* x, WorkUnit<int>* y, WorkUnit<int>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* MultiplySubtractFast(WorkUnit<int>* x, WorkUnit<int>* y, WorkUnit<int>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* NegateMultiplySubtractFused(WorkUnit<int>* x, WorkUnit<int>* y, WorkUnit<int>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* NegateMultiplySubtractFast(WorkUnit<int>* x, WorkUnit<int>* y, WorkUnit<int>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Divide(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Sqrt(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Max(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* Min(WorkUnit<int>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* GreaterThan(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* LessThan(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* GreaterThanOrEqualTo(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* LessThanOrEqualTo(WorkUnit<int>* left, WorkUnit<int>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<int>* vector, int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<int>* vector, int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<int>* vector, int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<int>* vector, int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* ToScalar(int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* ToVector2(int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* ToVector3(int* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<int>* ToVector4(int* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
