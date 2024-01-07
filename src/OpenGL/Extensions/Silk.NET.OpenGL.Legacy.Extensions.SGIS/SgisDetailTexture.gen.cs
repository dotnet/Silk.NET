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
        public unsafe partial void DetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void DetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void DetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void DetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetDetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetDetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float points);

        public unsafe void DetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // ImplicitCountSpanOverloader
            DetailTexFunc(target, (uint) points.Length/2, in points.GetPinnableReference());
        }

        public unsafe void DetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // ImplicitCountSpanOverloader
            DetailTexFunc(target, (uint) points.Length/2, in points.GetPinnableReference());
        }

        public unsafe float GetDetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetDetailTexFunc(target, &ret);
            return ret;
        }

        public unsafe float GetDetailTexFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target)
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

