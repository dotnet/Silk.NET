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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_geometry_shader")]
    public abstract unsafe partial class OesGeometryShader : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_geometry_shader";
        [NativeApi(EntryPoint = "glFramebufferTextureOES")]
        public abstract void FramebufferTexture([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTextureOES")]
        public abstract void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        public OesGeometryShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

