// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiOrigin")]
    public enum Origin
    {
        [NativeName("Name", "aiOrigin_SET")]
        OriginSet = 0x0,
        [NativeName("Name", "aiOrigin_CUR")]
        OriginCur = 0x1,
        [NativeName("Name", "aiOrigin_END")]
        OriginEnd = 0x2,
        [NativeName("Name", "_AI_ORIGIN_ENFORCE_ENUM_SIZE")]
        AIOriginEnforceEnumSize = 0x7FFFFFFF,
    }
}
