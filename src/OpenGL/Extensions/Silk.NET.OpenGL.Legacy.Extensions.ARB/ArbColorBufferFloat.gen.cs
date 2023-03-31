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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_color_buffer_float")]
    public unsafe partial class ArbColorBufferFloat : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_color_buffer_float";
        [NativeApi(EntryPoint = "glClampColorARB", Convention = CallingConvention.Winapi)]
        public partial void ClampColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB clamp);

        [NativeApi(EntryPoint = "glClampColorARB", Convention = CallingConvention.Winapi)]
        public partial void ClampColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClampColorModeARB clamp);

        [NativeApi(EntryPoint = "glClampColorARB", Convention = CallingConvention.Winapi)]
        public partial void ClampColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClampColorTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB clamp);

        [NativeApi(EntryPoint = "glClampColorARB", Convention = CallingConvention.Winapi)]
        public partial void ClampColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClampColorTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClampColorModeARB clamp);

        public ArbColorBufferFloat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

