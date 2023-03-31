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
    [Extension("EXT_primitive_bounding_box")]
    public unsafe partial class ExtPrimitiveBoundingBox : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_primitive_bounding_box";
        [NativeApi(EntryPoint = "glPrimitiveBoundingBoxEXT", Convention = CallingConvention.Winapi)]
        public partial void PrimitiveBoundingBox([Flow(Silk.NET.Core.Native.FlowDirection.In)] float minX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float minY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float minZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float minW, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float maxX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float maxY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float maxZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float maxW);

        public ExtPrimitiveBoundingBox(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

