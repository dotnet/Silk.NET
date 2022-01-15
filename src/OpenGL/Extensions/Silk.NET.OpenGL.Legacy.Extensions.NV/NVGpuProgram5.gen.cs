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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_gpu_program5")]
    public unsafe partial class NVGpuProgram5 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_gpu_program5";
        [NativeApi(EntryPoint = "glGetProgramSubroutineParameteruivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramSubroutineParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] uint* param);

        [NativeApi(EntryPoint = "glGetProgramSubroutineParameteruivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramSubroutineParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out uint param);

        [NativeApi(EntryPoint = "glProgramSubroutineParametersuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramSubroutineParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramSubroutineParametersuivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramSubroutineParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        public unsafe void ProgramSubroutineParameters([Flow(FlowDirection.In)] NV target, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramSubroutineParameters(target, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public NVGpuProgram5(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

