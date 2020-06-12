// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Maths;

namespace Silk.NET.Intrinsics
{
    internal static unsafe class SByteMaths
    {
        public static readonly int VectorSize = sizeof(sbyte) * 4;
        
        /// <summary>loads a value and stores it into a vector</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ld1(sbyte* outputMemory, sbyte* input) => throw new NotImplementedException();

        /// <summary>loads a value and stores it into a vector</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ld2(sbyte* outputMemory, sbyte* input) => throw new NotImplementedException();

        /// <summary>loads a value and stores it into a vector</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ld3(sbyte* outputMemory, sbyte* input) => throw new NotImplementedException();

        /// <summary>loads a value and stores it into a vector</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ld4(sbyte* outputMemory, sbyte* input) => throw new NotImplementedException();

        /// <summary>stores the vector.</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 0 value(s) to the output memory.
        /// </remarks>
        public static void St1(sbyte* inputMemory, sbyte* output) => throw new NotImplementedException();

        /// <summary>stores the vector.</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 0 value(s) to the output memory.
        /// </remarks>
        public static void St2(sbyte* inputMemory, sbyte* output) => throw new NotImplementedException();

        /// <summary>stores the vector.</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 0 value(s) to the output memory.
        /// </remarks>
        public static void St3(sbyte* inputMemory, sbyte* output) => throw new NotImplementedException();

        /// <summary>stores the vector.</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 0 value(s) to the output memory.
        /// </remarks>
        public static void St4(sbyte* inputMemory, sbyte* output) => throw new NotImplementedException();

        /// <summary>load constant value</summary>
        /// <remarks>
        /// This pops 0 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Ldc(sbyte* outputMemory, ConstantValue value) => throw new NotImplementedException();

        /// <summary>and operation</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void And(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>exclusive or</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Xor(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>or</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Or(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>horizontal add</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void AddH(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>add</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Add(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>substract</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Sub(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>multiply</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Mul(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>divide</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Div(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>reciprocal</summary>
        /// <remarks>
        /// This pops 1 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Rec(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>square root</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Sqrt(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary> reciprocal square root</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void RecSqrt(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>maximum</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Max(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>minimum</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// </remarks>
        public static void Min(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>round to nearest integer</summary>
        /// <remarks>
        /// This pops 2 value(s) from the input memory and pushes 1 value(s) to the output memory.
        /// This requires 0 value(s) worth of space in temporary memory.
        /// </remarks>
        public static void Rnd(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>round to zero (truncate)</summary>
        public static void RndZ(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>round down (floor)</summary>
        public static void RndL(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>round up (ceiling)</summary>
        public static void RndH(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>compare equal</summary>
        public static void Eq(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>compare not equal</summary>
        public static void Neq(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>compare greater than</summary>
        public static void Gt(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>compare less than</summary>
        public static void Lt(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>greater than or equal</summary>
        public static void Gte(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>less than or equal</summary>
        public static void Lte(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>broadcasts a scalar to a vector</summary>
        public static void Stv(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>permutes a vector using a control SByte</summary>
        public static void Pmt(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>shuffles two vectors using a control SByte</summary>
        public static void Shf(sbyte* inputMemory, sbyte* outputMemory, sbyte control)
            => throw new NotImplementedException();

        /// <summary>computes the sine of a vector's elements</summary>
        public static void Sin(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the cosine of a vector's elements</summary>
        public static void Cos(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the tangent of a vector's elements</summary>
        public static void Tan(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the sine of a vector's elements (approx)</summary>
        public static void SinA(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the cosine of a vector's elements (approx)</summary>
        public static void CosA(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>computes the tangent of a vector's elements (approx)</summary>
        public static void TanA(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>atan</summary>
        public static void ATan(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>atan2</summary>
        public static void ATan2(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>dot product</summary>
        public static void Dot2(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>dot product</summary>
        public static void Dot3(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>dot product</summary>
        public static void Dot4(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>cross product</summary>
        public static void Cro2(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>cross product</summary>
        public static void Cro3(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();

        /// <summary>cross product</summary>
        public static void Cro4(sbyte* inputMemory, sbyte* outputMemory) => throw new NotImplementedException();
        
        public static void IsTrue(sbyte* inputMemory) => throw new NotImplementedException();
        public static void IsFalse(sbyte* inputMemory) => throw new NotImplementedException();

        /// <summary></summary>
        public static void Reorder(sbyte* memory, int num, uint* indices) => throw new NotImplementedException();
    }
}
