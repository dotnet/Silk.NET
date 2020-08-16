// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_viewport_array")]
    public unsafe partial class NVViewportArray : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_viewport_array";
        [NativeApi(EntryPoint = "glDepthRangeArrayfvNV")]
        public unsafe partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glDepthRangeArrayfvNV")]
        public partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glDepthRangeIndexedfNV")]
        public partial void DepthRangeIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glDisableiNV")]
        public partial void Disable([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiNV")]
        public partial void Enable([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetFloati_vNV")]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_vNV")]
        public partial void GetFloat([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glIsEnablediNV")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glScissorArrayvNV")]
        public unsafe partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorArrayvNV")]
        public partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int v);

        [NativeApi(EntryPoint = "glScissorIndexedNV")]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int left, [Flow(FlowDirection.In)] int bottom, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorIndexedvNV")]
        public unsafe partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorIndexedvNV")]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glViewportArrayvNV")]
        public unsafe partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportArrayvNV")]
        public partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref float v);

        [NativeApi(EntryPoint = "glViewportIndexedfNV")]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float w, [Flow(FlowDirection.In)] float h);

        [NativeApi(EntryPoint = "glViewportIndexedfvNV")]
        public unsafe partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportIndexedfvNV")]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glDisableiNV")]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiNV")]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediNV")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        public NVViewportArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

