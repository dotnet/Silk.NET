// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUTextureUsage")]
    public enum TextureUsage : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "WGPUTextureUsage_None")]
        TextureUsageNone = 0x0,
        [Obsolete("Deprecated in favour of \"CopySrc\"")]
        [NativeName("Name", "WGPUTextureUsage_CopySrc")]
        TextureUsageCopySrc = 0x1,
        [Obsolete("Deprecated in favour of \"CopyDst\"")]
        [NativeName("Name", "WGPUTextureUsage_CopyDst")]
        TextureUsageCopyDst = 0x2,
        [Obsolete("Deprecated in favour of \"TextureBinding\"")]
        [NativeName("Name", "WGPUTextureUsage_TextureBinding")]
        TextureUsageTextureBinding = 0x4,
        [Obsolete("Deprecated in favour of \"StorageBinding\"")]
        [NativeName("Name", "WGPUTextureUsage_StorageBinding")]
        TextureUsageStorageBinding = 0x8,
        [Obsolete("Deprecated in favour of \"RenderAttachment\"")]
        [NativeName("Name", "WGPUTextureUsage_RenderAttachment")]
        TextureUsageRenderAttachment = 0x10,
        [Obsolete("Deprecated in favour of \"Present\"")]
        [NativeName("Name", "WGPUTextureUsage_Present")]
        TextureUsagePresent = 0x20,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUTextureUsage_Force32")]
        TextureUsageForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUTextureUsage_None")]
        None = 0x0,
        [NativeName("Name", "WGPUTextureUsage_CopySrc")]
        CopySrc = 0x1,
        [NativeName("Name", "WGPUTextureUsage_CopyDst")]
        CopyDst = 0x2,
        [NativeName("Name", "WGPUTextureUsage_TextureBinding")]
        TextureBinding = 0x4,
        [NativeName("Name", "WGPUTextureUsage_StorageBinding")]
        StorageBinding = 0x8,
        [NativeName("Name", "WGPUTextureUsage_RenderAttachment")]
        RenderAttachment = 0x10,
        [NativeName("Name", "WGPUTextureUsage_Present")]
        Present = 0x20,
        [NativeName("Name", "WGPUTextureUsage_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
