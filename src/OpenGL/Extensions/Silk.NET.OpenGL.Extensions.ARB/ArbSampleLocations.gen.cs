// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_sample_locations")]
    public unsafe partial class ArbSampleLocations : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sample_locations";
        [NativeApi(EntryPoint = "glEvaluateDepthValuesARB")]
        public partial void EvaluateDepthValues();

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB")]
        public unsafe partial void FramebufferSampleLocations([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB")]
        public partial void FramebufferSampleLocations([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvARB")]
        public unsafe partial void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvARB")]
        public partial void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB")]
        public unsafe partial void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB")]
        public partial void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v);

        public ArbSampleLocations(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

