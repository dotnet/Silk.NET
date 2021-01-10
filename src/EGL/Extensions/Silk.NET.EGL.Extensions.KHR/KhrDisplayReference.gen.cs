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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_display_reference")]
    public unsafe partial class KhrDisplayReference : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_display_reference";
        [NativeApi(EntryPoint = "eglQueryDisplayAttribKHR")]
        public unsafe partial bool QueryDisplayAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int name, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribKHR")]
        public partial bool QueryDisplayAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int name, [Flow(FlowDirection.Out)] out nint value);

        public KhrDisplayReference(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

