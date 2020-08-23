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
    [Extension("EXT_semaphore_win32")]
    public unsafe partial class ExtSemaphoreWin32 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore_win32";
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public unsafe partial void ImportSemaphoreWin32Handle([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] void* handle);

        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public partial void ImportSemaphoreWin32Handle<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] out T0 handle) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public unsafe partial void ImportSemaphoreWin32Handle([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] void* handle);

        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public partial void ImportSemaphoreWin32Handle<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] out T0 handle) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public unsafe partial void ImportSemaphoreWin32Name([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] void* name);

        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public partial void ImportSemaphoreWin32Name<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] in T0 name) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public unsafe partial void ImportSemaphoreWin32Name([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] void* name);

        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public partial void ImportSemaphoreWin32Name<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] in T0 name) where T0 : unmanaged;

        public ExtSemaphoreWin32(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

