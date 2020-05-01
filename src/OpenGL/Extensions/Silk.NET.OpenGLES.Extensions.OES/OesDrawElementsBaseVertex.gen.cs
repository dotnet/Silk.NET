// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_draw_elements_base_vertex")]
    public abstract unsafe partial class OesDrawElementsBaseVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_draw_elements_base_vertex";
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
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES")]
        public abstract unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

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
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES")]
        public abstract void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES")]
        public abstract unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

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
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES")]
        public abstract void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES")]
        public abstract unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

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
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES")]
        public abstract void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

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
        public abstract unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] OES mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

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
        public abstract unsafe void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] OES mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES")]
        public abstract unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

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
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES")]
        public abstract void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES")]
        public abstract unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

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
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES")]
        public abstract void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES")]
        public abstract unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

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
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES")]
        public abstract void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

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
        public abstract unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

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
        public abstract unsafe void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged;

        public OesDrawElementsBaseVertex(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

