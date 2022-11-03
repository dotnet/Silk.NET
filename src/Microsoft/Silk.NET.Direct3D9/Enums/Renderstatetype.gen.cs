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
        [Obsolete("Deprecated in favour of \"Zenable\"")]
        [NativeName("Name", "D3DRS_ZENABLE")]
        RSZenable = 0x7,
        [Obsolete("Deprecated in favour of \"Fillmode\"")]
        [NativeName("Name", "D3DRS_FILLMODE")]
        RSFillmode = 0x8,
        [Obsolete("Deprecated in favour of \"Shademode\"")]
        [NativeName("Name", "D3DRS_SHADEMODE")]
        RSShademode = 0x9,
        [Obsolete("Deprecated in favour of \"Zwriteenable\"")]
        [NativeName("Name", "D3DRS_ZWRITEENABLE")]
        RSZwriteenable = 0xE,
        [Obsolete("Deprecated in favour of \"Alphatestenable\"")]
        [NativeName("Name", "D3DRS_ALPHATESTENABLE")]
        RSAlphatestenable = 0xF,
        [Obsolete("Deprecated in favour of \"Lastpixel\"")]
        [NativeName("Name", "D3DRS_LASTPIXEL")]
        RSLastpixel = 0x10,
        [Obsolete("Deprecated in favour of \"Srcblend\"")]
        [NativeName("Name", "D3DRS_SRCBLEND")]
        RSSrcblend = 0x13,
        [Obsolete("Deprecated in favour of \"Destblend\"")]
        [NativeName("Name", "D3DRS_DESTBLEND")]
        RSDestblend = 0x14,
        [Obsolete("Deprecated in favour of \"Cullmode\"")]
        [NativeName("Name", "D3DRS_CULLMODE")]
        RSCullmode = 0x16,
        [Obsolete("Deprecated in favour of \"Zfunc\"")]
        [NativeName("Name", "D3DRS_ZFUNC")]
        RSZfunc = 0x17,
        [Obsolete("Deprecated in favour of \"Alpharef\"")]
        [NativeName("Name", "D3DRS_ALPHAREF")]
        RSAlpharef = 0x18,
        [Obsolete("Deprecated in favour of \"Alphafunc\"")]
        [NativeName("Name", "D3DRS_ALPHAFUNC")]
        RSAlphafunc = 0x19,
        [Obsolete("Deprecated in favour of \"Ditherenable\"")]
        [NativeName("Name", "D3DRS_DITHERENABLE")]
        RSDitherenable = 0x1A,
        [Obsolete("Deprecated in favour of \"Alphablendenable\"")]
        [NativeName("Name", "D3DRS_ALPHABLENDENABLE")]
        RSAlphablendenable = 0x1B,
        [Obsolete("Deprecated in favour of \"Fogenable\"")]
        [NativeName("Name", "D3DRS_FOGENABLE")]
        RSFogenable = 0x1C,
        [Obsolete("Deprecated in favour of \"Specularenable\"")]
        [NativeName("Name", "D3DRS_SPECULARENABLE")]
        RSSpecularenable = 0x1D,
        [Obsolete("Deprecated in favour of \"Fogcolor\"")]
        [NativeName("Name", "D3DRS_FOGCOLOR")]
        RSFogcolor = 0x22,
        [Obsolete("Deprecated in favour of \"Fogtablemode\"")]
        [NativeName("Name", "D3DRS_FOGTABLEMODE")]
        RSFogtablemode = 0x23,
        [Obsolete("Deprecated in favour of \"Fogstart\"")]
        [NativeName("Name", "D3DRS_FOGSTART")]
        RSFogstart = 0x24,
        [Obsolete("Deprecated in favour of \"Fogend\"")]
        [NativeName("Name", "D3DRS_FOGEND")]
        RSFogend = 0x25,
        [Obsolete("Deprecated in favour of \"Fogdensity\"")]
        [NativeName("Name", "D3DRS_FOGDENSITY")]
        RSFogdensity = 0x26,
        [Obsolete("Deprecated in favour of \"Rangefogenable\"")]
        [NativeName("Name", "D3DRS_RANGEFOGENABLE")]
        RSRangefogenable = 0x30,
        [Obsolete("Deprecated in favour of \"Stencilenable\"")]
        [NativeName("Name", "D3DRS_STENCILENABLE")]
        RSStencilenable = 0x34,
        [Obsolete("Deprecated in favour of \"Stencilfail\"")]
        [NativeName("Name", "D3DRS_STENCILFAIL")]
        RSStencilfail = 0x35,
        [Obsolete("Deprecated in favour of \"Stencilzfail\"")]
        [NativeName("Name", "D3DRS_STENCILZFAIL")]
        RSStencilzfail = 0x36,
        [Obsolete("Deprecated in favour of \"Stencilpass\"")]
        [NativeName("Name", "D3DRS_STENCILPASS")]
        RSStencilpass = 0x37,
        [Obsolete("Deprecated in favour of \"Stencilfunc\"")]
        [NativeName("Name", "D3DRS_STENCILFUNC")]
        RSStencilfunc = 0x38,
        [Obsolete("Deprecated in favour of \"Stencilref\"")]
        [NativeName("Name", "D3DRS_STENCILREF")]
        RSStencilref = 0x39,
        [Obsolete("Deprecated in favour of \"Stencilmask\"")]
        [NativeName("Name", "D3DRS_STENCILMASK")]
        RSStencilmask = 0x3A,
        [Obsolete("Deprecated in favour of \"Stencilwritemask\"")]
        [NativeName("Name", "D3DRS_STENCILWRITEMASK")]
        RSStencilwritemask = 0x3B,
        [Obsolete("Deprecated in favour of \"Texturefactor\"")]
        [NativeName("Name", "D3DRS_TEXTUREFACTOR")]
        RSTexturefactor = 0x3C,
        [Obsolete("Deprecated in favour of \"Wrap0\"")]
        [NativeName("Name", "D3DRS_WRAP0")]
        RSWrap0 = 0x80,
        [Obsolete("Deprecated in favour of \"Wrap1\"")]
        [NativeName("Name", "D3DRS_WRAP1")]
        RSWrap1 = 0x81,
        [Obsolete("Deprecated in favour of \"Wrap2\"")]
        [NativeName("Name", "D3DRS_WRAP2")]
        RSWrap2 = 0x82,
        [Obsolete("Deprecated in favour of \"Wrap3\"")]
        [NativeName("Name", "D3DRS_WRAP3")]
        RSWrap3 = 0x83,
        [Obsolete("Deprecated in favour of \"Wrap4\"")]
        [NativeName("Name", "D3DRS_WRAP4")]
        RSWrap4 = 0x84,
        [Obsolete("Deprecated in favour of \"Wrap5\"")]
        [NativeName("Name", "D3DRS_WRAP5")]
        RSWrap5 = 0x85,
        [Obsolete("Deprecated in favour of \"Wrap6\"")]
        [NativeName("Name", "D3DRS_WRAP6")]
        RSWrap6 = 0x86,
        [Obsolete("Deprecated in favour of \"Wrap7\"")]
        [NativeName("Name", "D3DRS_WRAP7")]
        RSWrap7 = 0x87,
        [Obsolete("Deprecated in favour of \"Clipping\"")]
        [NativeName("Name", "D3DRS_CLIPPING")]
        RSClipping = 0x88,
        [Obsolete("Deprecated in favour of \"Lighting\"")]
        [NativeName("Name", "D3DRS_LIGHTING")]
        RSLighting = 0x89,
        [Obsolete("Deprecated in favour of \"Ambient\"")]
        [NativeName("Name", "D3DRS_AMBIENT")]
        RSAmbient = 0x8B,
        [Obsolete("Deprecated in favour of \"Fogvertexmode\"")]
        [NativeName("Name", "D3DRS_FOGVERTEXMODE")]
        RSFogvertexmode = 0x8C,
        [Obsolete("Deprecated in favour of \"Colorvertex\"")]
        [NativeName("Name", "D3DRS_COLORVERTEX")]
        RSColorvertex = 0x8D,
        [Obsolete("Deprecated in favour of \"Localviewer\"")]
        [NativeName("Name", "D3DRS_LOCALVIEWER")]
        RSLocalviewer = 0x8E,
        [Obsolete("Deprecated in favour of \"Normalizenormals\"")]
        [NativeName("Name", "D3DRS_NORMALIZENORMALS")]
        RSNormalizenormals = 0x8F,
        [Obsolete("Deprecated in favour of \"Diffusematerialsource\"")]
        [NativeName("Name", "D3DRS_DIFFUSEMATERIALSOURCE")]
        RSDiffusematerialsource = 0x91,
        [Obsolete("Deprecated in favour of \"Specularmaterialsource\"")]
        [NativeName("Name", "D3DRS_SPECULARMATERIALSOURCE")]
        RSSpecularmaterialsource = 0x92,
        [Obsolete("Deprecated in favour of \"Ambientmaterialsource\"")]
        [NativeName("Name", "D3DRS_AMBIENTMATERIALSOURCE")]
        RSAmbientmaterialsource = 0x93,
        [Obsolete("Deprecated in favour of \"Emissivematerialsource\"")]
        [NativeName("Name", "D3DRS_EMISSIVEMATERIALSOURCE")]
        RSEmissivematerialsource = 0x94,
        [Obsolete("Deprecated in favour of \"Vertexblend\"")]
        [NativeName("Name", "D3DRS_VERTEXBLEND")]
        RSVertexblend = 0x97,
        [Obsolete("Deprecated in favour of \"Clipplaneenable\"")]
        [NativeName("Name", "D3DRS_CLIPPLANEENABLE")]
        RSClipplaneenable = 0x98,
        [Obsolete("Deprecated in favour of \"Pointsize\"")]
        [NativeName("Name", "D3DRS_POINTSIZE")]
        RSPointsize = 0x9A,
        [Obsolete("Deprecated in favour of \"PointsizeMin\"")]
        [NativeName("Name", "D3DRS_POINTSIZE_MIN")]
        RSPointsizeMin = 0x9B,
        [Obsolete("Deprecated in favour of \"Pointspriteenable\"")]
        [NativeName("Name", "D3DRS_POINTSPRITEENABLE")]
        RSPointspriteenable = 0x9C,
        [Obsolete("Deprecated in favour of \"Pointscaleenable\"")]
        [NativeName("Name", "D3DRS_POINTSCALEENABLE")]
        RSPointscaleenable = 0x9D,
        [Obsolete("Deprecated in favour of \"PointscaleA\"")]
        [NativeName("Name", "D3DRS_POINTSCALE_A")]
        RSPointscaleA = 0x9E,
        [Obsolete("Deprecated in favour of \"PointscaleB\"")]
        [NativeName("Name", "D3DRS_POINTSCALE_B")]
        RSPointscaleB = 0x9F,
        [Obsolete("Deprecated in favour of \"PointscaleC\"")]
        [NativeName("Name", "D3DRS_POINTSCALE_C")]
        RSPointscaleC = 0xA0,
        [Obsolete("Deprecated in favour of \"Multisampleantialias\"")]
        [NativeName("Name", "D3DRS_MULTISAMPLEANTIALIAS")]
        RSMultisampleantialias = 0xA1,
        [Obsolete("Deprecated in favour of \"Multisamplemask\"")]
        [NativeName("Name", "D3DRS_MULTISAMPLEMASK")]
        RSMultisamplemask = 0xA2,
        [Obsolete("Deprecated in favour of \"Patchedgestyle\"")]
        [NativeName("Name", "D3DRS_PATCHEDGESTYLE")]
        RSPatchedgestyle = 0xA3,
        [Obsolete("Deprecated in favour of \"Debugmonitortoken\"")]
        [NativeName("Name", "D3DRS_DEBUGMONITORTOKEN")]
        RSDebugmonitortoken = 0xA5,
        [Obsolete("Deprecated in favour of \"PointsizeMax\"")]
        [NativeName("Name", "D3DRS_POINTSIZE_MAX")]
        RSPointsizeMax = 0xA6,
        [Obsolete("Deprecated in favour of \"Indexedvertexblendenable\"")]
        [NativeName("Name", "D3DRS_INDEXEDVERTEXBLENDENABLE")]
        RSIndexedvertexblendenable = 0xA7,
        [Obsolete("Deprecated in favour of \"Colorwriteenable\"")]
        [NativeName("Name", "D3DRS_COLORWRITEENABLE")]
        RSColorwriteenable = 0xA8,
        [Obsolete("Deprecated in favour of \"Tweenfactor\"")]
        [NativeName("Name", "D3DRS_TWEENFACTOR")]
        RSTweenfactor = 0xAA,
        [Obsolete("Deprecated in favour of \"Blendop\"")]
        [NativeName("Name", "D3DRS_BLENDOP")]
        RSBlendop = 0xAB,
        [Obsolete("Deprecated in favour of \"Positiondegree\"")]
        [NativeName("Name", "D3DRS_POSITIONDEGREE")]
        RSPositiondegree = 0xAC,
        [Obsolete("Deprecated in favour of \"Normaldegree\"")]
        [NativeName("Name", "D3DRS_NORMALDEGREE")]
        RSNormaldegree = 0xAD,
        [Obsolete("Deprecated in favour of \"Scissortestenable\"")]
        [NativeName("Name", "D3DRS_SCISSORTESTENABLE")]
        RSScissortestenable = 0xAE,
        [Obsolete("Deprecated in favour of \"Slopescaledepthbias\"")]
        [NativeName("Name", "D3DRS_SLOPESCALEDEPTHBIAS")]
        RSSlopescaledepthbias = 0xAF,
        [Obsolete("Deprecated in favour of \"Antialiasedlineenable\"")]
        [NativeName("Name", "D3DRS_ANTIALIASEDLINEENABLE")]
        RSAntialiasedlineenable = 0xB0,
        [Obsolete("Deprecated in favour of \"Mintessellationlevel\"")]
        [NativeName("Name", "D3DRS_MINTESSELLATIONLEVEL")]
        RSMintessellationlevel = 0xB2,
        [Obsolete("Deprecated in favour of \"Maxtessellationlevel\"")]
        [NativeName("Name", "D3DRS_MAXTESSELLATIONLEVEL")]
        RSMaxtessellationlevel = 0xB3,
        [Obsolete("Deprecated in favour of \"AdaptivetessX\"")]
        [NativeName("Name", "D3DRS_ADAPTIVETESS_X")]
        RSAdaptivetessX = 0xB4,
        [Obsolete("Deprecated in favour of \"AdaptivetessY\"")]
        [NativeName("Name", "D3DRS_ADAPTIVETESS_Y")]
        RSAdaptivetessY = 0xB5,
        [Obsolete("Deprecated in favour of \"AdaptivetessZ\"")]
        [NativeName("Name", "D3DRS_ADAPTIVETESS_Z")]
        RSAdaptivetessZ = 0xB6,
        [Obsolete("Deprecated in favour of \"AdaptivetessW\"")]
        [NativeName("Name", "D3DRS_ADAPTIVETESS_W")]
        RSAdaptivetessW = 0xB7,
        [Obsolete("Deprecated in favour of \"Enableadaptivetessellation\"")]
        [NativeName("Name", "D3DRS_ENABLEADAPTIVETESSELLATION")]
        RSEnableadaptivetessellation = 0xB8,
        [Obsolete("Deprecated in favour of \"Twosidedstencilmode\"")]
        [NativeName("Name", "D3DRS_TWOSIDEDSTENCILMODE")]
        RSTwosidedstencilmode = 0xB9,
        [Obsolete("Deprecated in favour of \"CcwStencilfail\"")]
        [NativeName("Name", "D3DRS_CCW_STENCILFAIL")]
        RSCcwStencilfail = 0xBA,
        [Obsolete("Deprecated in favour of \"CcwStencilzfail\"")]
        [NativeName("Name", "D3DRS_CCW_STENCILZFAIL")]
        RSCcwStencilzfail = 0xBB,
        [Obsolete("Deprecated in favour of \"CcwStencilpass\"")]
        [NativeName("Name", "D3DRS_CCW_STENCILPASS")]
        RSCcwStencilpass = 0xBC,
        [Obsolete("Deprecated in favour of \"CcwStencilfunc\"")]
        [NativeName("Name", "D3DRS_CCW_STENCILFUNC")]
        RSCcwStencilfunc = 0xBD,
        [Obsolete("Deprecated in favour of \"Colorwriteenable1\"")]
        [NativeName("Name", "D3DRS_COLORWRITEENABLE1")]
        RSColorwriteenable1 = 0xBE,
        [Obsolete("Deprecated in favour of \"Colorwriteenable2\"")]
        [NativeName("Name", "D3DRS_COLORWRITEENABLE2")]
        RSColorwriteenable2 = 0xBF,
        [Obsolete("Deprecated in favour of \"Colorwriteenable3\"")]
        [NativeName("Name", "D3DRS_COLORWRITEENABLE3")]
        RSColorwriteenable3 = 0xC0,
        [Obsolete("Deprecated in favour of \"Blendfactor\"")]
        [NativeName("Name", "D3DRS_BLENDFACTOR")]
        RSBlendfactor = 0xC1,
        [Obsolete("Deprecated in favour of \"Srgbwriteenable\"")]
        [NativeName("Name", "D3DRS_SRGBWRITEENABLE")]
        RSSrgbwriteenable = 0xC2,
        [Obsolete("Deprecated in favour of \"Depthbias\"")]
        [NativeName("Name", "D3DRS_DEPTHBIAS")]
        RSDepthbias = 0xC3,
        [Obsolete("Deprecated in favour of \"Wrap8\"")]
        [NativeName("Name", "D3DRS_WRAP8")]
        RSWrap8 = 0xC6,
        [Obsolete("Deprecated in favour of \"Wrap9\"")]
        [NativeName("Name", "D3DRS_WRAP9")]
        RSWrap9 = 0xC7,
        [Obsolete("Deprecated in favour of \"Wrap10\"")]
        [NativeName("Name", "D3DRS_WRAP10")]
        RSWrap10 = 0xC8,
        [Obsolete("Deprecated in favour of \"Wrap11\"")]
        [NativeName("Name", "D3DRS_WRAP11")]
        RSWrap11 = 0xC9,
        [Obsolete("Deprecated in favour of \"Wrap12\"")]
        [NativeName("Name", "D3DRS_WRAP12")]
        RSWrap12 = 0xCA,
        [Obsolete("Deprecated in favour of \"Wrap13\"")]
        [NativeName("Name", "D3DRS_WRAP13")]
        RSWrap13 = 0xCB,
        [Obsolete("Deprecated in favour of \"Wrap14\"")]
        [NativeName("Name", "D3DRS_WRAP14")]
        RSWrap14 = 0xCC,
        [Obsolete("Deprecated in favour of \"Wrap15\"")]
        [NativeName("Name", "D3DRS_WRAP15")]
        RSWrap15 = 0xCD,
        [Obsolete("Deprecated in favour of \"Separatealphablendenable\"")]
        [NativeName("Name", "D3DRS_SEPARATEALPHABLENDENABLE")]
        RSSeparatealphablendenable = 0xCE,
        [Obsolete("Deprecated in favour of \"Srcblendalpha\"")]
        [NativeName("Name", "D3DRS_SRCBLENDALPHA")]
        RSSrcblendalpha = 0xCF,
        [Obsolete("Deprecated in favour of \"Destblendalpha\"")]
        [NativeName("Name", "D3DRS_DESTBLENDALPHA")]
        RSDestblendalpha = 0xD0,
        [Obsolete("Deprecated in favour of \"Blendopalpha\"")]
        [NativeName("Name", "D3DRS_BLENDOPALPHA")]
        RSBlendopalpha = 0xD1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DRS_FORCE_DWORD")]
        RSForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DRS_ZENABLE")]
        Zenable = 0x7,
        [NativeName("Name", "D3DRS_FILLMODE")]
        Fillmode = 0x8,
        [NativeName("Name", "D3DRS_SHADEMODE")]
        Shademode = 0x9,
        [NativeName("Name", "D3DRS_ZWRITEENABLE")]
        Zwriteenable = 0xE,
        [NativeName("Name", "D3DRS_ALPHATESTENABLE")]
        Alphatestenable = 0xF,
        [NativeName("Name", "D3DRS_LASTPIXEL")]
        Lastpixel = 0x10,
        [NativeName("Name", "D3DRS_SRCBLEND")]
        Srcblend = 0x13,
        [NativeName("Name", "D3DRS_DESTBLEND")]
        Destblend = 0x14,
        [NativeName("Name", "D3DRS_CULLMODE")]
        Cullmode = 0x16,
        [NativeName("Name", "D3DRS_ZFUNC")]
        Zfunc = 0x17,
        [NativeName("Name", "D3DRS_ALPHAREF")]
        Alpharef = 0x18,
        [NativeName("Name", "D3DRS_ALPHAFUNC")]
        Alphafunc = 0x19,
        [NativeName("Name", "D3DRS_DITHERENABLE")]
        Ditherenable = 0x1A,
        [NativeName("Name", "D3DRS_ALPHABLENDENABLE")]
        Alphablendenable = 0x1B,
        [NativeName("Name", "D3DRS_FOGENABLE")]
        Fogenable = 0x1C,
        [NativeName("Name", "D3DRS_SPECULARENABLE")]
        Specularenable = 0x1D,
        [NativeName("Name", "D3DRS_FOGCOLOR")]
        Fogcolor = 0x22,
        [NativeName("Name", "D3DRS_FOGTABLEMODE")]
        Fogtablemode = 0x23,
        [NativeName("Name", "D3DRS_FOGSTART")]
        Fogstart = 0x24,
        [NativeName("Name", "D3DRS_FOGEND")]
        Fogend = 0x25,
        [NativeName("Name", "D3DRS_FOGDENSITY")]
        Fogdensity = 0x26,
        [NativeName("Name", "D3DRS_RANGEFOGENABLE")]
        Rangefogenable = 0x30,
        [NativeName("Name", "D3DRS_STENCILENABLE")]
        Stencilenable = 0x34,
        [NativeName("Name", "D3DRS_STENCILFAIL")]
        Stencilfail = 0x35,
        [NativeName("Name", "D3DRS_STENCILZFAIL")]
        Stencilzfail = 0x36,
        [NativeName("Name", "D3DRS_STENCILPASS")]
        Stencilpass = 0x37,
        [NativeName("Name", "D3DRS_STENCILFUNC")]
        Stencilfunc = 0x38,
        [NativeName("Name", "D3DRS_STENCILREF")]
        Stencilref = 0x39,
        [NativeName("Name", "D3DRS_STENCILMASK")]
        Stencilmask = 0x3A,
        [NativeName("Name", "D3DRS_STENCILWRITEMASK")]
        Stencilwritemask = 0x3B,
        [NativeName("Name", "D3DRS_TEXTUREFACTOR")]
        Texturefactor = 0x3C,
        [NativeName("Name", "D3DRS_WRAP0")]
        Wrap0 = 0x80,
        [NativeName("Name", "D3DRS_WRAP1")]
        Wrap1 = 0x81,
        [NativeName("Name", "D3DRS_WRAP2")]
        Wrap2 = 0x82,
        [NativeName("Name", "D3DRS_WRAP3")]
        Wrap3 = 0x83,
        [NativeName("Name", "D3DRS_WRAP4")]
        Wrap4 = 0x84,
        [NativeName("Name", "D3DRS_WRAP5")]
        Wrap5 = 0x85,
        [NativeName("Name", "D3DRS_WRAP6")]
        Wrap6 = 0x86,
        [NativeName("Name", "D3DRS_WRAP7")]
        Wrap7 = 0x87,
        [NativeName("Name", "D3DRS_CLIPPING")]
        Clipping = 0x88,
        [NativeName("Name", "D3DRS_LIGHTING")]
        Lighting = 0x89,
        [NativeName("Name", "D3DRS_AMBIENT")]
        Ambient = 0x8B,
        [NativeName("Name", "D3DRS_FOGVERTEXMODE")]
        Fogvertexmode = 0x8C,
        [NativeName("Name", "D3DRS_COLORVERTEX")]
        Colorvertex = 0x8D,
        [NativeName("Name", "D3DRS_LOCALVIEWER")]
        Localviewer = 0x8E,
        [NativeName("Name", "D3DRS_NORMALIZENORMALS")]
        Normalizenormals = 0x8F,
        [NativeName("Name", "D3DRS_DIFFUSEMATERIALSOURCE")]
        Diffusematerialsource = 0x91,
        [NativeName("Name", "D3DRS_SPECULARMATERIALSOURCE")]
        Specularmaterialsource = 0x92,
        [NativeName("Name", "D3DRS_AMBIENTMATERIALSOURCE")]
        Ambientmaterialsource = 0x93,
        [NativeName("Name", "D3DRS_EMISSIVEMATERIALSOURCE")]
        Emissivematerialsource = 0x94,
        [NativeName("Name", "D3DRS_VERTEXBLEND")]
        Vertexblend = 0x97,
        [NativeName("Name", "D3DRS_CLIPPLANEENABLE")]
        Clipplaneenable = 0x98,
        [NativeName("Name", "D3DRS_POINTSIZE")]
        Pointsize = 0x9A,
        [NativeName("Name", "D3DRS_POINTSIZE_MIN")]
        PointsizeMin = 0x9B,
        [NativeName("Name", "D3DRS_POINTSPRITEENABLE")]
        Pointspriteenable = 0x9C,
        [NativeName("Name", "D3DRS_POINTSCALEENABLE")]
        Pointscaleenable = 0x9D,
        [NativeName("Name", "D3DRS_POINTSCALE_A")]
        PointscaleA = 0x9E,
        [NativeName("Name", "D3DRS_POINTSCALE_B")]
        PointscaleB = 0x9F,
        [NativeName("Name", "D3DRS_POINTSCALE_C")]
        PointscaleC = 0xA0,
        [NativeName("Name", "D3DRS_MULTISAMPLEANTIALIAS")]
        Multisampleantialias = 0xA1,
        [NativeName("Name", "D3DRS_MULTISAMPLEMASK")]
        Multisamplemask = 0xA2,
        [NativeName("Name", "D3DRS_PATCHEDGESTYLE")]
        Patchedgestyle = 0xA3,
        [NativeName("Name", "D3DRS_DEBUGMONITORTOKEN")]
        Debugmonitortoken = 0xA5,
        [NativeName("Name", "D3DRS_POINTSIZE_MAX")]
        PointsizeMax = 0xA6,
        [NativeName("Name", "D3DRS_INDEXEDVERTEXBLENDENABLE")]
        Indexedvertexblendenable = 0xA7,
        [NativeName("Name", "D3DRS_COLORWRITEENABLE")]
        Colorwriteenable = 0xA8,
        [NativeName("Name", "D3DRS_TWEENFACTOR")]
        Tweenfactor = 0xAA,
        [NativeName("Name", "D3DRS_BLENDOP")]
        Blendop = 0xAB,
        [NativeName("Name", "D3DRS_POSITIONDEGREE")]
        Positiondegree = 0xAC,
        [NativeName("Name", "D3DRS_NORMALDEGREE")]
        Normaldegree = 0xAD,
        [NativeName("Name", "D3DRS_SCISSORTESTENABLE")]
        Scissortestenable = 0xAE,
        [NativeName("Name", "D3DRS_SLOPESCALEDEPTHBIAS")]
        Slopescaledepthbias = 0xAF,
        [NativeName("Name", "D3DRS_ANTIALIASEDLINEENABLE")]
        Antialiasedlineenable = 0xB0,
        [NativeName("Name", "D3DRS_MINTESSELLATIONLEVEL")]
        Mintessellationlevel = 0xB2,
        [NativeName("Name", "D3DRS_MAXTESSELLATIONLEVEL")]
        Maxtessellationlevel = 0xB3,
        [NativeName("Name", "D3DRS_ADAPTIVETESS_X")]
        AdaptivetessX = 0xB4,
        [NativeName("Name", "D3DRS_ADAPTIVETESS_Y")]
        AdaptivetessY = 0xB5,
        [NativeName("Name", "D3DRS_ADAPTIVETESS_Z")]
        AdaptivetessZ = 0xB6,
        [NativeName("Name", "D3DRS_ADAPTIVETESS_W")]
        AdaptivetessW = 0xB7,
        [NativeName("Name", "D3DRS_ENABLEADAPTIVETESSELLATION")]
        Enableadaptivetessellation = 0xB8,
        [NativeName("Name", "D3DRS_TWOSIDEDSTENCILMODE")]
        Twosidedstencilmode = 0xB9,
        [NativeName("Name", "D3DRS_CCW_STENCILFAIL")]
        CcwStencilfail = 0xBA,
        [NativeName("Name", "D3DRS_CCW_STENCILZFAIL")]
        CcwStencilzfail = 0xBB,
        [NativeName("Name", "D3DRS_CCW_STENCILPASS")]
        CcwStencilpass = 0xBC,
        [NativeName("Name", "D3DRS_CCW_STENCILFUNC")]
        CcwStencilfunc = 0xBD,
        [NativeName("Name", "D3DRS_COLORWRITEENABLE1")]
        Colorwriteenable1 = 0xBE,
        [NativeName("Name", "D3DRS_COLORWRITEENABLE2")]
        Colorwriteenable2 = 0xBF,
        [NativeName("Name", "D3DRS_COLORWRITEENABLE3")]
        Colorwriteenable3 = 0xC0,
        [NativeName("Name", "D3DRS_BLENDFACTOR")]
        Blendfactor = 0xC1,
        [NativeName("Name", "D3DRS_SRGBWRITEENABLE")]
        Srgbwriteenable = 0xC2,
        [NativeName("Name", "D3DRS_DEPTHBIAS")]
        Depthbias = 0xC3,
        [NativeName("Name", "D3DRS_WRAP8")]
        Wrap8 = 0xC6,
        [NativeName("Name", "D3DRS_WRAP9")]
        Wrap9 = 0xC7,
        [NativeName("Name", "D3DRS_WRAP10")]
        Wrap10 = 0xC8,
        [NativeName("Name", "D3DRS_WRAP11")]
        Wrap11 = 0xC9,
        [NativeName("Name", "D3DRS_WRAP12")]
        Wrap12 = 0xCA,
        [NativeName("Name", "D3DRS_WRAP13")]
        Wrap13 = 0xCB,
        [NativeName("Name", "D3DRS_WRAP14")]
        Wrap14 = 0xCC,
        [NativeName("Name", "D3DRS_WRAP15")]
        Wrap15 = 0xCD,
        [NativeName("Name", "D3DRS_SEPARATEALPHABLENDENABLE")]
        Separatealphablendenable = 0xCE,
        [NativeName("Name", "D3DRS_SRCBLENDALPHA")]
        Srcblendalpha = 0xCF,
        [NativeName("Name", "D3DRS_DESTBLENDALPHA")]
        Destblendalpha = 0xD0,
        [NativeName("Name", "D3DRS_BLENDOPALPHA")]
        Blendopalpha = 0xD1,
        [NativeName("Name", "D3DRS_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
