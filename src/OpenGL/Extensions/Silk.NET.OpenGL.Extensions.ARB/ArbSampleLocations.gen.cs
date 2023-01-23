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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_sample_locations")]
    public unsafe partial class ArbSampleLocations : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sample_locations";
        [NativeApi(EntryPoint = "glEvaluateDepthValuesARB", Convention = CallingConvention.Winapi)]
        public partial void EvaluateDepthValues();

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferSampleLocations([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB", Convention = CallingConvention.Winapi)]
        public partial void FramebufferSampleLocations([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glFramebufferSampleLocationsfvARB", Convention = CallingConvention.Winapi)]
        public partial void FramebufferSampleLocations([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glNamedFramebufferSampleLocationsfvARB", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferSampleLocations([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        public ArbSampleLocations(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

