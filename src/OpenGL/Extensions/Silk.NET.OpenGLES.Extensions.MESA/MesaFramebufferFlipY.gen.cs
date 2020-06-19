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

namespace Silk.NET.OpenGLES.Extensions.MESA
{
    [Extension("MESA_framebuffer_flip_y")]
    public abstract unsafe partial class MesaFramebufferFlipY : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_framebuffer_flip_y";
        [NativeApi(EntryPoint = "glFramebufferParameteriMESA")]
        public abstract void FramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] MESA pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glFramebufferParameteriMESA")]
        public abstract void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public MesaFramebufferFlipY(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

