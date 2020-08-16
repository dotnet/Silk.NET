// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_program_interface_query")]
    public unsafe partial class ArbProgramInterfaceQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_program_interface_query";
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public unsafe partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public unsafe partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        public ArbProgramInterfaceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

