// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.EGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_swap_buffers_with_damage")]
    public abstract unsafe partial class ExtSwapBuffersWithDamage : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_swap_buffers_with_damage";
        [NativeApi(EntryPoint = "eglSwapBuffersWithDamageEXT")]
        public abstract unsafe bool SwapBuffersWithDamage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int* rects, [Flow(FlowDirection.In)] int n_rects);

        [NativeApi(EntryPoint = "eglSwapBuffersWithDamageEXT")]
        public abstract bool SwapBuffersWithDamage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] Span<int> rects, [Flow(FlowDirection.In)] int n_rects);

        public unsafe bool SwapBuffersWithDamage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int* rects, [Flow(FlowDirection.In)] int n_rects)
        {
            // IntPtrOverloader
            return SwapBuffersWithDamage(new IntPtr(dpy), new IntPtr(surface), rects, n_rects);
        }

        public unsafe bool SwapBuffersWithDamage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] Span<int> rects, [Flow(FlowDirection.In)] int n_rects)
        {
            // IntPtrOverloader
            return SwapBuffersWithDamage(new IntPtr(dpy), new IntPtr(surface), rects, n_rects);
        }

        public ExtSwapBuffersWithDamage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

