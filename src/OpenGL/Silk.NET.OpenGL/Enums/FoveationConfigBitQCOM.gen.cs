// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FoveationConfigBitQCOM")]
    public enum FoveationConfigBitQCOM : int
    {
        [NativeName("Name", "GL_FOVEATION_ENABLE_BIT_QCOM")]
        FoveationEnableBitQCom = 0x1,
        [NativeName("Name", "GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM")]
        FoveationScaledBinMethodBitQCom = 0x2,
        [NativeName("Name", "GL_FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM")]
        FoveationSubsampledLayoutMethodBitQCom = 0x4,
    }
}
