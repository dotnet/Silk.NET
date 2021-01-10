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
    [Extension("KHR_partial_update")]
    public unsafe partial class KhrPartialUpdate : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_partial_update";
        [NativeApi(EntryPoint = "eglSetDamageRegionKHR")]
        public unsafe partial bool SetDamageRegion([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.Out)] int* rects, [Flow(FlowDirection.In)] int n_rects);

        [NativeApi(EntryPoint = "eglSetDamageRegionKHR")]
        public partial bool SetDamageRegion([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.Out)] out int rects, [Flow(FlowDirection.In)] int n_rects);

        public KhrPartialUpdate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

