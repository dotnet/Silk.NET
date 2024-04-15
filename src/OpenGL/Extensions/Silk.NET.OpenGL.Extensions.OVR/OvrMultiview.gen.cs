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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.OVR
{
    [Extension("OVR_multiview")]
    public unsafe partial class OvrMultiview : NativeExtension<GL>
    {
        public const string ExtensionName = "OVR_multiview";
        [NativeApi(EntryPoint = "glFramebufferTextureMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glFramebufferTextureMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OVR attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureMultiviewOVR", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureMultiview([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseViewIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numViews);

        public OvrMultiview(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

