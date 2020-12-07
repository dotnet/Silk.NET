// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_framebuffer_no_attachments")]
    public unsafe partial class ArbFramebufferNoAttachments : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_framebuffer_no_attachments";
        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public ArbFramebufferNoAttachments(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

