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

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_framebuffer_multisample")]
    public unsafe partial class AppleFramebufferMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_framebuffer_multisample";
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAPPLE")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] APPLE internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glResolveMultisampleFramebufferAPPLE")]
        public partial void ResolveMultisampleFramebuffer();

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAPPLE")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public AppleFramebufferMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

