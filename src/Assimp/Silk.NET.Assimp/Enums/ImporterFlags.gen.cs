// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiImporterFlags")]
    public enum ImporterFlags : int
    {
        [NativeName("Name", "aiImporterFlags_SupportTextFlavour")]
        ImporterFlagsSupportTextFlavour = 0x1,
        [NativeName("Name", "aiImporterFlags_SupportBinaryFlavour")]
        ImporterFlagsSupportBinaryFlavour = 0x2,
        [NativeName("Name", "aiImporterFlags_SupportCompressedFlavour")]
        ImporterFlagsSupportCompressedFlavour = 0x4,
        [NativeName("Name", "aiImporterFlags_LimitedSupport")]
        ImporterFlagsLimitedSupport = 0x8,
        [NativeName("Name", "aiImporterFlags_Experimental")]
        ImporterFlagsExperimental = 0x10,
    }
}
