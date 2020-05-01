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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_display_reference")]
    public abstract unsafe partial class KhrDisplayReference : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_display_reference";
        [NativeApi(EntryPoint = "eglQueryDisplayAttribKHR")]
        public abstract unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int name, [Flow(FlowDirection.Out)] IntPtr* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribKHR")]
        public abstract bool QueryDisplayAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int name, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        public unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int name, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return QueryDisplayAttrib(new IntPtr(dpy), name, value);
        }

        public unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int name, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return QueryDisplayAttrib(new IntPtr(dpy), name, value);
        }

        public KhrDisplayReference(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

