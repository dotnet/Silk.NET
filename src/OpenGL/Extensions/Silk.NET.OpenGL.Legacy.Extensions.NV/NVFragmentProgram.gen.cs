// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_fragment_program")]
    public unsafe partial class NVFragmentProgram : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fragment_program";
        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        public partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        public partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        public partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        public partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV")]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV")]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV")]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV")]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        public NVFragmentProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

