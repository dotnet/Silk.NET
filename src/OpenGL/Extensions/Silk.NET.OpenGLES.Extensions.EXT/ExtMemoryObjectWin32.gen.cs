// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_memory_object_win32")]
    public unsafe partial class ExtMemoryObjectWin32 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_memory_object_win32";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImportMemoryWin32Handle([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] void* handle)
            => ImplImportMemoryWin32Handle(memory, size, handleType, handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportMemoryWin32Handle<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged
            => ImplImportMemoryWin32Handle<T0>(memory, size, handleType, handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImportMemoryWin32Name([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] void* name)
            => ImplImportMemoryWin32Name(memory, size, handleType, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportMemoryWin32Name<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged
            => ImplImportMemoryWin32Name<T0>(memory, size, handleType, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImportMemoryWin32Handle([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] void* handle)
            => ImplImportMemoryWin32Handle(memory, size, handleType, handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryWin32HandleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportMemoryWin32Handle<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged
            => ImplImportMemoryWin32Handle<T0>(memory, size, handleType, handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImportMemoryWin32Name([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] void* name)
            => ImplImportMemoryWin32Name(memory, size, handleType, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryWin32NameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportMemoryWin32Name<T0>([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged
            => ImplImportMemoryWin32Name<T0>(memory, size, handleType, name);

        public ExtMemoryObjectWin32(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

