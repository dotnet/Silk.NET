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

namespace Silk.NET.EGL.Extensions.NOK
{
    [Extension("NOK_swap_region")]
    public unsafe partial class NokSwapRegion : NativeExtension<EGL>
    {
        public const string ExtensionName = "NOK_swap_region";
        [NativeApi(EntryPoint = "eglSwapBuffersRegionNOK")]
        public unsafe partial int SwapBuffersRegionNok([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numRects, [Flow(FlowDirection.In)] int* rects);

        [NativeApi(EntryPoint = "eglSwapBuffersRegionNOK")]
        public partial int SwapBuffersRegionNok([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numRects, [Flow(FlowDirection.In)] in int rects);

        public NokSwapRegion(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

