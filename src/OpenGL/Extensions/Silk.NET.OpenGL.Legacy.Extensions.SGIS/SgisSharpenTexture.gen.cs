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
    [Extension("SGIS_sharpen_texture")]
    public unsafe partial class SgisSharpenTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_sharpen_texture";
        [NativeApi(EntryPoint = "glGetSharpenTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetSharpenTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetSharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        [NativeApi(EntryPoint = "glGetSharpenTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetSharpenTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetSharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        [NativeApi(EntryPoint = "glSharpenTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void SharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glSharpenTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void SharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float points);

        [NativeApi(EntryPoint = "glSharpenTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void SharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glSharpenTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void SharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float points);

        public unsafe float GetSharpenTexFunc([Flow(FlowDirection.In)] SGIS target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetSharpenTexFunc(target, &ret);
            return ret;
        }

        public unsafe void SharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // ImplicitCountSpanOverloader
            SharpenTexFunc(target, (uint) points.Length, in points.GetPinnableReference());
        }

        public unsafe void SharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // ImplicitCountSpanOverloader
            SharpenTexFunc(target, (uint) points.Length, in points.GetPinnableReference());
        }

        public SgisSharpenTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

