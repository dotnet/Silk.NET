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
    [Extension("ANDROID_create_native_client_buffer")]
    public unsafe partial class AndroidCreateNativeClientBuffer : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_create_native_client_buffer";
        [NativeApi(EntryPoint = "eglCreateNativeClientBufferANDROID")]
        public unsafe partial nint CreateNativeClientBuffer([Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateNativeClientBufferANDROID")]
        public partial nint CreateNativeClientBuffer([Flow(FlowDirection.In)] in int attrib_list);

        public AndroidCreateNativeClientBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

