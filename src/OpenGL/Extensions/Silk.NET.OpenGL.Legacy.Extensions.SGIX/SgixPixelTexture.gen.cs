// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_pixel_texture")]
    public abstract unsafe partial class SgixPixelTexture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenSGIX")]
        public abstract void PixelTexGen([Flow(FlowDirection.In)] SGIX mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenSGIX")]
        public abstract void PixelTexGen([Flow(FlowDirection.In)] PixelTexGenModeSGIX mode);

        public SgixPixelTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

