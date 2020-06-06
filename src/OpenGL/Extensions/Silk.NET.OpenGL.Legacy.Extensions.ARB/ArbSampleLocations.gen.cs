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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_sample_locations")]
    public unsafe partial class ArbSampleLocations : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sample_locations";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEvaluateDepthValuesARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EvaluateDepthValues()
            => ImplEvaluateDepthValues();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FramebufferSampleLocations([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v)
            => ImplFramebufferSampleLocations(target, start, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferSampleLocations([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v)
            => ImplFramebufferSampleLocations(target, start, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v)
            => ImplNamedFramebufferSampleLocations(framebuffer, start, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v)
            => ImplNamedFramebufferSampleLocations(framebuffer, start, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v)
            => ImplFramebufferSampleLocations(target, start, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v)
            => ImplFramebufferSampleLocations(target, start, count, v);

        public ArbSampleLocations(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

