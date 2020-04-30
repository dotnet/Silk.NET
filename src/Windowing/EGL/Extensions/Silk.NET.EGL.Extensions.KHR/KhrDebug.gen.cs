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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_debug")]
    public abstract unsafe partial class KhrDebug : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglDebugMessageControlKHR")]
        public abstract unsafe int DebugMessageControl([Flow(FlowDirection.In)] DebugProcKhr callback, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglDebugMessageControlKHR")]
        public abstract int DebugMessageControl([Flow(FlowDirection.In)] DebugProcKhr callback, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglLabelObjectKHR")]
        public abstract int LabelObject([Flow(FlowDirection.In)] IntPtr display, [Flow(FlowDirection.In)] KHR objectType, [Flow(FlowDirection.In)] IntPtr @object, [Flow(FlowDirection.In)] IntPtr label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDebugKHR")]
        public abstract unsafe bool QueryDebug([Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDebugKHR")]
        public abstract bool QueryDebug([Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        public unsafe int LabelObject([Flow(FlowDirection.In)] int display, [Flow(FlowDirection.In)] KHR objectType, [Flow(FlowDirection.In)] int @object, [Flow(FlowDirection.In)] int label)
        {
            // IntPtrOverloader
            return LabelObject(new IntPtr(display), objectType, new IntPtr(@object), new IntPtr(label));
        }

        public KhrDebug(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

