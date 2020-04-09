// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_get_program_binary")]
    public abstract unsafe partial class OesGetProgramBinary : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public abstract unsafe void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public abstract void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramBinaryOES")]
        public abstract unsafe void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] int length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramBinaryOES")]
        public abstract void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] int length) where T0 : unmanaged;

        public OesGetProgramBinary(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

