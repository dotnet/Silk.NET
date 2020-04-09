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

namespace Silk.NET.OpenGLES.Extensions.INTEL
{
    [Extension("INTEL_framebuffer_CMAA")]
    public abstract unsafe partial class IntelFramebufferCmaa : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glApplyFramebufferAttachmentCMAAINTEL")]
        public abstract void ApplyFramebufferAttachmentCmaa();

        public IntelFramebufferCmaa(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

