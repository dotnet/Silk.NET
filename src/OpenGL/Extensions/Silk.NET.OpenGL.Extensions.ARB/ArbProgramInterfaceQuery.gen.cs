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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_program_interface_query")]
    public unsafe partial class ArbProgramInterfaceQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_program_interface_query";
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ARB props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ARB props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ARB props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ARB props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ARB props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ARB props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ARB props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ARB props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), count, length, @params);
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), count, out length, @params);
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), count, length, @params);
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), count, out length, @params);
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), count, length, @params);
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), count, out length, @params);
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), count, length, @params);
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), count, out length, @params);
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, (uint) props.Length, in props.GetPinnableReference(), (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetProgramResourceName(program, programInterface, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetProgramResourceName(program, programInterface, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetProgramResourceName(program, programInterface, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetProgramResourceName(program, programInterface, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetProgramResourceName(program, programInterface, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetProgramResourceName(program, programInterface, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetProgramResourceName(program, programInterface, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetProgramResourceName(program, programInterface, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public ArbProgramInterfaceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

