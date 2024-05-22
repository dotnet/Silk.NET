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
using Silk.NET.WebGPU;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [Extension("wgpu.h")]
    public unsafe partial class Wgpu : NativeExtension<WebGPU>
    {
        public const string ExtensionName = "wgpu.h";
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 53, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial void DevicePoll(Device* device, Silk.NET.Core.Bool32 force_wait);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 55, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public partial void SetLogCallback(PfnLogCallback callback);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 57, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogLevel")]
        public partial void SetLogLevel(LogLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 59, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetVersion")]
        public partial uint GetVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants(RenderPassEncoder* encoder, ShaderStage stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants<T0>(RenderPassEncoder* encoder, ShaderStage stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        public Wgpu(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

