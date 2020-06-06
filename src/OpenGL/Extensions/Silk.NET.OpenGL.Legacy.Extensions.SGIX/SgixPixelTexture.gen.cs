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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_pixel_texture")]
    public unsafe partial class SgixPixelTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_pixel_texture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelTexGenSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGen([Flow(FlowDirection.In)] SGIX mode)
            => ImplPixelTexGen(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelTexGenSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGen([Flow(FlowDirection.In)] PixelTexGenModeSGIX mode)
            => ImplPixelTexGen(mode);

        public SgixPixelTexture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

