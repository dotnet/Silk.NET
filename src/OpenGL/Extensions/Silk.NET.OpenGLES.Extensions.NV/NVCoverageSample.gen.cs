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
    [Extension("NV_coverage_sample")]
    public unsafe partial class NVCoverageSample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_coverage_sample";
        [NativeApi(EntryPoint = "glCoverageMaskNV", Convention = CallingConvention.Winapi)]
        public partial void CoverageMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] bool mask);

        [NativeApi(EntryPoint = "glCoverageOperationNV", Convention = CallingConvention.Winapi)]
        public partial void CoverageOperation([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV operation);

        public NVCoverageSample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

