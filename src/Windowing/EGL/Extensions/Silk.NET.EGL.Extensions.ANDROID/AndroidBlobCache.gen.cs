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
    [Extension("ANDROID_blob_cache")]
    public abstract unsafe partial class AndroidBlobCache : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglSetBlobCacheFuncsANDROID")]
        public abstract void SetBlobCacheFunc([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] SetBlobFuncAndroid set, [Flow(FlowDirection.In)] GetBlobFuncAndroid get);

        public unsafe void SetBlobCacheFunc([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] SetBlobFuncAndroid set, [Flow(FlowDirection.In)] GetBlobFuncAndroid get)
        {
            // IntPtrOverloader
            SetBlobCacheFunc(new IntPtr(dpy), set, get);
        }

        public AndroidBlobCache(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

