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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_flush_buffer_range")]
    public unsafe partial class AppleFlushBufferRange : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_flush_buffer_range";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferParameteriAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferParameter([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] int param)
            => ImplBufferParameter(target, pname, param);

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
        [NativeApi(EntryPoint = "glFlushMappedBufferRangeAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushMappedBufferRange([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplFlushMappedBufferRange(target, offset, size);

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
        [NativeApi(EntryPoint = "glFlushMappedBufferRangeAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplFlushMappedBufferRange(target, offset, size);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(size));
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
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(size));
        }

        public AppleFlushBufferRange(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

