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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_fence_sync")]
    public abstract unsafe partial class KhrFenceSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_fence_sync";
        [NativeApi(EntryPoint = "eglClientWaitSyncKHR")]
        public abstract int ClientWaitSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] int flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "eglCreateSyncKHR")]
        public abstract unsafe IntPtr CreateSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateSyncKHR")]
        public abstract IntPtr CreateSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] Span<int> attrib_list);

        [NativeApi(EntryPoint = "eglDestroySyncKHR")]
        public abstract bool DestroySync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "eglGetSyncAttribKHR")]
        public abstract unsafe bool GetSyncAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglGetSyncAttribKHR")]
        public abstract bool GetSyncAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value);

        public unsafe int ClientWaitSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            return ClientWaitSync(new IntPtr(dpy), new IntPtr(sync), flags, timeout);
        }

        public unsafe IntPtr CreateSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreateSync(new IntPtr(dpy), type, attrib_list);
        }

        public unsafe IntPtr CreateSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreateSync(new IntPtr(dpy), type, attrib_list);
        }

        public unsafe bool DestroySync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return DestroySync(new IntPtr(dpy), new IntPtr(sync));
        }

        public unsafe bool GetSyncAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value)
        {
            // IntPtrOverloader
            return GetSyncAttrib(new IntPtr(dpy), new IntPtr(sync), attribute, value);
        }

        public unsafe bool GetSyncAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // IntPtrOverloader
            return GetSyncAttrib(new IntPtr(dpy), new IntPtr(sync), attribute, value);
        }

        public KhrFenceSync(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

