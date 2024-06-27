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
        public unsafe partial void GetProgramSubroutineParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* param);

        [NativeApi(EntryPoint = "glGetProgramSubroutineParameteruivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramSubroutineParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint param);

        [NativeApi(EntryPoint = "glProgramSubroutineParametersuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramSubroutineParameters([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramSubroutineParametersuivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramSubroutineParameters([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        public unsafe void ProgramSubroutineParameters([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramSubroutineParameters(target, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe uint GetProgramSubroutineParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetProgramSubroutineParameter(target, index, out uint silkRet);
            return silkRet;
        }

        public NVGpuProgram5(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

