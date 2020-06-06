// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_map_buffer_range")]
    public unsafe partial class ArbMapBufferRange : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_map_buffer_range";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushMappedBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length)
            => ImplFlushMappedBufferRange(target, offset, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access)
            => ImplMapBufferRange(target, offset, length, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length)
            => ImplFlushMappedBufferRange(target, offset, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access)
            => ImplMapBufferRange(target, offset, length, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        public ArbMapBufferRange(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

