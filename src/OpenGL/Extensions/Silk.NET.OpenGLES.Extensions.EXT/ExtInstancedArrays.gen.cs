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
    [Extension("EXT_instanced_arrays")]
    public unsafe partial class ExtInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_instanced_arrays";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysInstancedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] int start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount)
            => ImplDrawArraysInstanced(mode, start, count, primcount);

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
        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount)
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
        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
            => ImplDrawElementsInstanced<T0>(mode, count, type, indices, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="divisor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribDivisorEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor)
            => ImplVertexAttribDivisor(index, divisor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysInstancedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount)
            => ImplDrawArraysInstanced(mode, start, count, primcount);

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
        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount)
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
        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
            => ImplDrawElementsInstanced<T0>(mode, count, type, indices, primcount);

        public ExtInstancedArrays(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

