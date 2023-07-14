// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OVR
{
    [Extension("OVR_multiview_multisampled_render_to_texture")]
    public unsafe partial class OvrMultiviewMultisampledRenderToTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "OVR_multiview_multisampled_render_to_texture";
        [NativeApi(EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureMultisampleMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureMultisampleMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureMultisampleMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureMultisampleMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        public OvrMultiviewMultisampledRenderToTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

