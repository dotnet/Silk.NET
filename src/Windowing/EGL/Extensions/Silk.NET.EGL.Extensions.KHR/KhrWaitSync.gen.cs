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
    [Extension("KHR_wait_sync")]
    public abstract unsafe partial class KhrWaitSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_wait_sync";
        [NativeApi(EntryPoint = "eglWaitSyncKHR")]
        public abstract int WaitSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] int flags);

        public unsafe int WaitSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int flags)
        {
            // IntPtrOverloader
            return WaitSync(new IntPtr(dpy), new IntPtr(sync), flags);
        }

        public KhrWaitSync(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

