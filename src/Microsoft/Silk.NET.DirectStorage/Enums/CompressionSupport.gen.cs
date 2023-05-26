// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [Flags]
    [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT")]
    public enum CompressionSupport : uint
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_NONE")]
        CompressionSupportNone = 0x0,
        [Obsolete("Deprecated in favour of \"GpuOptimized\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_GPU_OPTIMIZED")]
        CompressionSupportGpuOptimized = 0x1,
        [Obsolete("Deprecated in favour of \"GpuFallback\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_GPU_FALLBACK")]
        CompressionSupportGpuFallback = 0x2,
        [Obsolete("Deprecated in favour of \"CpuFallback\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_CPU_FALLBACK")]
        CompressionSupportCpuFallback = 0x4,
        [Obsolete("Deprecated in favour of \"UsesComputeQueue\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_USES_COMPUTE_QUEUE")]
        CompressionSupportUsesComputeQueue = 0x8,
        [Obsolete("Deprecated in favour of \"UsesCopyQueue\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_USES_COPY_QUEUE")]
        CompressionSupportUsesCopyQueue = 0x10,
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_NONE")]
        None = 0x0,
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_GPU_OPTIMIZED")]
        GpuOptimized = 0x1,
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_GPU_FALLBACK")]
        GpuFallback = 0x2,
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_CPU_FALLBACK")]
        CpuFallback = 0x4,
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_USES_COMPUTE_QUEUE")]
        UsesComputeQueue = 0x8,
        [NativeName("Name", "DSTORAGE_COMPRESSION_SUPPORT_USES_COPY_QUEUE")]
        UsesCopyQueue = 0x10,
    }
}
