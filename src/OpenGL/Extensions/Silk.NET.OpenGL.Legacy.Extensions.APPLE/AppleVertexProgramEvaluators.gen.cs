// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_vertex_program_evaluators")]
    public abstract unsafe partial class AppleVertexProgramEvaluators : NativeExtension<GL>
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
        public abstract void DisableVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname);

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
        public abstract void EnableVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname);

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
        public abstract bool IsVertexAttribEnabled([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname);

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
        public abstract unsafe void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] double* points);

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
        public abstract void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] ref double points);

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
        public abstract unsafe void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] float* points);

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
        public abstract void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] ref float points);

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
        public abstract unsafe void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] double* points);

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
        public abstract void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ref double points);

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
        public abstract unsafe void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] float* points);

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
        public abstract void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ref float points);

        public AppleVertexProgramEvaluators(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

