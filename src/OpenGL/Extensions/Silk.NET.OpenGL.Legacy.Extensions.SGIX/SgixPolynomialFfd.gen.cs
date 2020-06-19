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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_polynomial_ffd")]
    public abstract unsafe partial class SgixPolynomialFfd : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_polynomial_ffd";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeformSGIX")]
        public abstract void Deform([Flow(FlowDirection.In)] uint mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="w1">
        /// To be added.
        /// </param>
        /// <param name="w2">
        /// To be added.
        /// </param>
        /// <param name="wstride">
        /// To be added.
        /// </param>
        /// <param name="worder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, ustride, uorder, vstride, vorder, wstride, and worder.
        /// </param>
        [NativeApi(EntryPoint = "glDeformationMap3dSGIX")]
        public abstract unsafe void DeformationMap3([Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] double* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="w1">
        /// To be added.
        /// </param>
        /// <param name="w2">
        /// To be added.
        /// </param>
        /// <param name="wstride">
        /// To be added.
        /// </param>
        /// <param name="worder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, ustride, uorder, vstride, vorder, wstride, and worder.
        /// </param>
        [NativeApi(EntryPoint = "glDeformationMap3dSGIX")]
        public abstract void DeformationMap3([Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] ref double points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="w1">
        /// To be added.
        /// </param>
        /// <param name="w2">
        /// To be added.
        /// </param>
        /// <param name="wstride">
        /// To be added.
        /// </param>
        /// <param name="worder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, ustride, uorder, vstride, vorder, wstride, and worder.
        /// </param>
        [NativeApi(EntryPoint = "glDeformationMap3fSGIX")]
        public abstract unsafe void DeformationMap3([Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] float* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="w1">
        /// To be added.
        /// </param>
        /// <param name="w2">
        /// To be added.
        /// </param>
        /// <param name="wstride">
        /// To be added.
        /// </param>
        /// <param name="worder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, ustride, uorder, vstride, vorder, wstride, and worder.
        /// </param>
        [NativeApi(EntryPoint = "glDeformationMap3fSGIX")]
        public abstract void DeformationMap3([Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] ref float points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLoadIdentityDeformationMapSGIX")]
        public abstract void LoadIdentityDeformationMap([Flow(FlowDirection.In)] uint mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="w1">
        /// To be added.
        /// </param>
        /// <param name="w2">
        /// To be added.
        /// </param>
        /// <param name="wstride">
        /// To be added.
        /// </param>
        /// <param name="worder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, ustride, uorder, vstride, vorder, wstride, and worder.
        /// </param>
        [NativeApi(EntryPoint = "glDeformationMap3dSGIX")]
        public abstract unsafe void DeformationMap3([Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] double* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="w1">
        /// To be added.
        /// </param>
        /// <param name="w2">
        /// To be added.
        /// </param>
        /// <param name="wstride">
        /// To be added.
        /// </param>
        /// <param name="worder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, ustride, uorder, vstride, vorder, wstride, and worder.
        /// </param>
        [NativeApi(EntryPoint = "glDeformationMap3dSGIX")]
        public abstract void DeformationMap3([Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] ref double points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="w1">
        /// To be added.
        /// </param>
        /// <param name="w2">
        /// To be added.
        /// </param>
        /// <param name="wstride">
        /// To be added.
        /// </param>
        /// <param name="worder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, ustride, uorder, vstride, vorder, wstride, and worder.
        /// </param>
        [NativeApi(EntryPoint = "glDeformationMap3fSGIX")]
        public abstract unsafe void DeformationMap3([Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] float* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="w1">
        /// To be added.
        /// </param>
        /// <param name="w2">
        /// To be added.
        /// </param>
        /// <param name="wstride">
        /// To be added.
        /// </param>
        /// <param name="worder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, ustride, uorder, vstride, vorder, wstride, and worder.
        /// </param>
        [NativeApi(EntryPoint = "glDeformationMap3fSGIX")]
        public abstract void DeformationMap3([Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] ref float points);

        public SgixPolynomialFfd(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

