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

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.ANGLE
{
    [Extension("ANGLE_framebuffer_multisample")]
    public abstract unsafe partial class AngleFramebufferMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "ANGLE_framebuffer_multisample";
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleANGLE")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] ANGLE target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ANGLE internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleANGLE")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public AngleFramebufferMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

