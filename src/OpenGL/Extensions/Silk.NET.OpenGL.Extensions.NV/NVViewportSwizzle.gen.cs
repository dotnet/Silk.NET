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
    [Extension("NV_viewport_swizzle")]
    public unsafe partial class NVViewportSwizzle : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_viewport_swizzle";
        [NativeApi(EntryPoint = "glViewportSwizzleNV", Convention = CallingConvention.Winapi)]
        public partial void ViewportSwizzle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV swizzlex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV swizzley, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV swizzlez, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV swizzlew);

        public NVViewportSwizzle(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

