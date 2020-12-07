// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_FLAG")]
    public enum CheckMultisampleQualityLevelsFlag
    {
        [NativeName("Name", "D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_TILED_RESOURCE")]
        CheckMultisampleQualityLevelsTiledResource = 0x1,
    }
}
