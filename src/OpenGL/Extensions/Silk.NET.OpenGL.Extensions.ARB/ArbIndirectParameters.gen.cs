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
    [Extension("ARB_indirect_parameters")]
    public unsafe partial class ArbIndirectParameters : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_indirect_parameters";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawArraysIndirectCount<T0>(mode, indirect, drawcount, maxdrawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawElementsIndirectCount<T0>(mode, type, indirect, drawcount, maxdrawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawArraysIndirectCount<T0>(mode, indirect, drawcount, maxdrawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawElementsIndirectCount<T0>(mode, type, indirect, drawcount, maxdrawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public ArbIndirectParameters(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

