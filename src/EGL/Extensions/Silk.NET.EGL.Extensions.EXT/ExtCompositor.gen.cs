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
    [Extension("EXT_compositor")]
    public unsafe partial class ExtCompositor : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_compositor";
        [NativeApi(EntryPoint = "eglCompositorBindTexWindowEXT")]
        public partial int CompositorBindTexWindow([Flow(FlowDirection.In)] int external_win_id);

        [NativeApi(EntryPoint = "eglCompositorSetContextAttributesEXT")]
        public unsafe partial int CompositorSetContextAttributes([Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] int* context_attributes, [Flow(FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetContextAttributesEXT")]
        public partial int CompositorSetContextAttributes([Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] in int context_attributes, [Flow(FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetContextListEXT")]
        public unsafe partial int CompositorSetContextList([Flow(FlowDirection.In)] int* external_ref_ids, [Flow(FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetContextListEXT")]
        public partial int CompositorSetContextList([Flow(FlowDirection.In)] in int external_ref_ids, [Flow(FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetSizeEXT")]
        public partial int CompositorSetSize([Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] int width, [Flow(FlowDirection.In)] int height);

        [NativeApi(EntryPoint = "eglCompositorSetWindowAttributesEXT")]
        public unsafe partial int CompositorSetWindowAttributes([Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] int* window_attributes, [Flow(FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetWindowAttributesEXT")]
        public partial int CompositorSetWindowAttributes([Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] in int window_attributes, [Flow(FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetWindowListEXT")]
        public unsafe partial int CompositorSetWindowList([Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] int* external_win_ids, [Flow(FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetWindowListEXT")]
        public partial int CompositorSetWindowList([Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] in int external_win_ids, [Flow(FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSwapPolicyEXT")]
        public partial int CompositorSwapPolicy([Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] int policy);

        public ExtCompositor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

