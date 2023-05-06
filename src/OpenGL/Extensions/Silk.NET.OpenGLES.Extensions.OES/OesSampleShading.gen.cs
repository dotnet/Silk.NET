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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_sample_shading")]
    public unsafe partial class OesSampleShading : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_sample_shading";
        [NativeApi(EntryPoint = "glMinSampleShadingOES", Convention = CallingConvention.Winapi)]
        public partial void MinSampleShading([Flow(Silk.NET.Core.Native.FlowDirection.In)] float value);

        public OesSampleShading(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

