// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE")]
    public enum VideoEncoderDirtyRegionsMapValuesMode : int
    {
        [Obsolete("Deprecated in favour of \"Dirty\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE_DIRTY")]
        VideoEncoderDirtyRegionsMapValuesModeDirty = 0x0,
        [Obsolete("Deprecated in favour of \"Skip\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE_SKIP")]
        VideoEncoderDirtyRegionsMapValuesModeSkip = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE_DIRTY")]
        Dirty = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE_SKIP")]
        Skip = 0x1,
    }
}
