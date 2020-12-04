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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_viewport_array")]
    public unsafe partial class OesViewportArray : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_viewport_array";
        [NativeApi(EntryPoint = "glDepthRangeArrayfvOES")]
        public unsafe partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glDepthRangeArrayfvOES")]
        public partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glDepthRangeIndexedfOES")]
        public partial void DepthRangeIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glDisableiOES")]
        public partial void Disable([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableiOES")]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES")]
        public partial void Enable([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES")]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetFloati_vOES")]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_vOES")]
        public partial void GetFloat([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFloati_vOES")]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_vOES")]
        public partial void GetFloat([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glIsEnablediOES")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediOES")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glScissorArrayvOES")]
        public unsafe partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorArrayvOES")]
        public partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glScissorIndexedOES")]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int left, [Flow(FlowDirection.In)] int bottom, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorIndexedvOES")]
        public unsafe partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorIndexedvOES")]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glViewportArrayvOES")]
        public unsafe partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportArrayvOES")]
        public partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glViewportIndexedfOES")]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float w, [Flow(FlowDirection.In)] float h);

        [NativeApi(EntryPoint = "glViewportIndexedfvOES")]
        public unsafe partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportIndexedfvOES")]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        public OesViewportArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

