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

namespace Silk.NET.EGL.Extensions.NOK
{
    [Extension("NOK_swap_region2")]
    public abstract unsafe partial class NokSwapRegion2 : NativeExtension<EGL>
    {
        public const string ExtensionName = "NOK_swap_region2";
        [NativeApi(EntryPoint = "eglSwapBuffersRegion2NOK")]
        public abstract unsafe bool SwapBuffersRegion2Nok([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int numRects, [Flow(FlowDirection.In)] int* rects);

        [NativeApi(EntryPoint = "eglSwapBuffersRegion2NOK")]
        public abstract bool SwapBuffersRegion2Nok([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int numRects, [Flow(FlowDirection.In)] Span<int> rects);

        public unsafe bool SwapBuffersRegion2Nok([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int numRects, [Flow(FlowDirection.In)] int* rects)
        {
            // IntPtrOverloader
            return SwapBuffersRegion2Nok(new IntPtr(dpy), new IntPtr(surface), numRects, rects);
        }

        public unsafe bool SwapBuffersRegion2Nok([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int numRects, [Flow(FlowDirection.In)] Span<int> rects)
        {
            // IntPtrOverloader
            return SwapBuffersRegion2Nok(new IntPtr(dpy), new IntPtr(surface), numRects, rects);
        }

        public NokSwapRegion2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

