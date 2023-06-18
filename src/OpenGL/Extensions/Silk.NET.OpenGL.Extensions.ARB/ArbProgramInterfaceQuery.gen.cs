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
        public unsafe partial void GetProgramInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetProgramResourceIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        public ArbProgramInterfaceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

