// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_PARAM_SRCMOD_TYPE")]
    public enum ShaderParamSrcmodType : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3DSPSM_NONE")]
        SpsmNone = 0x0,
        [Obsolete("Deprecated in favour of \"Neg\"")]
        [NativeName("Name", "D3DSPSM_NEG")]
        SpsmNeg = 0x1000000,
        [Obsolete("Deprecated in favour of \"Bias\"")]
        [NativeName("Name", "D3DSPSM_BIAS")]
        SpsmBias = 0x2000000,
        [Obsolete("Deprecated in favour of \"Biasneg\"")]
        [NativeName("Name", "D3DSPSM_BIASNEG")]
        SpsmBiasneg = 0x3000000,
        [Obsolete("Deprecated in favour of \"Sign\"")]
        [NativeName("Name", "D3DSPSM_SIGN")]
        SpsmSign = 0x4000000,
        [Obsolete("Deprecated in favour of \"Signneg\"")]
        [NativeName("Name", "D3DSPSM_SIGNNEG")]
        SpsmSignneg = 0x5000000,
        [Obsolete("Deprecated in favour of \"Comp\"")]
        [NativeName("Name", "D3DSPSM_COMP")]
        SpsmComp = 0x6000000,
        [Obsolete("Deprecated in favour of \"X2\"")]
        [NativeName("Name", "D3DSPSM_X2")]
        SpsmX2 = 0x7000000,
        [Obsolete("Deprecated in favour of \"X2Neg\"")]
        [NativeName("Name", "D3DSPSM_X2NEG")]
        SpsmX2Neg = 0x8000000,
        [Obsolete("Deprecated in favour of \"DZ\"")]
        [NativeName("Name", "D3DSPSM_DZ")]
        SpsmDZ = 0x9000000,
        [Obsolete("Deprecated in favour of \"DW\"")]
        [NativeName("Name", "D3DSPSM_DW")]
        SpsmDW = 0xA000000,
        [Obsolete("Deprecated in favour of \"Abs\"")]
        [NativeName("Name", "D3DSPSM_ABS")]
        SpsmAbs = 0xB000000,
        [Obsolete("Deprecated in favour of \"Absneg\"")]
        [NativeName("Name", "D3DSPSM_ABSNEG")]
        SpsmAbsneg = 0xC000000,
        [Obsolete("Deprecated in favour of \"Not\"")]
        [NativeName("Name", "D3DSPSM_NOT")]
        SpsmNot = 0xD000000,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSPSM_FORCE_DWORD")]
        SpsmForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSPSM_NONE")]
        None = 0x0,
        [NativeName("Name", "D3DSPSM_NEG")]
        Neg = 0x1000000,
        [NativeName("Name", "D3DSPSM_BIAS")]
        Bias = 0x2000000,
        [NativeName("Name", "D3DSPSM_BIASNEG")]
        Biasneg = 0x3000000,
        [NativeName("Name", "D3DSPSM_SIGN")]
        Sign = 0x4000000,
        [NativeName("Name", "D3DSPSM_SIGNNEG")]
        Signneg = 0x5000000,
        [NativeName("Name", "D3DSPSM_COMP")]
        Comp = 0x6000000,
        [NativeName("Name", "D3DSPSM_X2")]
        X2 = 0x7000000,
        [NativeName("Name", "D3DSPSM_X2NEG")]
        X2Neg = 0x8000000,
        [NativeName("Name", "D3DSPSM_DZ")]
        DZ = 0x9000000,
        [NativeName("Name", "D3DSPSM_DW")]
        DW = 0xA000000,
        [NativeName("Name", "D3DSPSM_ABS")]
        Abs = 0xB000000,
        [NativeName("Name", "D3DSPSM_ABSNEG")]
        Absneg = 0xC000000,
        [NativeName("Name", "D3DSPSM_NOT")]
        Not = 0xD000000,
        [NativeName("Name", "D3DSPSM_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
