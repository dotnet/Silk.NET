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
    [Extension("EXT_draw_elements_base_vertex")]
    public unsafe partial class ExtDrawElementsBaseVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_elements_base_vertex";
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
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawElementsBaseVertex(mode, count, type, indices, basevertex);

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
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawElementsBaseVertex<T0>(mode, count, type, indices, basevertex);

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
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);

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
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawElementsInstancedBaseVertex<T0>(mode, count, type, indices, instancecount, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
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
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
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
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawRangeElementsBaseVertex<T0>(mode, start, end, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
            => ImplMultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged
            => ImplMultiDrawElementsBaseVertex<T0>(mode, count, type, indices, primcount, basevertex);

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
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawElementsBaseVertex(mode, count, type, indices, basevertex);

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
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawElementsBaseVertex<T0>(mode, count, type, indices, basevertex);

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
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);

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
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawElementsInstancedBaseVertex<T0>(mode, count, type, indices, instancecount, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
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
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
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
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawRangeElementsBaseVertex<T0>(mode, start, end, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
            => ImplMultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// This parameter's element count is computed from drawcount.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged
            => ImplMultiDrawElementsBaseVertex<T0>(mode, count, type, indices, primcount, basevertex);

        public ExtDrawElementsBaseVertex(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

