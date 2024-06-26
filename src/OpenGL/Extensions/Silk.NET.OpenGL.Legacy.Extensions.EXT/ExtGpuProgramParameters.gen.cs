// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_gpu_program_parameters")]
    public unsafe partial class ExtGpuProgramParameters : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_gpu_program_parameters";
        [NativeApi(EntryPoint = "glProgramEnvParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glProgramEnvParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        public unsafe void ProgramEnvParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParameters4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramEnvParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParameters4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParameters4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParameters4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public ExtGpuProgramParameters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

