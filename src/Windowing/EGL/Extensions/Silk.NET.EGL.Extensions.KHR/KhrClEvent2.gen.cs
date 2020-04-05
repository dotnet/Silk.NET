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
    [Extension("KHR_cl_event2")]
    public abstract unsafe partial class KhrClEvent2 : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateSync64KHR")]
        public abstract unsafe IntPtr CreateSync64([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateSync64KHR")]
        public abstract IntPtr CreateSync64([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        public unsafe IntPtr CreateSync64([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return CreateSync64(new IntPtr(dpy), type, attrib_list);
        }

        public unsafe IntPtr CreateSync64([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return CreateSync64(new IntPtr(dpy), type, attrib_list);
        }

        public KhrClEvent2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

