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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_sample_shading")]
    public unsafe partial class ArbSampleShading : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sample_shading";
        [NativeApi(EntryPoint = "glMinSampleShadingARB", Convention = CallingConvention.Winapi)]
        public partial void MinSampleShading([Flow(Silk.NET.Core.Native.FlowDirection.In)] float value);

        public ArbSampleShading(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

