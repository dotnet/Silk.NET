// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_PARAM_SRCMOD_TYPE")]
    public enum ShaderParamSrcmodType
    {
        [NativeName("Name", "D3DSPSM_NONE")]
        SpsmNone = 0x0,
        [NativeName("Name", "D3DSPSM_NEG")]
        SpsmNeg = 0x1000000,
        [NativeName("Name", "D3DSPSM_BIAS")]
        SpsmBias = 0x2000000,
        [NativeName("Name", "D3DSPSM_BIASNEG")]
        SpsmBiasneg = 0x3000000,
        [NativeName("Name", "D3DSPSM_SIGN")]
        SpsmSign = 0x4000000,
        [NativeName("Name", "D3DSPSM_SIGNNEG")]
        SpsmSignneg = 0x5000000,
        [NativeName("Name", "D3DSPSM_COMP")]
        SpsmComp = 0x6000000,
        [NativeName("Name", "D3DSPSM_X2")]
        SpsmX2 = 0x7000000,
        [NativeName("Name", "D3DSPSM_X2NEG")]
        SpsmX2Neg = 0x8000000,
        [NativeName("Name", "D3DSPSM_DZ")]
        SpsmDZ = 0x9000000,
        [NativeName("Name", "D3DSPSM_DW")]
        SpsmDW = 0xA000000,
        [NativeName("Name", "D3DSPSM_ABS")]
        SpsmAbs = 0xB000000,
        [NativeName("Name", "D3DSPSM_ABSNEG")]
        SpsmAbsneg = 0xC000000,
        [NativeName("Name", "D3DSPSM_NOT")]
        SpsmNot = 0xD000000,
        [NativeName("Name", "D3DSPSM_FORCE_DWORD")]
        SpsmForceDword = 0x7FFFFFFF,
    }
}
