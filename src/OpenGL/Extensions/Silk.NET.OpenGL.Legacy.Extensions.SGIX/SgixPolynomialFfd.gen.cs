// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_polynomial_ffd")]
    public unsafe partial class SgixPolynomialFfd : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_polynomial_ffd";
        [NativeApi(EntryPoint = "glDeformSGIX")]
        public partial void Deform([Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glDeformationMap3dSGIX")]
        public unsafe partial void DeformationMap3([Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] double* points);

        [NativeApi(EntryPoint = "glDeformationMap3dSGIX")]
        public partial void DeformationMap3([Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] in double points);

        [NativeApi(EntryPoint = "glDeformationMap3dSGIX")]
        public unsafe partial void DeformationMap3([Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] double* points);

        [NativeApi(EntryPoint = "glDeformationMap3dSGIX")]
        public partial void DeformationMap3([Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] in double points);

        [NativeApi(EntryPoint = "glDeformationMap3fSGIX")]
        public unsafe partial void DeformationMap3([Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDeformationMap3fSGIX")]
        public partial void DeformationMap3([Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] in float points);

        [NativeApi(EntryPoint = "glDeformationMap3fSGIX")]
        public unsafe partial void DeformationMap3([Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDeformationMap3fSGIX")]
        public partial void DeformationMap3([Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] in float points);

        [NativeApi(EntryPoint = "glLoadIdentityDeformationMapSGIX")]
        public partial void LoadIdentityDeformationMap([Flow(FlowDirection.In)] uint mask);

        public SgixPolynomialFfd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

