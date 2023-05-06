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

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_framebuffer_multisample_coverage")]
    public unsafe partial class NVFramebufferMultisampleCoverage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_multisample_coverage";
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        public NVFramebufferMultisampleCoverage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

