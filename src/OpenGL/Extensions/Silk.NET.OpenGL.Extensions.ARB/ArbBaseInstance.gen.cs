// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_base_instance")]
    public abstract unsafe partial class ArbBaseInstance : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_base_instance";
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
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public abstract void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

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
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

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
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

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
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

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
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

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
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public abstract void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

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
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

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
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

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
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

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
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        /// <param name="baseinstance">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        public ArbBaseInstance(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

