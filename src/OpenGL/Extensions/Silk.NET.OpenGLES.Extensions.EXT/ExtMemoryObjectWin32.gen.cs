// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_memory_object_win32")]
    public unsafe partial class ExtMemoryObjectWin32 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_memory_object_win32";
        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT")]
        public unsafe partial void ImportMemoryWin32Handle([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] void* handle);

        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT")]
        public partial void ImportMemoryWin32Handle<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT")]
        public unsafe partial void ImportMemoryWin32Name([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] void* name);

        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT")]
        public partial void ImportMemoryWin32Name<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT")]
        public unsafe partial void ImportMemoryWin32Handle([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] void* handle);

        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT")]
        public partial void ImportMemoryWin32Handle<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT")]
        public unsafe partial void ImportMemoryWin32Name([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] void* name);

        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT")]
        public partial void ImportMemoryWin32Name<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged;

        public ExtMemoryObjectWin32(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

