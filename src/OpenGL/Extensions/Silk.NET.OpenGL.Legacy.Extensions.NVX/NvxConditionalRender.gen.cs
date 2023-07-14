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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_conditional_render")]
    public unsafe partial class NvxConditionalRender : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_conditional_render";
        [NativeApi(EntryPoint = "glBeginConditionalRenderNVX", Convention = CallingConvention.Winapi)]
        public partial void BeginConditionalRender([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEndConditionalRenderNVX", Convention = CallingConvention.Winapi)]
        public partial void EndConditionalRender();

        public NvxConditionalRender(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

