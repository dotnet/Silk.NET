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

        public WorkUnit<float> DotProduct2(WorkUnit<float> left, WorkUnit<float> right)
        {
            var value1 = left.As128();
            var value2 = right.As128();

            if (Sse41.IsSupported)
            {
                value1 = Sse41.DotProduct(value1, value2, 0b_0011_0011);
            }
            else
            {
                value1 = Sse.Multiply(value1, value2);

                if (Sse3.IsSupported)
                {
                    value1 = Sse3.HorizontalAdd(value1, value1);
                    value1 = Sse3.HorizontalAdd(value1, value1);
                }
                else
                {
                    float tmp = value1.GetElement(0) + value1.GetElement(1);

                    value1 = Vector128.Create(tmp);
                }
            }

            return Convert(value1);
        }

        public WorkUnit<float> DotProduct3(WorkUnit<float> left, WorkUnit<float> right)
        {
            var value1 = left.As128();
            var value2 = right.As128();

            if (Sse41.IsSupported)
            {
                value1 = Sse41.DotProduct(value1, value2, 0b_0111_1111);
            }
            else
            {
                value1 = Sse.Multiply(value1, value2);

                if (Sse3.IsSupported)
                {
                    value1 = Sse3.HorizontalAdd(value1, value1);
                    value1 = Sse3.HorizontalAdd(value1, value1);
                }
                else
                {
                    float tmp = value1.GetElement(0) + value1.GetElement(1) + value1.GetElement(2);

                    value1 = Vector128.Create(tmp);
                }
            }

            return Convert(value1);
        }

        public WorkUnit<float> DotProduct4(WorkUnit<float> left, WorkUnit<float> right)
        {
            var value1 = left.As128();
            var value2 = right.As128();

            if (Sse41.IsSupported)
            {
                value1 = Sse41.DotProduct(value1, value2, 0b_1111_1111);
            }
            else
            {
                value1 = Sse.Multiply(value1, value2);

                if (Sse3.IsSupported)
                {
                    value1 = Sse3.HorizontalAdd(value1, value1);
                    value1 = Sse3.HorizontalAdd(value1, value1);
                }
                else
                {
                    float tmp = value1.GetElement(0) + value1.GetElement(1) + value1.GetElement(2) + value1.GetElement(3);

                    value1 = Vector128.Create(tmp);
                }
            }

            return Convert(value1);
        }

        public WorkUnit<float> Add(WorkUnit<float> left, WorkUnit<float> right)
        {
            var tLeft = left.As128();
            var tRight = right.As128();

            tLeft = Sse.Add(tLeft, tRight);

            return Convert(tLeft);
        }

        public WorkUnit<float> Subtract(WorkUnit<float> left, WorkUnit<float> right)
        {
            var tLeft = left.As128();
            var tRight = right.As128();

            tLeft = Sse.Subtract(tLeft, tRight);

            return Convert(tLeft);
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
            var value = Sse.Xor(vector.As128(), Helpers.SignConstant);

            return Convert(value);
        }

        //TODO: Validate Algorithm
        public WorkUnit<float> Lerp(WorkUnit<float> left, WorkUnit<float> right, WorkUnit<float> amount)
        {
            Vector128<float> firstInfluence, secondInfluence;

            secondInfluence = amount.As128();

            if (Avx2.IsSupported)
            {
                secondInfluence = Avx2.BroadcastScalarToVector128(secondInfluence);
            }
            else
            {
                secondInfluence = Sse.Shuffle(secondInfluence, secondInfluence, 0b_00_00_00_00);
            }

            firstInfluence = Sse.Subtract(Helpers.OneF, secondInfluence);

            firstInfluence = Sse.Multiply(firstInfluence, left.As128());

            secondInfluence = Sse.Multiply(secondInfluence, right.As128());

            return Convert(Sse.Add(firstInfluence, secondInfluence));
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
            var value = Sse.And(vector.As128(), Helpers.AbsConstant);

            return Convert(value);
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
            var tmp = vector.As128();

            tmp = Sse.Shuffle(tmp, tmp, 0b_00_00_00_00);

            return Convert(tmp);
        }

        public WorkUnit<float> Y(WorkUnit<float> vector)
        {
            var tmp = vector.As128();

            tmp = Sse.Shuffle(tmp, tmp, 0b_01_01_01_01);

            return Convert(tmp);
        }

        public unsafe WorkUnit<float> Z(WorkUnit<float> vector)
        {
            var tmp = vector.As128();

            tmp = Sse.Shuffle(tmp, tmp, 0b_10_10_10_10);

            return Convert(tmp);
        }

        public WorkUnit<float> W(WorkUnit<float> vector)
        {
            var tmp = vector.As128();

            tmp = Sse.Shuffle(tmp, tmp, 0b_11_11_11_11);

            return Convert(tmp);
        }

        public WorkUnit<float> Sin(WorkUnit<float> vector)
        {
            var tmp = vector.As128();

            tmp = Helpers.Sin(tmp);

            return Convert(tmp);
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
            Vector128<float> tx = x.As128(), ty = y.As128(), tz = z.As128();

            return Convert(Helpers.MultiplyAdd(tx, ty, tz));
        }

        public WorkUnit<float>  MultiplyAddFast(WorkUnit<float> x, WorkUnit<float> y, WorkUnit<float> z)
        {
            Vector128<float> tx = x.As128(), ty = y.As128(), tz = z.As128();

            return Convert(Helpers.MultiplyAdd(tx, ty, tz));
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
            Sse.StoreScalar(ptr, vector.As128());
        }

        public unsafe void StoreVector2(WorkUnit<float> vector, float* ptr)
        {
            Sse.StoreLow(ptr, vector.As128());
        }

        public unsafe void StoreVector3(WorkUnit<float> vector, float* ptr)
        {
            var value = vector.As128();
            Sse.StoreLow(ptr, value);

            //ptr[2] = value.GetElement(2);

            value = Sse.Shuffle(value, value, 0b_10_00_00_00);

            Sse.StoreScalar(ptr + 2, value);
        }

        public unsafe void StoreVector4(WorkUnit<float> vector, float* ptr)
        {
            Sse.Store(ptr, vector.As128());
        }

        public unsafe WorkUnit<float> ToScalar(float* ptr)
        {
            var tmp = Sse.LoadScalarVector128(ptr);
            return Convert(tmp);
        }

        public unsafe WorkUnit<float> ToVector2(float* ptr)
        {
            Vector128<float> reg = default;
            reg = Sse.LoadLow(reg, ptr);
            return Convert(reg);
        }

        public unsafe WorkUnit<float> ToVector3(float* ptr)
        {
            Vector128<float> tmp = default;
            tmp = Sse.LoadLow(tmp, ptr);

            var tmp2 = Sse.LoadScalarVector128(ptr + 2);

            if (Sse41.IsSupported)
            {
                tmp = Sse41.Insert(tmp, tmp2, 0b_00_10_0000);
            }
            else
            {
                tmp = Sse.Shuffle(tmp, tmp2, 0b_00_01_00_11);
            }

            return Convert(tmp);
        }

        public unsafe WorkUnit<float> ToVector4(float* ptr)
        {
            return Convert(Sse.LoadVector128(ptr));
        }
    }
}
