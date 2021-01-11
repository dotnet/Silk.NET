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

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_sync_reuse")]
    public unsafe partial class ExtSyncReuse : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_sync_reuse";
        [NativeApi(EntryPoint = "eglUnsignalSyncEXT")]
        public unsafe partial int UnsignalSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglUnsignalSyncEXT")]
        public partial int UnsignalSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] in nint attrib_list);

        public ExtSyncReuse(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

