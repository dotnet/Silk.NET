// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
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
