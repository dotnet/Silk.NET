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
    [Extension("NV_gpu_program4")]
    public unsafe partial class NVGpuProgram4 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_gpu_program4";
        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4iNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4iNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uiNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uiNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4iNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4iNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uiNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uiNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        public unsafe void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParametersI4(target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParametersI4(target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParametersI4(target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParametersI4(target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParametersI4(target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParametersI4(target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParametersI4(target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParametersI4(target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public NVGpuProgram4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

