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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_draw_instanced")]
    public unsafe partial class NVDrawInstanced : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_instanced";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysInstanced([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount)
            => ImplDrawArraysInstanced(mode, first, count, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount)
            => ImplDrawElementsInstanced(mode, count, type, indices, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
            => ImplDrawElementsInstanced<T0>(mode, count, type, indices, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount)
            => ImplDrawArraysInstanced(mode, first, count, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount)
            => ImplDrawElementsInstanced(mode, count, type, indices, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
            => ImplDrawElementsInstanced<T0>(mode, count, type, indices, primcount);

        public NVDrawInstanced(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

