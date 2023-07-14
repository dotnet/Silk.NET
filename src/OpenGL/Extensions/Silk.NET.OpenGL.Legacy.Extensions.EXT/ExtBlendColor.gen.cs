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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_blend_color")]
    public unsafe partial class ExtBlendColor : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_color";
        [NativeApi(EntryPoint = "glBlendColorEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] float red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float alpha);

        public ExtBlendColor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

