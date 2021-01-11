// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_image_base")]
    public unsafe partial class KhrImageBase : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_image_base";
        [NativeApi(EntryPoint = "eglCreateImageKHR")]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx, [Flow(FlowDirection.In)] KHR target, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateImageKHR")]
        public partial nint CreateImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx, [Flow(FlowDirection.In)] KHR target, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglDestroyImageKHR")]
        public partial int DestroyImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image);

        public KhrImageBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

