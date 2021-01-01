// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_PARAM_REGISTER_TYPE")]
    public enum ShaderParamRegisterType : int
    {
        [NativeName("Name", "D3DSPR_TEMP")]
        SprTemp = 0x0,
        [NativeName("Name", "D3DSPR_INPUT")]
        SprInput = 0x1,
        [NativeName("Name", "D3DSPR_CONST")]
        SprConst = 0x2,
        [NativeName("Name", "D3DSPR_ADDR")]
        SprAddr = 0x3,
        [NativeName("Name", "D3DSPR_TEXTURE")]
        SprTexture = 0x3,
        [NativeName("Name", "D3DSPR_RASTOUT")]
        SprRastout = 0x4,
        [NativeName("Name", "D3DSPR_ATTROUT")]
        SprAttrout = 0x5,
        [NativeName("Name", "D3DSPR_TEXCRDOUT")]
        SprTexcrdout = 0x6,
        [NativeName("Name", "D3DSPR_OUTPUT")]
        SprOutput = 0x6,
        [NativeName("Name", "D3DSPR_CONSTINT")]
        SprConstint = 0x7,
        [NativeName("Name", "D3DSPR_COLOROUT")]
        SprColorout = 0x8,
        [NativeName("Name", "D3DSPR_DEPTHOUT")]
        SprDepthout = 0x9,
        [NativeName("Name", "D3DSPR_SAMPLER")]
        SprSampler = 0xA,
        [NativeName("Name", "D3DSPR_CONST2")]
        SprConst2 = 0xB,
        [NativeName("Name", "D3DSPR_CONST3")]
        SprConst3 = 0xC,
        [NativeName("Name", "D3DSPR_CONST4")]
        SprConst4 = 0xD,
        [NativeName("Name", "D3DSPR_CONSTBOOL")]
        SprConstbool = 0xE,
        [NativeName("Name", "D3DSPR_LOOP")]
        SprLoop = 0xF,
        [NativeName("Name", "D3DSPR_TEMPFLOAT16")]
        SprTempfloat16 = 0x10,
        [NativeName("Name", "D3DSPR_MISCTYPE")]
        SprMisctype = 0x11,
        [NativeName("Name", "D3DSPR_LABEL")]
        SprLabel = 0x12,
        [NativeName("Name", "D3DSPR_PREDICATE")]
        SprPredicate = 0x13,
        [NativeName("Name", "D3DSPR_FORCE_DWORD")]
        SprForceDword = 0x7FFFFFFF,
    }
}
