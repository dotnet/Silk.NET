// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_texture_color_mask")]
    public unsafe partial class SgisTextureColorMask : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture_color_mask";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureColorMaskSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha)
            => ImplTextureColorMask(red, green, blue, alpha);

        public SgisTextureColorMask(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

