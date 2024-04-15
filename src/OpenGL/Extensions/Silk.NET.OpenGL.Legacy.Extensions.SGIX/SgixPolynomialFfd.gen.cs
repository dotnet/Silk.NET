// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_polynomial_ffd")]
    public unsafe partial class SgixPolynomialFfd : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_polynomial_ffd";
        [NativeApi(EntryPoint = "glDeformSGIX", Convention = CallingConvention.Winapi)]
        public partial void Deform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glDeformSGIX", Convention = CallingConvention.Winapi)]
        public partial void Deform([Flow(Silk.NET.Core.Native.FlowDirection.In)] FfdMaskSGIX mask);

        [NativeApi(EntryPoint = "glDeformationMap3dSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeformationMap3([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* points);

        [NativeApi(EntryPoint = "glDeformationMap3dSGIX", Convention = CallingConvention.Winapi)]
        public partial void DeformationMap3([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double points);

        [NativeApi(EntryPoint = "glDeformationMap3dSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeformationMap3([Flow(Silk.NET.Core.Native.FlowDirection.In)] FfdTargetSGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* points);

        [NativeApi(EntryPoint = "glDeformationMap3dSGIX", Convention = CallingConvention.Winapi)]
        public partial void DeformationMap3([Flow(Silk.NET.Core.Native.FlowDirection.In)] FfdTargetSGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double points);

        [NativeApi(EntryPoint = "glDeformationMap3fSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeformationMap3([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDeformationMap3fSGIX", Convention = CallingConvention.Winapi)]
        public partial void DeformationMap3([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float points);

        [NativeApi(EntryPoint = "glDeformationMap3fSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeformationMap3([Flow(Silk.NET.Core.Native.FlowDirection.In)] FfdTargetSGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDeformationMap3fSGIX", Convention = CallingConvention.Winapi)]
        public partial void DeformationMap3([Flow(Silk.NET.Core.Native.FlowDirection.In)] FfdTargetSGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float points);

        [NativeApi(EntryPoint = "glLoadIdentityDeformationMapSGIX", Convention = CallingConvention.Winapi)]
        public partial void LoadIdentityDeformationMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glLoadIdentityDeformationMapSGIX", Convention = CallingConvention.Winapi)]
        public partial void LoadIdentityDeformationMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] FfdMaskSGIX mask);

        public SgixPolynomialFfd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

