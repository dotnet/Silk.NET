// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_single_precision")]
    public unsafe partial class OesSinglePrecision : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_single_precision";
        [NativeApi(EntryPoint = "glClearDepthfOES")]
        public partial void ClearDepth([Flow(FlowDirection.In)] float depth);

        [NativeApi(EntryPoint = "glClipPlanefOES")]
        public unsafe partial void ClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] float* equation);

        [NativeApi(EntryPoint = "glClipPlanefOES")]
        public partial void ClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> equation);

        [NativeApi(EntryPoint = "glDepthRangefOES")]
        public partial void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glFrustumfOES")]
        public partial void Frustum([Flow(FlowDirection.In)] float l, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        public unsafe partial void GetClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] float* equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        public partial void GetClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> equation);

        [NativeApi(EntryPoint = "glOrthofOES")]
        public partial void Ortho([Flow(FlowDirection.In)] float l, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glClipPlanefOES")]
        public unsafe partial void ClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] float* equation);

        [NativeApi(EntryPoint = "glClipPlanefOES")]
        public partial void ClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        public unsafe partial void GetClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] float* equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        public partial void GetClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> equation);

        public OesSinglePrecision(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

