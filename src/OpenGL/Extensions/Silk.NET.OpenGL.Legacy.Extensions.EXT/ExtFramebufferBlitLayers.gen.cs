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
    [Extension("EXT_framebuffer_blit_layers")]
    public unsafe partial class ExtFramebufferBlitLayers : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_framebuffer_blit_layers";
        [NativeApi(EntryPoint = "glBlitFramebufferLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebufferLayer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int srcLayer, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] int dstLayer, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] EXT filter);

        [NativeApi(EntryPoint = "glBlitFramebufferLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebufferLayer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int srcLayer, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] int dstLayer, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glBlitFramebufferLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebufferLayer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int srcLayer, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] int dstLayer, [Flow(FlowDirection.In)] ClearBufferMask mask, [Flow(FlowDirection.In)] EXT filter);

        [NativeApi(EntryPoint = "glBlitFramebufferLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebufferLayer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int srcLayer, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] int dstLayer, [Flow(FlowDirection.In)] ClearBufferMask mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glBlitFramebufferLayersEXT", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebufferLayers([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] EXT filter);

        [NativeApi(EntryPoint = "glBlitFramebufferLayersEXT", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebufferLayers([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glBlitFramebufferLayersEXT", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebufferLayers([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] ClearBufferMask mask, [Flow(FlowDirection.In)] EXT filter);

        [NativeApi(EntryPoint = "glBlitFramebufferLayersEXT", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebufferLayers([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] ClearBufferMask mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        public ExtFramebufferBlitLayers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

