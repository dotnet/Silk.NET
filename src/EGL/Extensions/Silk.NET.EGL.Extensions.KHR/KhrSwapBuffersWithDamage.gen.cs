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
    [Extension("KHR_swap_buffers_with_damage")]
    public unsafe partial class KhrSwapBuffersWithDamage : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_swap_buffers_with_damage";
        [NativeApi(EntryPoint = "eglSwapBuffersWithDamageKHR")]
        public unsafe partial bool SwapBuffersWithDamage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int* rects, [Flow(FlowDirection.In)] int n_rects);

        [NativeApi(EntryPoint = "eglSwapBuffersWithDamageKHR")]
        public partial bool SwapBuffersWithDamage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] in int rects, [Flow(FlowDirection.In)] int n_rects);

        public KhrSwapBuffersWithDamage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

