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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_partial_update")]
    public abstract unsafe partial class KhrPartialUpdate : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglSetDamageRegionKHR")]
        public abstract unsafe bool SetDamageRegion([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.Out)] int* rects, [Flow(FlowDirection.In)] int n_rects);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglSetDamageRegionKHR")]
        public abstract bool SetDamageRegion([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.Out)] Span<int> rects, [Flow(FlowDirection.In)] int n_rects);

        public unsafe bool SetDamageRegion([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.Out)] int* rects, [Flow(FlowDirection.In)] int n_rects)
        {
            // IntPtrOverloader
            return SetDamageRegion(new IntPtr(dpy), new IntPtr(surface), rects, n_rects);
        }

        public unsafe bool SetDamageRegion([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.Out)] Span<int> rects, [Flow(FlowDirection.In)] int n_rects)
        {
            // IntPtrOverloader
            return SetDamageRegion(new IntPtr(dpy), new IntPtr(surface), rects, n_rects);
        }

        public KhrPartialUpdate(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

