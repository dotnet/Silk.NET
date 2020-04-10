// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Software
{
    public partial class SoftwareRegister : IRegister<short>
    {
        public unsafe WorkUnit<short>* LengthSquared(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Length(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Normalize2(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* NormalizeApprox2(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Normalize3(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* NormalizeApprox3(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Normalize4(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* NormalizeApprox4(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Conjugate(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Inverse(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* DotProduct2(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* DotProduct3(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* DotProduct4(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Add(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Subtract(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Equal(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* NotEqual(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Negate(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Lerp(WorkUnit<short>* left, WorkUnit<short>* right, WorkUnit<short>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Slerp(WorkUnit<short>* left, WorkUnit<short>* right, WorkUnit<short>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Concatenate(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Multiply(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Transform2(WorkUnit<short>* value, WorkUnit<short>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Transform3(WorkUnit<short>* value, WorkUnit<short>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Transform4(WorkUnit<short>* value, WorkUnit<short>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Abs(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* HorizontalAdd(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Shuffle(WorkUnit<short>* value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* X(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Y(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Z(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* W(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Sin(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* SinApprox(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Cos(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* CosApprox(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Tan(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* TanApprox(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void SinCos(WorkUnit<short>* vector, out WorkUnit<short>* sin, out WorkUnit<short>* cos)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Shuffle(WorkUnit<short>* left, WorkUnit<short>* right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* MultiplyAddFused(WorkUnit<short>* x, WorkUnit<short>* y, WorkUnit<short>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* MultiplyAddFast(WorkUnit<short>* x, WorkUnit<short>* y, WorkUnit<short>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* NegateMultiplyAddFused(WorkUnit<short>* x, WorkUnit<short>* y, WorkUnit<short>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* NegateMultiplyAddFast(WorkUnit<short>* x, WorkUnit<short>* y, WorkUnit<short>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* MultiplySubtractFused(WorkUnit<short>* x, WorkUnit<short>* y, WorkUnit<short>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* MultiplySubtractFast(WorkUnit<short>* x, WorkUnit<short>* y, WorkUnit<short>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* NegateMultiplySubtractFused(WorkUnit<short>* x, WorkUnit<short>* y, WorkUnit<short>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* NegateMultiplySubtractFast(WorkUnit<short>* x, WorkUnit<short>* y, WorkUnit<short>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Divide(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Sqrt(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Max(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* Min(WorkUnit<short>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* GreaterThan(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* LessThan(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* GreaterThanOrEqualTo(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* LessThanOrEqualTo(WorkUnit<short>* left, WorkUnit<short>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<short>* vector, short* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<short>* vector, short* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<short>* vector, short* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<short>* vector, short* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* ToScalar(short* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* ToVector2(short* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* ToVector3(short* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<short>* ToVector4(short* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
