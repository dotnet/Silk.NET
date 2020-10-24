// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.MESA
{
    [Extension("MESA_framebuffer_flip_y")]
    public unsafe partial class MesaFramebufferFlipY : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_framebuffer_flip_y";
        [NativeApi(EntryPoint = "glFramebufferParameteriMESA")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] MESA pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteriMESA")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteriMESA")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] MESA pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteriMESA")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public MesaFramebufferFlipY(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

