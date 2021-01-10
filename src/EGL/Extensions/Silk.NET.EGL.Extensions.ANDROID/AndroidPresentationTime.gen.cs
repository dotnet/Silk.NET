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
    [Extension("ANDROID_presentation_time")]
    public unsafe partial class AndroidPresentationTime : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_presentation_time";
        [NativeApi(EntryPoint = "eglPresentationTimeANDROID")]
        public partial bool PresentationTime([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] long time);

        public AndroidPresentationTime(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

