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
    [Extension("KHR_cl_event2")]
    public unsafe partial class KhrClEvent2 : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_cl_event2";
        [NativeApi(EntryPoint = "eglCreateSync64KHR")]
        public unsafe partial nint CreateSync64([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreateSync64KHR")]
        public partial nint CreateSync64([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] in nint attrib_list);

        public KhrClEvent2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

