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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_detail_texture")]
    public unsafe partial class SgisDetailTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_detail_texture";
        [NativeApi(EntryPoint = "glDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void DetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void DetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void DetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void DetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetDetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        public unsafe void DetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // ImplicitCountSpanOverloader
            DetailTexFunc(target, (uint) points.Length, in points.GetPinnableReference());
        }

        public unsafe void DetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // ImplicitCountSpanOverloader
            DetailTexFunc(target, (uint) points.Length, in points.GetPinnableReference());
        }

        public unsafe float GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetDetailTexFunc(target, &ret);
            return ret;
        }

        public SgisDetailTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

