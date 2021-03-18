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
        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV")]
        public unsafe partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV")]
        public partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV")]
        public unsafe partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV")]
        public partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV")]
        public unsafe partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV")]
        public partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV")]
        public unsafe partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV")]
        public partial void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV")]
        public unsafe partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV")]
        public partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV")]
        public unsafe partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV")]
        public partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV")]
        public unsafe partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV")]
        public partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV")]
        public unsafe partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV")]
        public partial void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4iNV")]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4iNV")]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV")]
        public unsafe partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV")]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV")]
        public unsafe partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV")]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uiNV")]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uiNV")]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV")]
        public unsafe partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV")]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV")]
        public unsafe partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV")]
        public partial void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV")]
        public unsafe partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV")]
        public partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV")]
        public unsafe partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV")]
        public partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV")]
        public unsafe partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV")]
        public partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV")]
        public unsafe partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV")]
        public partial void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4iNV")]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4iNV")]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV")]
        public unsafe partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV")]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV")]
        public unsafe partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV")]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uiNV")]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uiNV")]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV")]
        public unsafe partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV")]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV")]
        public unsafe partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV")]
        public partial void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV")]
        public unsafe partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV")]
        public partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV")]
        public unsafe partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV")]
        public partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV")]
        public unsafe partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV")]
        public partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV")]
        public unsafe partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV")]
        public partial void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        public NVGpuProgram4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

