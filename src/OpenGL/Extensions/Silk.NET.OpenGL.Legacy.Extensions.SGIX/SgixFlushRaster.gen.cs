// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

