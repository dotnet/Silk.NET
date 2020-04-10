// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Software
{
    public partial class SoftwareRegister : IRegister<ushort>
    {
        public unsafe WorkUnit<ushort>* LengthSquared(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Length(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Normalize2(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* NormalizeApprox2(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Normalize3(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* NormalizeApprox3(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Normalize4(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* NormalizeApprox4(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Conjugate(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Inverse(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* DotProduct2(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* DotProduct3(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* DotProduct4(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Add(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Subtract(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Equal(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* NotEqual(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Negate(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Lerp(WorkUnit<ushort>* left, WorkUnit<ushort>* right, WorkUnit<ushort>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Slerp(WorkUnit<ushort>* left, WorkUnit<ushort>* right, WorkUnit<ushort>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Concatenate(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Multiply(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Transform2(WorkUnit<ushort>* value, WorkUnit<ushort>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Transform3(WorkUnit<ushort>* value, WorkUnit<ushort>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Transform4(WorkUnit<ushort>* value, WorkUnit<ushort>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Abs(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* HorizontalAdd(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Shuffle(WorkUnit<ushort>* value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* X(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Y(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Z(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* W(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Sin(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* SinApprox(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Cos(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* CosApprox(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Tan(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* TanApprox(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void SinCos(WorkUnit<ushort>* vector, out WorkUnit<ushort>* sin, out WorkUnit<ushort>* cos)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Shuffle(WorkUnit<ushort>* left, WorkUnit<ushort>* right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* MultiplyAddFused(WorkUnit<ushort>* x, WorkUnit<ushort>* y, WorkUnit<ushort>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* MultiplyAddFast(WorkUnit<ushort>* x, WorkUnit<ushort>* y, WorkUnit<ushort>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* NegateMultiplyAddFused(WorkUnit<ushort>* x, WorkUnit<ushort>* y, WorkUnit<ushort>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* NegateMultiplyAddFast(WorkUnit<ushort>* x, WorkUnit<ushort>* y, WorkUnit<ushort>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* MultiplySubtractFused(WorkUnit<ushort>* x, WorkUnit<ushort>* y, WorkUnit<ushort>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* MultiplySubtractFast(WorkUnit<ushort>* x, WorkUnit<ushort>* y, WorkUnit<ushort>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* NegateMultiplySubtractFused(WorkUnit<ushort>* x, WorkUnit<ushort>* y, WorkUnit<ushort>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* NegateMultiplySubtractFast(WorkUnit<ushort>* x, WorkUnit<ushort>* y, WorkUnit<ushort>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Divide(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Sqrt(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Max(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* Min(WorkUnit<ushort>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* GreaterThan(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* LessThan(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* GreaterThanOrEqualTo(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* LessThanOrEqualTo(WorkUnit<ushort>* left, WorkUnit<ushort>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<ushort>* vector, ushort* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<ushort>* vector, ushort* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<ushort>* vector, ushort* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<ushort>* vector, ushort* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* ToScalar(ushort* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* ToVector2(ushort* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* ToVector3(ushort* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<ushort>* ToVector4(ushort* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
