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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_clip_control")]
    public unsafe partial class ExtClipControl : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_clip_control";
        [NativeApi(EntryPoint = "glClipControlEXT", Convention = CallingConvention.Winapi)]
        public partial void ClipControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT depth);

        public ExtClipControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

