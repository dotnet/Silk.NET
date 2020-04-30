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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_semaphore_win32")]
    public abstract unsafe partial class ExtSemaphoreWin32 : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public abstract unsafe void ImportSemaphoreWin32Handle([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] void* handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public abstract void ImportSemaphoreWin32Handle<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public abstract unsafe void ImportSemaphoreWin32Name([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] void* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public abstract void ImportSemaphoreWin32Name<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public abstract unsafe void ImportSemaphoreWin32Handle([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] void* handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public abstract void ImportSemaphoreWin32Handle<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public abstract unsafe void ImportSemaphoreWin32Name([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] void* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public abstract void ImportSemaphoreWin32Name<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged;

        public ExtSemaphoreWin32(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

