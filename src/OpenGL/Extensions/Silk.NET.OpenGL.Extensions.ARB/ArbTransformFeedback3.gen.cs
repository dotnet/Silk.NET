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
    [Extension("ARB_transform_feedback3")]
    public unsafe partial class ArbTransformFeedback3 : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transform_feedback3";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id)
            => ImplBeginQueryIndexed(target, index, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawTransformFeedbackStream([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream)
            => ImplDrawTransformFeedbackStream(mode, id, stream);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index)
            => ImplEndQueryIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetQueryIndexed(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetQueryIndexed(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id)
            => ImplBeginQueryIndexed(target, index, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawTransformFeedbackStream([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream)
            => ImplDrawTransformFeedbackStream(mode, id, stream);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index)
            => ImplEndQueryIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetQueryIndexed(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetQueryIndexed(target, index, pname, @params);

        public ArbTransformFeedback3(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

