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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.MESA
{
    [Extension("MESA_framebuffer_flip_y")]
    public unsafe partial class MesaFramebufferFlipY : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_framebuffer_flip_y";
        [NativeApi(EntryPoint = "glFramebufferParameteriMESA", Convention = CallingConvention.Winapi)]
        public partial void FramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteriMESA", Convention = CallingConvention.Winapi)]
        public partial void FramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteriMESA", Convention = CallingConvention.Winapi)]
        public partial void FramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteriMESA", Convention = CallingConvention.Winapi)]
        public partial void FramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivMESA", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        public unsafe int GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public MesaFramebufferFlipY(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

