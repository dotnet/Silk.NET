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

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_bindless_multi_draw_indirect_count")]
    public unsafe partial class NVBindlessMultiDrawIndirectCount : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_bindless_multi_draw_indirect_count";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawCount">
        /// To be added.
        /// </param>
        /// <param name="maxDrawCount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="vertexBufferCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirectBindlessCount([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount)
            => ImplMultiDrawArraysIndirectBindlessCount(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawCount">
        /// To be added.
        /// </param>
        /// <param name="maxDrawCount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="vertexBufferCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArraysIndirectBindlessCount<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
            => ImplMultiDrawArraysIndirectBindlessCount<T0>(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);

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
        /// <param name="drawCount">
        /// To be added.
        /// </param>
        /// <param name="maxDrawCount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="vertexBufferCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount)
            => ImplMultiDrawElementsIndirectBindlessCount(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);

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
        /// <param name="drawCount">
        /// To be added.
        /// </param>
        /// <param name="maxDrawCount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="vertexBufferCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
            => ImplMultiDrawElementsIndirectBindlessCount<T0>(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawCount">
        /// To be added.
        /// </param>
        /// <param name="maxDrawCount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="vertexBufferCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirectBindlessCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount)
            => ImplMultiDrawArraysIndirectBindlessCount(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawCount">
        /// To be added.
        /// </param>
        /// <param name="maxDrawCount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="vertexBufferCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArraysIndirectBindlessCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
            => ImplMultiDrawArraysIndirectBindlessCount<T0>(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);

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
        /// <param name="drawCount">
        /// To be added.
        /// </param>
        /// <param name="maxDrawCount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="vertexBufferCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount)
            => ImplMultiDrawElementsIndirectBindlessCount(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);

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
        /// <param name="drawCount">
        /// To be added.
        /// </param>
        /// <param name="maxDrawCount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="vertexBufferCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
            => ImplMultiDrawElementsIndirectBindlessCount<T0>(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);

        public NVBindlessMultiDrawIndirectCount(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

