// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_framebuffer_no_attachments")]
    public unsafe partial class ArbFramebufferNoAttachments : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_framebuffer_no_attachments";
        [NativeApi(EntryPoint = "glFramebufferParameteri", Convention = CallingConvention.Winapi)]
        public partial void FramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        public ArbFramebufferNoAttachments(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

