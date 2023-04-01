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

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_depth_buffer_float")]
    public unsafe partial class NVDepthBufferFloat : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_depth_buffer_float";
        [NativeApi(EntryPoint = "glClearDepthdNV", Convention = CallingConvention.Winapi)]
        public partial void ClearDepth([Flow(Silk.NET.Core.Native.FlowDirection.In)] double depth);

        [NativeApi(EntryPoint = "glDepthBoundsdNV", Convention = CallingConvention.Winapi)]
        public partial void DepthBounds([Flow(Silk.NET.Core.Native.FlowDirection.In)] double zmin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zmax);

        [NativeApi(EntryPoint = "glDepthRangedNV", Convention = CallingConvention.Winapi)]
        public partial void DepthRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] double zNear, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zFar);

        public NVDepthBufferFloat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

