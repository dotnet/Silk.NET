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

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_client_sync")]
    public abstract unsafe partial class ExtClientSync : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglClientSignalSyncEXT")]
        public abstract unsafe bool ClientSignalSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglClientSignalSyncEXT")]
        public abstract bool ClientSignalSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        public unsafe bool ClientSignalSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return ClientSignalSync(new IntPtr(dpy), new IntPtr(sync), attrib_list);
        }

        public unsafe bool ClientSignalSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return ClientSignalSync(new IntPtr(dpy), new IntPtr(sync), attrib_list);
        }

        public ExtClientSync(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

