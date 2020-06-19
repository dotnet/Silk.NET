// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_single_precision")]
    public abstract unsafe partial class OesSinglePrecision : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_single_precision";
        [NativeApi(EntryPoint = "glClearDepthfOES")]
        public abstract void ClearDepth([Flow(FlowDirection.In)] float depth);

        [NativeApi(EntryPoint = "glClipPlanefOES")]
        public abstract unsafe void ClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] float* equation);

        [NativeApi(EntryPoint = "glClipPlanefOES")]
        public abstract void ClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> equation);

        [NativeApi(EntryPoint = "glDepthRangefOES")]
        public abstract void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glFrustumfOES")]
        public abstract void Frustum([Flow(FlowDirection.In)] float l, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        public abstract unsafe void GetClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] float* equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        public abstract void GetClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> equation);

        [NativeApi(EntryPoint = "glOrthofOES")]
        public abstract void Ortho([Flow(FlowDirection.In)] float l, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glClipPlanefOES")]
        public abstract unsafe void ClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] float* equation);

        [NativeApi(EntryPoint = "glClipPlanefOES")]
        public abstract void ClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        public abstract unsafe void GetClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] float* equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        public abstract void GetClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> equation);

        public OesSinglePrecision(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

