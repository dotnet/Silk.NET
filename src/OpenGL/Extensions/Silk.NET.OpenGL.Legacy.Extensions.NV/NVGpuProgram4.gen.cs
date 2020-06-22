// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_gpu_program4")]
    public abstract unsafe partial class NVGpuProgram4 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_gpu_program4";
        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV")]
        public abstract unsafe void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV")]
        public abstract void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV")]
        public abstract unsafe void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV")]
        public abstract void GetProgramEnvParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV")]
        public abstract unsafe void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV")]
        public abstract void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV")]
        public abstract unsafe void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV")]
        public abstract void GetProgramLocalParameterI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4iNV")]
        public abstract void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV")]
        public abstract unsafe void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV")]
        public abstract void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uiNV")]
        public abstract void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV")]
        public abstract unsafe void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV")]
        public abstract void ProgramEnvParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV")]
        public abstract unsafe void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV")]
        public abstract void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV")]
        public abstract unsafe void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV")]
        public abstract void ProgramEnvParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4iNV")]
        public abstract void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV")]
        public abstract unsafe void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV")]
        public abstract void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uiNV")]
        public abstract void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV")]
        public abstract unsafe void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV")]
        public abstract void ProgramLocalParameterI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV")]
        public abstract unsafe void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV")]
        public abstract void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV")]
        public abstract unsafe void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV")]
        public abstract void ProgramLocalParametersI4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV")]
        public abstract unsafe void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIivNV")]
        public abstract void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV")]
        public abstract unsafe void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterIuivNV")]
        public abstract void GetProgramEnvParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV")]
        public abstract unsafe void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIivNV")]
        public abstract void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV")]
        public abstract unsafe void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterIuivNV")]
        public abstract void GetProgramLocalParameterI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4iNV")]
        public abstract void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV")]
        public abstract unsafe void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4ivNV")]
        public abstract void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uiNV")]
        public abstract void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV")]
        public abstract unsafe void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameterI4uivNV")]
        public abstract void ProgramEnvParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV")]
        public abstract unsafe void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4ivNV")]
        public abstract void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV")]
        public abstract unsafe void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramEnvParametersI4uivNV")]
        public abstract void ProgramEnvParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4iNV")]
        public abstract void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV")]
        public abstract unsafe void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4ivNV")]
        public abstract void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uiNV")]
        public abstract void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV")]
        public abstract unsafe void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameterI4uivNV")]
        public abstract void ProgramLocalParameterI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV")]
        public abstract unsafe void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4ivNV")]
        public abstract void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV")]
        public abstract unsafe void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramLocalParametersI4uivNV")]
        public abstract void ProgramLocalParametersI4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        public NVGpuProgram4(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

