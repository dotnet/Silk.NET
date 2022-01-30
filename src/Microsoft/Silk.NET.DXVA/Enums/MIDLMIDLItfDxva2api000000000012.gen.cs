// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0012")]
    public enum MIDLMIDLItfDxva2api000000000012 : int
    {
        [NativeName("Name", "DXVA2_PictureParametersBufferType")]
        DXVA2PictureParametersBufferType = 0x0,
        [NativeName("Name", "DXVA2_MacroBlockControlBufferType")]
        DXVA2MacroBlockControlBufferType = 0x1,
        [NativeName("Name", "DXVA2_ResidualDifferenceBufferType")]
        DXVA2ResidualDifferenceBufferType = 0x2,
        [NativeName("Name", "DXVA2_DeblockingControlBufferType")]
        DXVA2DeblockingControlBufferType = 0x3,
        [NativeName("Name", "DXVA2_InverseQuantizationMatrixBufferType")]
        DXVA2InverseQuantizationMatrixBufferType = 0x4,
        [NativeName("Name", "DXVA2_SliceControlBufferType")]
        DXVA2SliceControlBufferType = 0x5,
        [NativeName("Name", "DXVA2_BitStreamDateBufferType")]
        DXVA2BitStreamDateBufferType = 0x6,
        [NativeName("Name", "DXVA2_MotionVectorBuffer")]
        DXVA2MotionVectorBuffer = 0x7,
        [NativeName("Name", "DXVA2_FilmGrainBuffer")]
        DXVA2FilmGrainBuffer = 0x8,
    }
}
