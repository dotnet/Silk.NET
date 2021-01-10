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
    [Extension("ANDROID_native_fence_sync")]
    public unsafe partial class AndroidNativeFenceSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_native_fence_sync";
        [NativeApi(EntryPoint = "eglDupNativeFenceFDANDROID")]
        public partial int DupNativeFenceFD([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync);

        public AndroidNativeFenceSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

