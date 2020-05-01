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
    [Extension("ANDROID_get_native_client_buffer")]
    public abstract unsafe partial class AndroidGetNativeClientBuffer : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_get_native_client_buffer";
        [NativeApi(EntryPoint = "eglGetNativeClientBufferANDROID")]
        public abstract unsafe IntPtr GetNativeClientBuffer([Flow(FlowDirection.In)] IntPtr* buffer);

        [NativeApi(EntryPoint = "eglGetNativeClientBufferANDROID")]
        public abstract IntPtr GetNativeClientBuffer([Flow(FlowDirection.In)] Span<IntPtr> buffer);

        public AndroidGetNativeClientBuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

