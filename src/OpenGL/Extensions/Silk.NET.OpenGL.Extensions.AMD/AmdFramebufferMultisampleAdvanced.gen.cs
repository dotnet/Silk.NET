// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.AMD
{
    [Extension("AMD_framebuffer_multisample_advanced")]
    public abstract unsafe partial class AmdFramebufferMultisampleAdvanced : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_framebuffer_multisample_advanced";
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleAdvancedAMD")]
        public abstract void NamedRenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] AMD internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD")]
        public abstract void RenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] AMD internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleAdvancedAMD")]
        public abstract void NamedRenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD")]
        public abstract void RenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public AmdFramebufferMultisampleAdvanced(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

