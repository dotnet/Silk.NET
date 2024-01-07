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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_blend_func_extended")]
    public unsafe partial class ExtBlendFuncExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_func_extended";
        [NativeApi(EntryPoint = "glBindFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public partial void BindFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public partial void BindFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindFragDataLocationIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void BindFragDataLocationIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void BindFragDataLocationIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetFragDataIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT", Convention = CallingConvention.Winapi)]
        public partial int GetFragDataIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT", Convention = CallingConvention.Winapi)]
        public partial int GetFragDataIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocationIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocationIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocationIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT", Convention = CallingConvention.Winapi)]
        public partial int GetProgramResourceLocationIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        public ExtBlendFuncExtended(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

