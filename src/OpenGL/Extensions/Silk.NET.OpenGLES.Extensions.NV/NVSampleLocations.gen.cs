// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_sample_locations")]
    public unsafe partial class NVSampleLocations : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_sample_locations";
        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferSampleLocations([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public partial void FramebufferSampleLocations([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public partial void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glResolveDepthValuesNV", Convention = CallingConvention.Winapi)]
        public partial void ResolveDepthValues();

        public NVSampleLocations(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

