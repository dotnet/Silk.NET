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
    [Extension("NV_framebuffer_mixed_samples")]
    public unsafe partial class NVFramebufferMixedSamples : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_mixed_samples";
        [NativeApi(EntryPoint = "glCoverageModulationNV", Convention = CallingConvention.Winapi)]
        public partial void CoverageModulation([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV components);

        [NativeApi(EntryPoint = "glCoverageModulationTableNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverageModulationTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glCoverageModulationTableNV", Convention = CallingConvention.Winapi)]
        public partial void CoverageModulationTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glGetCoverageModulationTableNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCoverageModulationTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetCoverageModulationTableNV", Convention = CallingConvention.Winapi)]
        public partial void GetCoverageModulationTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glRasterSamplesEXT", Convention = CallingConvention.Winapi)]
        public partial void RasterSamples([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        public unsafe void CoverageModulationTable([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // ImplicitCountSpanOverloader
            CoverageModulationTable((uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe float GetCoverageModulationTable()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetCoverageModulationTable(bufSize, &ret);
            return ret;
        }

        public unsafe float GetCoverageModulationTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetCoverageModulationTable(bufSize, out float silkRet);
            return silkRet;
        }

        public NVFramebufferMixedSamples(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

