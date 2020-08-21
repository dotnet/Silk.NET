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

namespace Silk.NET.OpenGLES.Extensions.OVR
{
    [Extension("OVR_multiview_multisampled_render_to_texture")]
    public unsafe partial class OvrMultiviewMultisampledRenderToTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "OVR_multiview_multisampled_render_to_texture";
        [NativeApi(EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR")]
        public partial void FramebufferTextureMultisampleMultiview([Flow(FlowDirection.In)] OVR target, [Flow(FlowDirection.In)] OVR attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int baseViewIndex, [Flow(FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR")]
        public partial void FramebufferTextureMultisampleMultiview([Flow(FlowDirection.In)] OVR target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int baseViewIndex, [Flow(FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR")]
        public partial void FramebufferTextureMultisampleMultiview([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] OVR attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int baseViewIndex, [Flow(FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR")]
        public partial void FramebufferTextureMultisampleMultiview([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int baseViewIndex, [Flow(FlowDirection.In)] uint numViews);

        public OvrMultiviewMultisampledRenderToTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

