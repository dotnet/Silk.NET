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

namespace Silk.NET.EGL.Extensions.ANDROID
{
    [Extension("ANDROID_presentation_time")]
    public abstract unsafe partial class AndroidPresentationTime : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglPresentationTimeANDROID")]
        public abstract bool PresentationTime([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] long time);

        public unsafe bool PresentationTime([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] long time)
        {
            // IntPtrOverloader
            return PresentationTime(new IntPtr(dpy), new IntPtr(surface), time);
        }

        public AndroidPresentationTime(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

