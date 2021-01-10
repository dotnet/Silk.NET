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

namespace Silk.NET.EGL.Extensions.ANDROID
{
    [Extension("ANDROID_get_native_client_buffer")]
    public unsafe partial class AndroidGetNativeClientBuffer : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_get_native_client_buffer";
        [NativeApi(EntryPoint = "eglGetNativeClientBufferANDROID")]
        public unsafe partial nint GetNativeClientBuffer([Flow(FlowDirection.In)] nint* buffer);

        [NativeApi(EntryPoint = "eglGetNativeClientBufferANDROID")]
        public partial nint GetNativeClientBuffer([Flow(FlowDirection.In)] in nint buffer);

        public AndroidGetNativeClientBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

