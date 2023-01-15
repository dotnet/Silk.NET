// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_PARAM_REGISTER_TYPE")]
    public enum ShaderParamRegisterType : int
    {
        [Obsolete("Deprecated in favour of \"Temp\"")]
        [NativeName("Name", "D3DSPR_TEMP")]
        SprTemp = 0x0,
        [Obsolete("Deprecated in favour of \"Input\"")]
        [NativeName("Name", "D3DSPR_INPUT")]
        SprInput = 0x1,
        [Obsolete("Deprecated in favour of \"Const\"")]
        [NativeName("Name", "D3DSPR_CONST")]
        SprConst = 0x2,
        [Obsolete("Deprecated in favour of \"Addr\"")]
        [NativeName("Name", "D3DSPR_ADDR")]
        SprAddr = 0x3,
        [Obsolete("Deprecated in favour of \"Texture\"")]
        [NativeName("Name", "D3DSPR_TEXTURE")]
        SprTexture = 0x3,
        [Obsolete("Deprecated in favour of \"Rastout\"")]
        [NativeName("Name", "D3DSPR_RASTOUT")]
        SprRastout = 0x4,
        [Obsolete("Deprecated in favour of \"Attrout\"")]
        [NativeName("Name", "D3DSPR_ATTROUT")]
        SprAttrout = 0x5,
        [Obsolete("Deprecated in favour of \"Texcrdout\"")]
        [NativeName("Name", "D3DSPR_TEXCRDOUT")]
        SprTexcrdout = 0x6,
        [Obsolete("Deprecated in favour of \"Output\"")]
        [NativeName("Name", "D3DSPR_OUTPUT")]
        SprOutput = 0x6,
        [Obsolete("Deprecated in favour of \"Constint\"")]
        [NativeName("Name", "D3DSPR_CONSTINT")]
        SprConstint = 0x7,
        [Obsolete("Deprecated in favour of \"Colorout\"")]
        [NativeName("Name", "D3DSPR_COLOROUT")]
        SprColorout = 0x8,
        [Obsolete("Deprecated in favour of \"Depthout\"")]
        [NativeName("Name", "D3DSPR_DEPTHOUT")]
        SprDepthout = 0x9,
        [Obsolete("Deprecated in favour of \"Sampler\"")]
        [NativeName("Name", "D3DSPR_SAMPLER")]
        SprSampler = 0xA,
        [Obsolete("Deprecated in favour of \"Const2\"")]
        [NativeName("Name", "D3DSPR_CONST2")]
        SprConst2 = 0xB,
        [Obsolete("Deprecated in favour of \"Const3\"")]
        [NativeName("Name", "D3DSPR_CONST3")]
        SprConst3 = 0xC,
        [Obsolete("Deprecated in favour of \"Const4\"")]
        [NativeName("Name", "D3DSPR_CONST4")]
        SprConst4 = 0xD,
        [Obsolete("Deprecated in favour of \"Constbool\"")]
        [NativeName("Name", "D3DSPR_CONSTBOOL")]
        SprConstbool = 0xE,
        [Obsolete("Deprecated in favour of \"Loop\"")]
        [NativeName("Name", "D3DSPR_LOOP")]
        SprLoop = 0xF,
        [Obsolete("Deprecated in favour of \"Tempfloat16\"")]
        [NativeName("Name", "D3DSPR_TEMPFLOAT16")]
        SprTempfloat16 = 0x10,
        [Obsolete("Deprecated in favour of \"Misctype\"")]
        [NativeName("Name", "D3DSPR_MISCTYPE")]
        SprMisctype = 0x11,
        [Obsolete("Deprecated in favour of \"Label\"")]
        [NativeName("Name", "D3DSPR_LABEL")]
        SprLabel = 0x12,
        [Obsolete("Deprecated in favour of \"Predicate\"")]
        [NativeName("Name", "D3DSPR_PREDICATE")]
        SprPredicate = 0x13,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSPR_FORCE_DWORD")]
        SprForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSPR_TEMP")]
        Temp = 0x0,
        [NativeName("Name", "D3DSPR_INPUT")]
        Input = 0x1,
        [NativeName("Name", "D3DSPR_CONST")]
        Const = 0x2,
        [NativeName("Name", "D3DSPR_ADDR")]
        Addr = 0x3,
        [NativeName("Name", "D3DSPR_TEXTURE")]
        Texture = 0x3,
        [NativeName("Name", "D3DSPR_RASTOUT")]
        Rastout = 0x4,
        [NativeName("Name", "D3DSPR_ATTROUT")]
        Attrout = 0x5,
        [NativeName("Name", "D3DSPR_TEXCRDOUT")]
        Texcrdout = 0x6,
        [NativeName("Name", "D3DSPR_OUTPUT")]
        Output = 0x6,
        [NativeName("Name", "D3DSPR_CONSTINT")]
        Constint = 0x7,
        [NativeName("Name", "D3DSPR_COLOROUT")]
        Colorout = 0x8,
        [NativeName("Name", "D3DSPR_DEPTHOUT")]
        Depthout = 0x9,
        [NativeName("Name", "D3DSPR_SAMPLER")]
        Sampler = 0xA,
        [NativeName("Name", "D3DSPR_CONST2")]
        Const2 = 0xB,
        [NativeName("Name", "D3DSPR_CONST3")]
        Const3 = 0xC,
        [NativeName("Name", "D3DSPR_CONST4")]
        Const4 = 0xD,
        [NativeName("Name", "D3DSPR_CONSTBOOL")]
        Constbool = 0xE,
        [NativeName("Name", "D3DSPR_LOOP")]
        Loop = 0xF,
        [NativeName("Name", "D3DSPR_TEMPFLOAT16")]
        Tempfloat16 = 0x10,
        [NativeName("Name", "D3DSPR_MISCTYPE")]
        Misctype = 0x11,
        [NativeName("Name", "D3DSPR_LABEL")]
        Label = 0x12,
        [NativeName("Name", "D3DSPR_PREDICATE")]
        Predicate = 0x13,
        [NativeName("Name", "D3DSPR_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
