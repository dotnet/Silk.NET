// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_get_program_binary")]
    public unsafe partial class OesGetProgramBinary : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_get_program_binary";
        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES")]
        public partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProgramBinaryOES")]
        public unsafe partial void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] int length);

        [NativeApi(EntryPoint = "glProgramBinaryOES")]
        public partial void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] int length) where T0 : unmanaged;

        public OesGetProgramBinary(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

