// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Diagnostics;

using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Intrinsics.Sse
{
    using Sse = System.Runtime.Intrinsics.X86.Sse;

    public partial struct SseRegister : IRegister<float>
    {
        public WorkUnit<float> LengthSquared(WorkUnit<float> vector)
        {
            Vector128<float> value = vector.As128();

            value = Sse.Multiply(value, value);

            if (Sse3.IsSupported)
            {
                value = Sse3.HorizontalAdd(value, value);
                value = Sse3.HorizontalAdd(value, value);
            }
            else
            {
                float tmp = value.GetElement(0) + value.GetElement(1) + value.GetElement(2) + value.GetElement(3);
                value = Vector128.CreateScalar(tmp);
            }

            return Convert(value);
        }

        public WorkUnit<float> Length(WorkUnit<float> vector)
        {
            Vector128<float> value = vector.As128();

            if (Sse41.IsSupported)
            {
                value = Sse41.DotProduct(value, value, 0b_1111_0001);
            }
            else
            {
                value = Sse.Multiply(value, value);

                if (Sse3.IsSupported)
                {
                    value = Sse3.HorizontalAdd(value, value);
                    value = Sse3.HorizontalAdd(value, value);
                }
                else
                {
                    float tmp = value.GetElement(0) + value.GetElement(1) + value.GetElement(2) + value.GetElement(3);

                    value = Vector128.CreateScalar(tmp);
                }
            }

            value = Sse.SqrtScalar(value);

            return Convert(value);
        }

        public WorkUnit<float> Normalize2(WorkUnit<float> vector)
        {
            var value = vector.As128();
            var value2 = value;

            if (Sse41.IsSupported)
            {
                value = Sse41.DotProduct(value, value, 0b_0011_0011);
            }
            else
            {
                value = Sse.Multiply(value, value);

                if (Sse3.IsSupported)
                {
                    value = Sse3.HorizontalAdd(value, value);
                    value = Sse3.HorizontalAdd(value, value);
                }
                else
                {
                    float tmp = value.GetElement(0) + value.GetElement(1);

                    value = Vector128.Create(tmp);
                }
            }

            value = Sse.Sqrt(value);

            value = Sse.Divide(value2, value);

            return Convert(value);
        }

        public WorkUnit<float> NormalizeApprox2(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Normalize3(WorkUnit<float> vector)
        {
            var value = vector.As128();
            var value2 = value;

            if (Sse41.IsSupported)
            {
                value = Sse41.DotProduct(value, value, 0b_0111_0111);
            }
            else
            {
                value = Sse.Multiply(value, value);

                if (Sse3.IsSupported)
                {
                    value = Sse3.HorizontalAdd(value, value);
                    value = Sse3.HorizontalAdd(value, value);
                }
                else
                {
                    float tmp = value.GetElement(0) + value.GetElement(1) + value.GetElement(2);

                    value = Vector128.Create(tmp);
                }
            }

            value = Sse.Sqrt(value);

            value = Sse.Divide(value2, value);

            return Convert(value);
        }

        public WorkUnit<float> NormalizeApprox3(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Normalize4(WorkUnit<float> vector)
        {
            var value = vector.As128();
            var value2 = value;

            if (Sse41.IsSupported)
            {
                value = Sse41.DotProduct(value, value, 0b_1111_1111);
            }
            else
            {
                value = Sse.Multiply(value, value);

                if (Sse3.IsSupported)
                {
                    value = Sse3.HorizontalAdd(value, value);
                    value = Sse3.HorizontalAdd(value, value);
                }
                else
                {
                    float tmp = value.GetElement(0) + value.GetElement(1) + value.GetElement(2) + value.GetElement(3);

                    value = Vector128.Create(tmp);
                }
            }

            value = Sse.Sqrt(value);

            value = Sse.Divide(value2, value);

            return Convert(value);
        }

        public WorkUnit<float> NormalizeApprox4(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Conjugate(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Inverse(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> DotProduct2(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> DotProduct3(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> DotProduct4(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Add(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Subtract(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Equal(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> NotEqual(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Negate(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Lerp(WorkUnit<float> left, WorkUnit<float> right, WorkUnit<float> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Slerp(WorkUnit<float> left, WorkUnit<float> right, WorkUnit<float> amount)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Concatenate(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Multiply(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Transform2(WorkUnit<float> value, WorkUnit<float> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Transform3(WorkUnit<float> value, WorkUnit<float> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Transform4(WorkUnit<float> value, WorkUnit<float> quaternion)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Abs(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> HorizontalAdd(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Shuffle(WorkUnit<float> value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> X(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Y(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Z(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> W(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Sin(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> SinApprox(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Cos(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> CosApprox(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Tan(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> TanApprox(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public void SinCos(WorkUnit<float> vector, out WorkUnit<float> sin, out WorkUnit<float> cos)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Shuffle(WorkUnit<float> left, WorkUnit<float> right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> MultiplyAddFused(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> MultiplyAddFast(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> NegateMultiplyAddFused(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> NegateMultiplyAddFast(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> MultiplySubtractFused(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> MultiplySubtractFast(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> NegateMultiplySubtractFused(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> NegateMultiplySubtractFast(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Divide(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Sqrt(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Max(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> Min(WorkUnit<float> vector)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> GreaterThan(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> LessThan(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> GreaterThanOrEqualTo(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public WorkUnit<float> LessThanOrEqualTo(WorkUnit<float> left, WorkUnit<float> right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<float> vector, float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<float> vector, float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<float> vector, float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<float> vector, float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float> ToScalar(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float> ToVector2(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float> ToVector3(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float> ToVector4(float* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
