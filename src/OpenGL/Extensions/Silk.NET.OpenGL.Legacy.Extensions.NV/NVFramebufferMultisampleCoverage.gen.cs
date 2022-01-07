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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_framebuffer_multisample_coverage")]
    public unsafe partial class NVFramebufferMultisampleCoverage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_multisample_coverage";
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public NVFramebufferMultisampleCoverage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

