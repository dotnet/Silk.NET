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
    [Extension("SGIS_fog_function")]
    public unsafe partial class SgisFogFunction : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_fog_function";
        [NativeApi(EntryPoint = "glFogFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glFogFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void FogFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float points);

        [NativeApi(EntryPoint = "glGetFogFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFogFunc([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetFogFuncSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetFogFunc([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float points);

        public unsafe void FogFunc([Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // ImplicitCountSpanOverloader
            FogFunc((uint) points.Length/2, in points.GetPinnableReference());
        }

        public unsafe float GetFogFunc()
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFogFunc(&ret);
            return ret;
        }

        public SgisFogFunction(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

