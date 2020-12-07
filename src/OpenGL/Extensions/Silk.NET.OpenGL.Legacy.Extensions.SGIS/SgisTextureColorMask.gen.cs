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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_texture_color_mask")]
    public unsafe partial class SgisTextureColorMask : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture_color_mask";
        [NativeApi(EntryPoint = "glTextureColorMaskSGIS")]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        public SgisTextureColorMask(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

