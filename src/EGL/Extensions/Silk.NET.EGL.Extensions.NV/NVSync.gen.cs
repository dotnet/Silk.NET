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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_sync")]
    public unsafe partial class NVSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_sync";
        [NativeApi(EntryPoint = "eglClientWaitSyncNV")]
        public partial int ClientWaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "eglCreateFenceSyncNV")]
        public unsafe partial nint CreateFenceSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] NV condition, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateFenceSyncNV")]
        public partial nint CreateFenceSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] NV condition, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglDestroySyncNV")]
        public partial bool DestroySync([Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglFenceNV")]
        public partial bool Fence([Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglGetSyncAttribNV")]
        public unsafe partial bool GetSyncAttrib([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglGetSyncAttribNV")]
        public partial bool GetSyncAttrib([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglSignalSyncNV")]
        public partial bool SignalSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] NV mode);

        public NVSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

