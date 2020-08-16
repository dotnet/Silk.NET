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
    [Extension("SGIX_flush_raster")]
    public unsafe partial class SgixFlushRaster : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_flush_raster";
        [NativeApi(EntryPoint = "glFlushRasterSGIX")]
        public partial void FlushRaster();

        public SgixFlushRaster(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

