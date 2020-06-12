// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Intrinsics
{
    public static unsafe class IntrinsicMaths<T> where T:unmanaged
    {
        public static readonly int VectorSize = typeof(T) == typeof(float) ? FloatMaths.VectorSize :
            typeof(T) == typeof(double) ? DoubleMaths.VectorSize :
            typeof(T) == typeof(int) ? IntMaths.VectorSize :
            typeof(T) == typeof(uint) ? UIntMaths.VectorSize :
            typeof(T) == typeof(short) ? ShortMaths.VectorSize :
            typeof(T) == typeof(ushort) ? UShortMaths.VectorSize :
            typeof(T) == typeof(long) ? LongMaths.VectorSize :
            typeof(T) == typeof(ulong) ? ULongMaths.VectorSize :
            typeof(T) == typeof(byte) ? ByteMaths.VectorSize :
            typeof(T) == typeof(sbyte) ? SByteMaths.VectorSize : throw GetTypeNotSupportedException();
        
        internal static NotSupportedException GetTypeNotSupportedException()
            => throw new NotSupportedException("Mathematical operations are not supported on this type.");

        public static void ThrowIfTypeNotSupported()
        {
            if (typeof(T) != typeof(double) &&
                typeof(T) != typeof(int) &&
                typeof(T) != typeof(uint) &&
                typeof(T) != typeof(short) &&
                typeof(T) != typeof(ushort) &&
                typeof(T) != typeof(long) &&
                typeof(T) != typeof(ulong) &&
                typeof(T) != typeof(byte) &&
                typeof(T) != typeof(sbyte) &&
                typeof(T) != typeof(float))
            {
                throw GetTypeNotSupportedException();
            }
        }
            
        /// <summary>loads a value and stores it into a vector</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ld1(byte* outputMemory, T* input) => throw new NotImplementedException();

        /// <summary>loads a value and stores it into a vector</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ld2(byte* outputMemory, T* input) => throw new NotImplementedException();

        /// <summary>loads a value and stores it into a vector</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ld3(byte* outputMemory, T* input) => throw new NotImplementedException();

        /// <summary>loads a value and stores it into a vector</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ld4(byte* outputMemory, T* input) => throw new NotImplementedException();

        /// <summary>stores the vector.</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 0 value(s) to the output memory.
        /// </remarks>
        public static void St1(byte* inputMemory, T* output) => throw new NotImplementedException();

        /// <summary>stores the vector.</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 0 value(s) to the output memory.
        /// </remarks>
        public static void St2(byte* inputMemory, T* output) => throw new NotImplementedException();

        /// <summary>stores the vector.</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 0 value(s) to the output memory.
        /// </remarks>
        public static void St3(byte* inputMemory, T* output) => throw new NotImplementedException();

        /// <summary>stores the vector.</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 0 value(s) to the output memory.
        /// </remarks>
        public static void St4(byte* inputMemory, T* output) => throw new NotImplementedException();

        /// <summary>load constant value</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ldc(byte* outputMemory, ConstantValue value) => throw new NotImplementedException();

        /// <summary>and operation</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void And(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>exclusive or</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Xor(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>or</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Or(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>horizontal add</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void AddH(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>add</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Add(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>substract</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Sub(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>multiply</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Mul(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>divide</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Div(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>reciprocal</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Rec(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>square root</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Sqrt(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary> reciprocal square root</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void RecSqrt(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>maximum</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Max(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>minimum</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Min(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>round to nearest integer</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// This requires 0 value(s) worth of space in temporary memory.
        /// </remarks>
        public static void Rnd(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>round to zero (truncate)</summary>
        public static void RndZ(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>round down (floor)</summary>
        public static void RndL(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>round up (ceiling)</summary>
        public static void RndH(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>compare equal</summary>
        public static void Eq(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>compare not equal</summary>
        public static void Neq(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>compare greater than</summary>
        public static void Gt(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>compare less than</summary>
        public static void Lt(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>greater than or equal</summary>
        public static void Gte(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>less than or equal</summary>
        public static void Lte(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>broadcasts a scalar to a vector</summary>
        public static void Stv(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>permutes a vector using a control byte</summary>
        public static void Pmt(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>shuffles two vectors using a control byte</summary>
        public static void Shf(byte* inputMemory, byte* outputMemory, byte control)
            => throw new NotImplementedException();

        /// <summary>computes the sine of a vector's elements</summary>
        public static void Sin(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the cosine of a vector's elements</summary>
        public static void Cos(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the tangent of a vector's elements</summary>
        public static void Tan(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the sine of a vector's elements (approx)</summary>
        public static void SinA(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the cosine of a vector's elements (approx)</summary>
        public static void CosA(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the tangent of a vector's elements (approx)</summary>
        public static void TanA(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>atan</summary>
        public static void ATan(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>atan2</summary>
        public static void ATan2(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>dot product</summary>
        public static void Dot2(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>dot product</summary>
        public static void Dot3(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>dot product</summary>
        public static void Dot4(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>cross product</summary>
        public static void Cro2(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>cross product</summary>
        public static void Cro3(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();

        /// <summary>cross product</summary>
        public static void Cro4(byte* inputMemory, byte* outputMemory) => throw new NotImplementedException();
        
        public static void IsTrue(byte* inputMemory) => throw new NotImplementedException();
        public static void IsFalse(byte* inputMemory) => throw new NotImplementedException();

        /// <summary>Reorders vector memory according to </summary>
        public static void Reorder(byte* memory, int num, uint* indices)
        {
            var tempCopy = stackalloc byte[VectorSize * num];
            for (var i = 0; i < VectorSize * num; i++)
            {
                tempCopy[i] = memory[i];
            }

            var k = 0;
            for (var i = 0; i < num; i++)
            {
                var index = indices[i];
                for (var j = index; j < index + VectorSize; j++)
                {
                    memory[k++] = tempCopy[j];
                }
            }
        }
    }
}
