// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_single_precision")]
    public unsafe partial class OesSinglePrecision : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_single_precision";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearDepthfOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearDepth([Flow(FlowDirection.In)] float depth)
            => ImplClearDepth(depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glClipPlanefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] float* equation)
            => ImplClipPlane(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glClipPlanefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> equation)
            => ImplClipPlane(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="f">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthRangefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f)
            => ImplDepthRange(n, f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="l">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="f">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFrustumfOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Frustum([Flow(FlowDirection.In)] float l, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f)
            => ImplFrustum(l, r, b, t, n, f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] float* equation)
            => ImplGetClipPlane(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetClipPlane([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> equation)
            => ImplGetClipPlane(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="l">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="f">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glOrthofOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Ortho([Flow(FlowDirection.In)] float l, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f)
            => ImplOrtho(l, r, b, t, n, f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glClipPlanefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] float* equation)
            => ImplClipPlane(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glClipPlanefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> equation)
            => ImplClipPlane(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] float* equation)
            => ImplGetClipPlane(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetClipPlanefOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> equation)
            => ImplGetClipPlane(plane, equation);

        public OesSinglePrecision(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

