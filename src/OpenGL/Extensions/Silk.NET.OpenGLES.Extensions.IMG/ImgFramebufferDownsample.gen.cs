// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.IMG
{
    [Extension("IMG_framebuffer_downsample")]
    public abstract unsafe partial class ImgFramebufferDownsample : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG")]
        public abstract void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG")]
        public abstract void FramebufferTextureLayerDownsample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG")]
        public abstract void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG")]
        public abstract void FramebufferTextureLayerDownsample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        public ImgFramebufferDownsample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

