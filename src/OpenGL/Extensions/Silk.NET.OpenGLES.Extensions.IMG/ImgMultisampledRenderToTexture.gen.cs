// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.IMG
{
    [Extension("IMG_multisampled_render_to_texture")]
    public unsafe partial class ImgMultisampledRenderToTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "IMG_multisampled_render_to_texture";
        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleIMG")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] IMG internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleIMG")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public ImgMultisampledRenderToTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

