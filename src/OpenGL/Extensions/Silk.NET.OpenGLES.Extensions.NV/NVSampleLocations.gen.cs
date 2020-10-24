// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_sample_locations")]
    public unsafe partial class NVSampleLocations : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_sample_locations";
        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvNV")]
        public unsafe partial void FramebufferSampleLocations([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvNV")]
        public partial void FramebufferSampleLocations([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvNV")]
        public unsafe partial void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvNV")]
        public partial void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvNV")]
        public unsafe partial void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvNV")]
        public partial void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glResolveDepthValuesNV")]
        public partial void ResolveDepthValues();

        public NVSampleLocations(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

