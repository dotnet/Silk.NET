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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_conservative_raster")]
    public unsafe partial class NVConservativeRaster : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conservative_raster";
        [NativeApi(EntryPoint = "glSubpixelPrecisionBiasNV", Convention = CallingConvention.Winapi)]
        public partial void SubpixelPrecisionBias([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xbits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ybits);

        public NVConservativeRaster(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

