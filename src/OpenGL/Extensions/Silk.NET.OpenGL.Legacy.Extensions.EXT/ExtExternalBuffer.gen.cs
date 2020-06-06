// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_external_buffer")]
    public unsafe partial class ExtExternalBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_external_buffer";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="clientBuffer">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferStorageExternalEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferStorageExternal([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] IntPtr clientBuffer, [Flow(FlowDirection.In)] uint flags)
            => ImplBufferStorageExternal(target, offset, size, clientBuffer, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="clientBuffer">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferStorageExternalEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferStorageExternal([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] IntPtr clientBuffer, [Flow(FlowDirection.In)] uint flags)
            => ImplNamedBufferStorageExternal(buffer, offset, size, clientBuffer, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="clientBuffer">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferStorageExternal([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] int clientBuffer, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            BufferStorageExternal(target, new IntPtr(offset), new UIntPtr(size), new IntPtr(clientBuffer), flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="clientBuffer">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferStorageExternal([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] int clientBuffer, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorageExternal(buffer, new IntPtr(offset), new UIntPtr(size), new IntPtr(clientBuffer), flags);
        }

        public ExtExternalBuffer(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

