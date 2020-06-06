// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_get_program_binary")]
    public unsafe partial class OesGetProgramBinary : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_get_program_binary";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="binaryFormat">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary)
            => ImplGetProgramBinary(program, bufSize, length, binaryFormat, binary);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="binaryFormat">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
            => ImplGetProgramBinary<T0>(program, bufSize, length, binaryFormat, binary);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="binaryFormat">
        /// To be added.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBinaryOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] int length)
            => ImplProgramBinary(program, binaryFormat, binary, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="binaryFormat">
        /// To be added.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBinaryOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] int length) where T0 : unmanaged
            => ImplProgramBinary<T0>(program, binaryFormat, binary, length);

        public OesGetProgramBinary(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

