// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DRENDERSTATETYPE")]
    public enum Renderstatetype : int
    {
        [NativeName("Name", "D3DRS_ZENABLE")]
        RSZenable = 0x7,
        [NativeName("Name", "D3DRS_FILLMODE")]
        RSFillmode = 0x8,
        [NativeName("Name", "D3DRS_SHADEMODE")]
        RSShademode = 0x9,
        [NativeName("Name", "D3DRS_ZWRITEENABLE")]
        RSZwriteenable = 0xE,
        [NativeName("Name", "D3DRS_ALPHATESTENABLE")]
        RSAlphatestenable = 0xF,
        [NativeName("Name", "D3DRS_LASTPIXEL")]
        RSLastpixel = 0x10,
        [NativeName("Name", "D3DRS_SRCBLEND")]
        RSSrcblend = 0x13,
        [NativeName("Name", "D3DRS_DESTBLEND")]
        RSDestblend = 0x14,
        [NativeName("Name", "D3DRS_CULLMODE")]
        RSCullmode = 0x16,
        [NativeName("Name", "D3DRS_ZFUNC")]
        RSZfunc = 0x17,
        [NativeName("Name", "D3DRS_ALPHAREF")]
        RSAlpharef = 0x18,
        [NativeName("Name", "D3DRS_ALPHAFUNC")]
        RSAlphafunc = 0x19,
        [NativeName("Name", "D3DRS_DITHERENABLE")]
        RSDitherenable = 0x1A,
        [NativeName("Name", "D3DRS_ALPHABLENDENABLE")]
        RSAlphablendenable = 0x1B,
        [NativeName("Name", "D3DRS_FOGENABLE")]
        RSFogenable = 0x1C,
        [NativeName("Name", "D3DRS_SPECULARENABLE")]
        RSSpecularenable = 0x1D,
        [NativeName("Name", "D3DRS_FOGCOLOR")]
        RSFogcolor = 0x22,
        [NativeName("Name", "D3DRS_FOGTABLEMODE")]
        RSFogtablemode = 0x23,
        [NativeName("Name", "D3DRS_FOGSTART")]
        RSFogstart = 0x24,
        [NativeName("Name", "D3DRS_FOGEND")]
        RSFogend = 0x25,
        [NativeName("Name", "D3DRS_FOGDENSITY")]
        RSFogdensity = 0x26,
        [NativeName("Name", "D3DRS_RANGEFOGENABLE")]
        RSRangefogenable = 0x30,
        [NativeName("Name", "D3DRS_STENCILENABLE")]
        RSStencilenable = 0x34,
        [NativeName("Name", "D3DRS_STENCILFAIL")]
        RSStencilfail = 0x35,
        [NativeName("Name", "D3DRS_STENCILZFAIL")]
        RSStencilzfail = 0x36,
        [NativeName("Name", "D3DRS_STENCILPASS")]
        RSStencilpass = 0x37,
        [NativeName("Name", "D3DRS_STENCILFUNC")]
        RSStencilfunc = 0x38,
        [NativeName("Name", "D3DRS_STENCILREF")]
        RSStencilref = 0x39,
        [NativeName("Name", "D3DRS_STENCILMASK")]
        RSStencilmask = 0x3A,
        [NativeName("Name", "D3DRS_STENCILWRITEMASK")]
        RSStencilwritemask = 0x3B,
        [NativeName("Name", "D3DRS_TEXTUREFACTOR")]
        RSTexturefactor = 0x3C,
        [NativeName("Name", "D3DRS_WRAP0")]
        RSWrap0 = 0x80,
        [NativeName("Name", "D3DRS_WRAP1")]
        RSWrap1 = 0x81,
        [NativeName("Name", "D3DRS_WRAP2")]
        RSWrap2 = 0x82,
        [NativeName("Name", "D3DRS_WRAP3")]
        RSWrap3 = 0x83,
        [NativeName("Name", "D3DRS_WRAP4")]
        RSWrap4 = 0x84,
        [NativeName("Name", "D3DRS_WRAP5")]
        RSWrap5 = 0x85,
        [NativeName("Name", "D3DRS_WRAP6")]
        RSWrap6 = 0x86,
        [NativeName("Name", "D3DRS_WRAP7")]
        RSWrap7 = 0x87,
        [NativeName("Name", "D3DRS_CLIPPING")]
        RSClipping = 0x88,
        [NativeName("Name", "D3DRS_LIGHTING")]
        RSLighting = 0x89,
        [NativeName("Name", "D3DRS_AMBIENT")]
        RSAmbient = 0x8B,
        [NativeName("Name", "D3DRS_FOGVERTEXMODE")]
        RSFogvertexmode = 0x8C,
        [NativeName("Name", "D3DRS_COLORVERTEX")]
        RSColorvertex = 0x8D,
        [NativeName("Name", "D3DRS_LOCALVIEWER")]
        RSLocalviewer = 0x8E,
        [NativeName("Name", "D3DRS_NORMALIZENORMALS")]
        RSNormalizenormals = 0x8F,
        [NativeName("Name", "D3DRS_DIFFUSEMATERIALSOURCE")]
        RSDiffusematerialsource = 0x91,
        [NativeName("Name", "D3DRS_SPECULARMATERIALSOURCE")]
        RSSpecularmaterialsource = 0x92,
        [NativeName("Name", "D3DRS_AMBIENTMATERIALSOURCE")]
        RSAmbientmaterialsource = 0x93,
        [NativeName("Name", "D3DRS_EMISSIVEMATERIALSOURCE")]
        RSEmissivematerialsource = 0x94,
        [NativeName("Name", "D3DRS_VERTEXBLEND")]
        RSVertexblend = 0x97,
        [NativeName("Name", "D3DRS_CLIPPLANEENABLE")]
        RSClipplaneenable = 0x98,
        [NativeName("Name", "D3DRS_POINTSIZE")]
        RSPointsize = 0x9A,
        [NativeName("Name", "D3DRS_POINTSIZE_MIN")]
        RSPointsizeMin = 0x9B,
        [NativeName("Name", "D3DRS_POINTSPRITEENABLE")]
        RSPointspriteenable = 0x9C,
        [NativeName("Name", "D3DRS_POINTSCALEENABLE")]
        RSPointscaleenable = 0x9D,
        [NativeName("Name", "D3DRS_POINTSCALE_A")]
        RSPointscaleA = 0x9E,
        [NativeName("Name", "D3DRS_POINTSCALE_B")]
        RSPointscaleB = 0x9F,
        [NativeName("Name", "D3DRS_POINTSCALE_C")]
        RSPointscaleC = 0xA0,
        [NativeName("Name", "D3DRS_MULTISAMPLEANTIALIAS")]
        RSMultisampleantialias = 0xA1,
        [NativeName("Name", "D3DRS_MULTISAMPLEMASK")]
        RSMultisamplemask = 0xA2,
        [NativeName("Name", "D3DRS_PATCHEDGESTYLE")]
        RSPatchedgestyle = 0xA3,
        [NativeName("Name", "D3DRS_DEBUGMONITORTOKEN")]
        RSDebugmonitortoken = 0xA5,
        [NativeName("Name", "D3DRS_POINTSIZE_MAX")]
        RSPointsizeMax = 0xA6,
        [NativeName("Name", "D3DRS_INDEXEDVERTEXBLENDENABLE")]
        RSIndexedvertexblendenable = 0xA7,
        [NativeName("Name", "D3DRS_COLORWRITEENABLE")]
        RSColorwriteenable = 0xA8,
        [NativeName("Name", "D3DRS_TWEENFACTOR")]
        RSTweenfactor = 0xAA,
        [NativeName("Name", "D3DRS_BLENDOP")]
        RSBlendop = 0xAB,
        [NativeName("Name", "D3DRS_POSITIONDEGREE")]
        RSPositiondegree = 0xAC,
        [NativeName("Name", "D3DRS_NORMALDEGREE")]
        RSNormaldegree = 0xAD,
        [NativeName("Name", "D3DRS_SCISSORTESTENABLE")]
        RSScissortestenable = 0xAE,
        [NativeName("Name", "D3DRS_SLOPESCALEDEPTHBIAS")]
        RSSlopescaledepthbias = 0xAF,
        [NativeName("Name", "D3DRS_ANTIALIASEDLINEENABLE")]
        RSAntialiasedlineenable = 0xB0,
        [NativeName("Name", "D3DRS_MINTESSELLATIONLEVEL")]
        RSMintessellationlevel = 0xB2,
        [NativeName("Name", "D3DRS_MAXTESSELLATIONLEVEL")]
        RSMaxtessellationlevel = 0xB3,
        [NativeName("Name", "D3DRS_ADAPTIVETESS_X")]
        RSAdaptivetessX = 0xB4,
        [NativeName("Name", "D3DRS_ADAPTIVETESS_Y")]
        RSAdaptivetessY = 0xB5,
        [NativeName("Name", "D3DRS_ADAPTIVETESS_Z")]
        RSAdaptivetessZ = 0xB6,
        [NativeName("Name", "D3DRS_ADAPTIVETESS_W")]
        RSAdaptivetessW = 0xB7,
        [NativeName("Name", "D3DRS_ENABLEADAPTIVETESSELLATION")]
        RSEnableadaptivetessellation = 0xB8,
        [NativeName("Name", "D3DRS_TWOSIDEDSTENCILMODE")]
        RSTwosidedstencilmode = 0xB9,
        [NativeName("Name", "D3DRS_CCW_STENCILFAIL")]
        RSCcwStencilfail = 0xBA,
        [NativeName("Name", "D3DRS_CCW_STENCILZFAIL")]
        RSCcwStencilzfail = 0xBB,
        [NativeName("Name", "D3DRS_CCW_STENCILPASS")]
        RSCcwStencilpass = 0xBC,
        [NativeName("Name", "D3DRS_CCW_STENCILFUNC")]
        RSCcwStencilfunc = 0xBD,
        [NativeName("Name", "D3DRS_COLORWRITEENABLE1")]
        RSColorwriteenable1 = 0xBE,
        [NativeName("Name", "D3DRS_COLORWRITEENABLE2")]
        RSColorwriteenable2 = 0xBF,
        [NativeName("Name", "D3DRS_COLORWRITEENABLE3")]
        RSColorwriteenable3 = 0xC0,
        [NativeName("Name", "D3DRS_BLENDFACTOR")]
        RSBlendfactor = 0xC1,
        [NativeName("Name", "D3DRS_SRGBWRITEENABLE")]
        RSSrgbwriteenable = 0xC2,
        [NativeName("Name", "D3DRS_DEPTHBIAS")]
        RSDepthbias = 0xC3,
        [NativeName("Name", "D3DRS_WRAP8")]
        RSWrap8 = 0xC6,
        [NativeName("Name", "D3DRS_WRAP9")]
        RSWrap9 = 0xC7,
        [NativeName("Name", "D3DRS_WRAP10")]
        RSWrap10 = 0xC8,
        [NativeName("Name", "D3DRS_WRAP11")]
        RSWrap11 = 0xC9,
        [NativeName("Name", "D3DRS_WRAP12")]
        RSWrap12 = 0xCA,
        [NativeName("Name", "D3DRS_WRAP13")]
        RSWrap13 = 0xCB,
        [NativeName("Name", "D3DRS_WRAP14")]
        RSWrap14 = 0xCC,
        [NativeName("Name", "D3DRS_WRAP15")]
        RSWrap15 = 0xCD,
        [NativeName("Name", "D3DRS_SEPARATEALPHABLENDENABLE")]
        RSSeparatealphablendenable = 0xCE,
        [NativeName("Name", "D3DRS_SRCBLENDALPHA")]
        RSSrcblendalpha = 0xCF,
        [NativeName("Name", "D3DRS_DESTBLENDALPHA")]
        RSDestblendalpha = 0xD0,
        [NativeName("Name", "D3DRS_BLENDOPALPHA")]
        RSBlendopalpha = 0xD1,
        [NativeName("Name", "D3DRS_FORCE_DWORD")]
        RSForceDword = 0x7FFFFFFF,
    }
}
