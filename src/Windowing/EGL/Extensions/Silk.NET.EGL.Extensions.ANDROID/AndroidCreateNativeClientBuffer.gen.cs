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
    [Extension("ANDROID_create_native_client_buffer")]
    public abstract unsafe partial class AndroidCreateNativeClientBuffer : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_create_native_client_buffer";
        [NativeApi(EntryPoint = "eglCreateNativeClientBufferANDROID")]
        public abstract unsafe IntPtr CreateNativeClientBuffer([Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateNativeClientBufferANDROID")]
        public abstract IntPtr CreateNativeClientBuffer([Flow(FlowDirection.In)] Span<int> attrib_list);

        public AndroidCreateNativeClientBuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

