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

namespace Silk.NET.OpenGL.Legacy.Extensions.GREMEDY
{
    [Extension("GREMEDY_frame_terminator")]
    public unsafe partial class GremedyFrameTerminator : NativeExtension<GL>
    {
        public const string ExtensionName = "GREMEDY_frame_terminator";
        [NativeApi(EntryPoint = "glFrameTerminatorGREMEDY", Convention = CallingConvention.Winapi)]
        public partial void FrameTerminator();

        public GremedyFrameTerminator(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

