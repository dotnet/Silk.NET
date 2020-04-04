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

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_framebuffer_multisample")]
    public abstract unsafe partial class AppleFramebufferMultisample : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAPPLE")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] APPLE internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResolveMultisampleFramebufferAPPLE")]
        public abstract void ResolveMultisampleFramebuffer();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAPPLE")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public AppleFramebufferMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

