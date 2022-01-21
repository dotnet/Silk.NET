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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_memory_object_win32")]
    public unsafe partial class ExtMemoryObjectWin32 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_memory_object_win32";
        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImportMemoryWin32Handle([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] void* handle);

        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportMemoryWin32Handle<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] out T0 handle) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImportMemoryWin32Handle([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] void* handle);

        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportMemoryWin32Handle<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] out T0 handle) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImportMemoryWin32Name([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] void* name);

        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportMemoryWin32Name<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] in T0 name) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImportMemoryWin32Name([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] void* name);

        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportMemoryWin32Name<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] in T0 name) where T0 : unmanaged;

        public ExtMemoryObjectWin32(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

