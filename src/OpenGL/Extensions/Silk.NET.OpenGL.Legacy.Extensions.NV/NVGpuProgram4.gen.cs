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
        public unsafe partial void GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4iNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4iNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uiNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uiNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4iNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4iNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uiNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uiNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        public unsafe void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParametersI4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParametersI4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParametersI4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramEnvParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramEnvParametersI4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParametersI4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParametersI4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParametersI4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe void ProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramLocalParametersI4(target, index, (uint) @params.Length/4, in @params.GetPinnableReference());
        }

        public unsafe int GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetProgramEnvParameterI(target, index, out int silkRet);
            return silkRet;
        }

        public unsafe int GetProgramEnvParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetProgramEnvParameterI(target, index, out int silkRet);
            return silkRet;
        }

        public unsafe int GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetProgramLocalParameterI(target, index, out int silkRet);
            return silkRet;
        }

        public unsafe int GetProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetProgramLocalParameterI(target, index, out int silkRet);
            return silkRet;
        }

        public NVGpuProgram4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

