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
    [Extension("KHR_reusable_sync")]
    public unsafe partial class KhrReusableSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_reusable_sync";
        [NativeApi(EntryPoint = "eglClientWaitSyncKHR")]
        public partial int ClientWaitSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "eglCreateSyncKHR")]
        public unsafe partial nint CreateSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateSyncKHR")]
        public partial nint CreateSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglDestroySyncKHR")]
        public partial bool DestroySync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglGetSyncAttribKHR")]
        public unsafe partial bool GetSyncAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglGetSyncAttribKHR")]
        public partial bool GetSyncAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglSignalSyncKHR")]
        public partial bool SignalSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] KHR mode);

        public KhrReusableSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

