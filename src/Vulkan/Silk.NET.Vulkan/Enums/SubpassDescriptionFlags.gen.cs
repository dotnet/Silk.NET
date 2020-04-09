// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum SubpassDescriptionFlags
    {
        SubpassDescriptionPerViewAttributesBitNvx = 1,
        SubpassDescriptionPerViewPositionXOnlyBitNvx = 2,
        SubpassDescriptionReserved2BitQCom = 4,
        SubpassDescriptionReserved3BitQCom = 8,
    }
}
