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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_shader_framebuffer_fetch_noncoherent")]
    public unsafe partial class QComShaderFramebufferFetchNoncoherent : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_shader_framebuffer_fetch_noncoherent";
        [NativeApi(EntryPoint = "glFramebufferFetchBarrierQCOM")]
        public partial void FramebufferFetchBarrier();

        public QComShaderFramebufferFetchNoncoherent(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

