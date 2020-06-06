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
    [Extension("APPLE_vertex_program_evaluators")]
    public unsafe partial class AppleVertexProgramEvaluators : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_vertex_program_evaluators";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableVertexAttribAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname)
            => ImplDisableVertexAttrib(index, pname);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableVertexAttribAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname)
            => ImplEnableVertexAttrib(index, pname);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsVertexAttribEnabledAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsVertexAttribEnabled([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname)
            => ImplIsVertexAttribEnabled(index, pname);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="order">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from size, stride, and order.
        /// </param>
        [NativeApi(EntryPoint = "glMapVertexAttrib1dAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] double* points)
            => ImplMapVertexAttrib1(index, size, u1, u2, stride, order, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="order">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from size, stride, and order.
        /// </param>
        [NativeApi(EntryPoint = "glMapVertexAttrib1dAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] ref double points)
            => ImplMapVertexAttrib1(index, size, u1, u2, stride, order, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="order">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from size, stride, and order.
        /// </param>
        [NativeApi(EntryPoint = "glMapVertexAttrib1fAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] float* points)
            => ImplMapVertexAttrib1(index, size, u1, u2, stride, order, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="order">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from size, stride, and order.
        /// </param>
        [NativeApi(EntryPoint = "glMapVertexAttrib1fAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] ref float points)
            => ImplMapVertexAttrib1(index, size, u1, u2, stride, order, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from size, ustride, uorder, vstride, and vorder.
        /// </param>
        [NativeApi(EntryPoint = "glMapVertexAttrib2dAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] double* points)
            => ImplMapVertexAttrib2(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from size, ustride, uorder, vstride, and vorder.
        /// </param>
        [NativeApi(EntryPoint = "glMapVertexAttrib2dAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ref double points)
            => ImplMapVertexAttrib2(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from size, ustride, uorder, vstride, and vorder.
        /// </param>
        [NativeApi(EntryPoint = "glMapVertexAttrib2fAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] float* points)
            => ImplMapVertexAttrib2(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from size, ustride, uorder, vstride, and vorder.
        /// </param>
        [NativeApi(EntryPoint = "glMapVertexAttrib2fAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ref float points)
            => ImplMapVertexAttrib2(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);

        public AppleVertexProgramEvaluators(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

