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
    [Extension("EXT_compositor")]
    public abstract unsafe partial class ExtCompositor : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorBindTexWindowEXT")]
        public abstract bool CompositorBindTexWindow([Flow(FlowDirection.In)] int external_win_id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetContextAttributesEXT")]
        public abstract unsafe bool CompositorSetContextAttributes([Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] int* context_attributes, [Flow(FlowDirection.In)] int num_entries);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetContextAttributesEXT")]
        public abstract bool CompositorSetContextAttributes([Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] Span<int> context_attributes, [Flow(FlowDirection.In)] int num_entries);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetContextListEXT")]
        public abstract unsafe bool CompositorSetContextList([Flow(FlowDirection.In)] int* external_ref_ids, [Flow(FlowDirection.In)] int num_entries);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetContextListEXT")]
        public abstract bool CompositorSetContextList([Flow(FlowDirection.In)] Span<int> external_ref_ids, [Flow(FlowDirection.In)] int num_entries);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetSizeEXT")]
        public abstract bool CompositorSetSize([Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] int width, [Flow(FlowDirection.In)] int height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetWindowAttributesEXT")]
        public abstract unsafe bool CompositorSetWindowAttributes([Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] int* window_attributes, [Flow(FlowDirection.In)] int num_entries);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetWindowAttributesEXT")]
        public abstract bool CompositorSetWindowAttributes([Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] Span<int> window_attributes, [Flow(FlowDirection.In)] int num_entries);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetWindowListEXT")]
        public abstract unsafe bool CompositorSetWindowList([Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] int* external_win_ids, [Flow(FlowDirection.In)] int num_entries);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSetWindowListEXT")]
        public abstract bool CompositorSetWindowList([Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] Span<int> external_win_ids, [Flow(FlowDirection.In)] int num_entries);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCompositorSwapPolicyEXT")]
        public abstract bool CompositorSwapPolicy([Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] int policy);

        public ExtCompositor(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

