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

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_polygon_offset_clamp")]
    public unsafe partial class ExtPolygonOffsetClamp : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_polygon_offset_clamp";
        [NativeApi(EntryPoint = "glPolygonOffsetClampEXT", Convention = CallingConvention.Winapi)]
        public partial void PolygonOffsetClamp([Flow(Silk.NET.Core.Native.FlowDirection.In)] float factor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float units, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float clamp);

        public ExtPolygonOffsetClamp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

