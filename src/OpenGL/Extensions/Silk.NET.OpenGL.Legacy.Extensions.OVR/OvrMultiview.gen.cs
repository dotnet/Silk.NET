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

namespace Silk.NET.OpenGL.Legacy.Extensions.OVR
{
    [Extension("OVR_multiview")]
    public unsafe partial class OvrMultiview : NativeExtension<GL>
    {
        public const string ExtensionName = "OVR_multiview";
        [NativeApi(EntryPoint = "glFramebufferTextureMultiviewOVR")]
        public partial void FramebufferTextureMultiview([Flow(FlowDirection.In)] OVR target, [Flow(FlowDirection.In)] OVR attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int baseViewIndex, [Flow(FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultiviewOVR")]
        public partial void FramebufferTextureMultiview([Flow(FlowDirection.In)] OVR target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int baseViewIndex, [Flow(FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultiviewOVR")]
        public partial void FramebufferTextureMultiview([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] OVR attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int baseViewIndex, [Flow(FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultiviewOVR")]
        public partial void FramebufferTextureMultiview([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int baseViewIndex, [Flow(FlowDirection.In)] uint numViews);

        public OvrMultiview(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

