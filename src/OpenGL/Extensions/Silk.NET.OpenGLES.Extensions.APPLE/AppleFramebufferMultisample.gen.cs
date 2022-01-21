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

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_framebuffer_multisample")]
    public unsafe partial class AppleFramebufferMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_framebuffer_multisample";
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAPPLE", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] APPLE internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAPPLE", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAPPLE", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] APPLE internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAPPLE", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glResolveMultisampleFramebufferAPPLE", Convention = CallingConvention.Winapi)]
        public partial void ResolveMultisampleFramebuffer();

        public AppleFramebufferMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

