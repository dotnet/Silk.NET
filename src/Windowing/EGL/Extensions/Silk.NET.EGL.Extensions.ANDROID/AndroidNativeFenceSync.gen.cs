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

namespace Silk.NET.EGL.Extensions.ANDROID
{
    [Extension("ANDROID_native_fence_sync")]
    public abstract unsafe partial class AndroidNativeFenceSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_native_fence_sync";
        [NativeApi(EntryPoint = "eglDupNativeFenceFDANDROID")]
        public abstract int DupNativeFenceFD([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync);

        public unsafe int DupNativeFenceFD([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return DupNativeFenceFD(new IntPtr(dpy), new IntPtr(sync));
        }

        public AndroidNativeFenceSync(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

