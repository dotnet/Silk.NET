// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_INSTRUCTION_OPCODE_TYPE")]
    public enum ShaderInstructionOpcodeType : int
    {
        [Obsolete("Deprecated in favour of \"Nop\"")]
        [NativeName("Name", "D3DSIO_NOP")]
        SioNop = 0x0,
        [Obsolete("Deprecated in favour of \"Mov\"")]
        [NativeName("Name", "D3DSIO_MOV")]
        SioMov = 0x1,
        [Obsolete("Deprecated in favour of \"Add\"")]
        [NativeName("Name", "D3DSIO_ADD")]
        SioAdd = 0x2,
        [Obsolete("Deprecated in favour of \"Sub\"")]
        [NativeName("Name", "D3DSIO_SUB")]
        SioSub = 0x3,
        [Obsolete("Deprecated in favour of \"Mad\"")]
        [NativeName("Name", "D3DSIO_MAD")]
        SioMad = 0x4,
        [Obsolete("Deprecated in favour of \"Mul\"")]
        [NativeName("Name", "D3DSIO_MUL")]
        SioMul = 0x5,
        [Obsolete("Deprecated in favour of \"Rcp\"")]
        [NativeName("Name", "D3DSIO_RCP")]
        SioRcp = 0x6,
        [Obsolete("Deprecated in favour of \"Rsq\"")]
        [NativeName("Name", "D3DSIO_RSQ")]
        SioRsq = 0x7,
        [Obsolete("Deprecated in favour of \"DP3\"")]
        [NativeName("Name", "D3DSIO_DP3")]
        SioDP3 = 0x8,
        [Obsolete("Deprecated in favour of \"DP4\"")]
        [NativeName("Name", "D3DSIO_DP4")]
        SioDP4 = 0x9,
        [Obsolete("Deprecated in favour of \"Min\"")]
        [NativeName("Name", "D3DSIO_MIN")]
        SioMin = 0xA,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "D3DSIO_MAX")]
        SioMax = 0xB,
        [Obsolete("Deprecated in favour of \"Slt\"")]
        [NativeName("Name", "D3DSIO_SLT")]
        SioSlt = 0xC,
        [Obsolete("Deprecated in favour of \"Sge\"")]
        [NativeName("Name", "D3DSIO_SGE")]
        SioSge = 0xD,
        [Obsolete("Deprecated in favour of \"Exp\"")]
        [NativeName("Name", "D3DSIO_EXP")]
        SioExp = 0xE,
        [Obsolete("Deprecated in favour of \"Log\"")]
        [NativeName("Name", "D3DSIO_LOG")]
        SioLog = 0xF,
        [Obsolete("Deprecated in favour of \"Lit\"")]
        [NativeName("Name", "D3DSIO_LIT")]
        SioLit = 0x10,
        [Obsolete("Deprecated in favour of \"Dst\"")]
        [NativeName("Name", "D3DSIO_DST")]
        SioDst = 0x11,
        [Obsolete("Deprecated in favour of \"Lrp\"")]
        [NativeName("Name", "D3DSIO_LRP")]
        SioLrp = 0x12,
        [Obsolete("Deprecated in favour of \"Frc\"")]
        [NativeName("Name", "D3DSIO_FRC")]
        SioFrc = 0x13,
        [Obsolete("Deprecated in favour of \"M4x4\"")]
        [NativeName("Name", "D3DSIO_M4x4")]
        SioM4x4 = 0x14,
        [Obsolete("Deprecated in favour of \"M4x3\"")]
        [NativeName("Name", "D3DSIO_M4x3")]
        SioM4x3 = 0x15,
        [Obsolete("Deprecated in favour of \"M3x4\"")]
        [NativeName("Name", "D3DSIO_M3x4")]
        SioM3x4 = 0x16,
        [Obsolete("Deprecated in favour of \"M3x3\"")]
        [NativeName("Name", "D3DSIO_M3x3")]
        SioM3x3 = 0x17,
        [Obsolete("Deprecated in favour of \"M3x2\"")]
        [NativeName("Name", "D3DSIO_M3x2")]
        SioM3x2 = 0x18,
        [Obsolete("Deprecated in favour of \"Call\"")]
        [NativeName("Name", "D3DSIO_CALL")]
        SioCall = 0x19,
        [Obsolete("Deprecated in favour of \"Callnz\"")]
        [NativeName("Name", "D3DSIO_CALLNZ")]
        SioCallnz = 0x1A,
        [Obsolete("Deprecated in favour of \"Loop\"")]
        [NativeName("Name", "D3DSIO_LOOP")]
        SioLoop = 0x1B,
        [Obsolete("Deprecated in favour of \"Ret\"")]
        [NativeName("Name", "D3DSIO_RET")]
        SioRet = 0x1C,
        [Obsolete("Deprecated in favour of \"Endloop\"")]
        [NativeName("Name", "D3DSIO_ENDLOOP")]
        SioEndloop = 0x1D,
        [Obsolete("Deprecated in favour of \"Label\"")]
        [NativeName("Name", "D3DSIO_LABEL")]
        SioLabel = 0x1E,
        [Obsolete("Deprecated in favour of \"Dcl\"")]
        [NativeName("Name", "D3DSIO_DCL")]
        SioDcl = 0x1F,
        [Obsolete("Deprecated in favour of \"Pow\"")]
        [NativeName("Name", "D3DSIO_POW")]
        SioPow = 0x20,
        [Obsolete("Deprecated in favour of \"Crs\"")]
        [NativeName("Name", "D3DSIO_CRS")]
        SioCrs = 0x21,
        [Obsolete("Deprecated in favour of \"Sgn\"")]
        [NativeName("Name", "D3DSIO_SGN")]
        SioSgn = 0x22,
        [Obsolete("Deprecated in favour of \"Abs\"")]
        [NativeName("Name", "D3DSIO_ABS")]
        SioAbs = 0x23,
        [Obsolete("Deprecated in favour of \"Nrm\"")]
        [NativeName("Name", "D3DSIO_NRM")]
        SioNrm = 0x24,
        [Obsolete("Deprecated in favour of \"Sincos\"")]
        [NativeName("Name", "D3DSIO_SINCOS")]
        SioSincos = 0x25,
        [Obsolete("Deprecated in favour of \"Rep\"")]
        [NativeName("Name", "D3DSIO_REP")]
        SioRep = 0x26,
        [Obsolete("Deprecated in favour of \"Endrep\"")]
        [NativeName("Name", "D3DSIO_ENDREP")]
        SioEndrep = 0x27,
        [Obsolete("Deprecated in favour of \"IF\"")]
        [NativeName("Name", "D3DSIO_IF")]
        SioIF = 0x28,
        [Obsolete("Deprecated in favour of \"Ifc\"")]
        [NativeName("Name", "D3DSIO_IFC")]
        SioIfc = 0x29,
        [Obsolete("Deprecated in favour of \"Else\"")]
        [NativeName("Name", "D3DSIO_ELSE")]
        SioElse = 0x2A,
        [Obsolete("Deprecated in favour of \"Endif\"")]
        [NativeName("Name", "D3DSIO_ENDIF")]
        SioEndif = 0x2B,
        [Obsolete("Deprecated in favour of \"Break\"")]
        [NativeName("Name", "D3DSIO_BREAK")]
        SioBreak = 0x2C,
        [Obsolete("Deprecated in favour of \"Breakc\"")]
        [NativeName("Name", "D3DSIO_BREAKC")]
        SioBreakc = 0x2D,
        [Obsolete("Deprecated in favour of \"Mova\"")]
        [NativeName("Name", "D3DSIO_MOVA")]
        SioMova = 0x2E,
        [Obsolete("Deprecated in favour of \"Defb\"")]
        [NativeName("Name", "D3DSIO_DEFB")]
        SioDefb = 0x2F,
        [Obsolete("Deprecated in favour of \"Defi\"")]
        [NativeName("Name", "D3DSIO_DEFI")]
        SioDefi = 0x30,
        [Obsolete("Deprecated in favour of \"Texcoord\"")]
        [NativeName("Name", "D3DSIO_TEXCOORD")]
        SioTexcoord = 0x40,
        [Obsolete("Deprecated in favour of \"Texkill\"")]
        [NativeName("Name", "D3DSIO_TEXKILL")]
        SioTexkill = 0x41,
        [Obsolete("Deprecated in favour of \"Tex\"")]
        [NativeName("Name", "D3DSIO_TEX")]
        SioTex = 0x42,
        [Obsolete("Deprecated in favour of \"Texbem\"")]
        [NativeName("Name", "D3DSIO_TEXBEM")]
        SioTexbem = 0x43,
        [Obsolete("Deprecated in favour of \"Texbeml\"")]
        [NativeName("Name", "D3DSIO_TEXBEML")]
        SioTexbeml = 0x44,
        [Obsolete("Deprecated in favour of \"Texreg2AR\"")]
        [NativeName("Name", "D3DSIO_TEXREG2AR")]
        SioTexreg2AR = 0x45,
        [Obsolete("Deprecated in favour of \"Texreg2GB\"")]
        [NativeName("Name", "D3DSIO_TEXREG2GB")]
        SioTexreg2GB = 0x46,
        [Obsolete("Deprecated in favour of \"Texm3x2Pad\"")]
        [NativeName("Name", "D3DSIO_TEXM3x2PAD")]
        SioTexm3x2Pad = 0x47,
        [Obsolete("Deprecated in favour of \"Texm3x2Tex\"")]
        [NativeName("Name", "D3DSIO_TEXM3x2TEX")]
        SioTexm3x2Tex = 0x48,
        [Obsolete("Deprecated in favour of \"Texm3x3Pad\"")]
        [NativeName("Name", "D3DSIO_TEXM3x3PAD")]
        SioTexm3x3Pad = 0x49,
        [Obsolete("Deprecated in favour of \"Texm3x3Tex\"")]
        [NativeName("Name", "D3DSIO_TEXM3x3TEX")]
        SioTexm3x3Tex = 0x4A,
        [Obsolete("Deprecated in favour of \"Reserved0\"")]
        [NativeName("Name", "D3DSIO_RESERVED0")]
        SioReserved0 = 0x4B,
        [Obsolete("Deprecated in favour of \"Texm3x3Spec\"")]
        [NativeName("Name", "D3DSIO_TEXM3x3SPEC")]
        SioTexm3x3Spec = 0x4C,
        [Obsolete("Deprecated in favour of \"Texm3x3Vspec\"")]
        [NativeName("Name", "D3DSIO_TEXM3x3VSPEC")]
        SioTexm3x3Vspec = 0x4D,
        [Obsolete("Deprecated in favour of \"Expp\"")]
        [NativeName("Name", "D3DSIO_EXPP")]
        SioExpp = 0x4E,
        [Obsolete("Deprecated in favour of \"Logp\"")]
        [NativeName("Name", "D3DSIO_LOGP")]
        SioLogp = 0x4F,
        [Obsolete("Deprecated in favour of \"Cnd\"")]
        [NativeName("Name", "D3DSIO_CND")]
        SioCnd = 0x50,
        [Obsolete("Deprecated in favour of \"Def\"")]
        [NativeName("Name", "D3DSIO_DEF")]
        SioDef = 0x51,
        [Obsolete("Deprecated in favour of \"Texreg2Rgb\"")]
        [NativeName("Name", "D3DSIO_TEXREG2RGB")]
        SioTexreg2Rgb = 0x52,
        [Obsolete("Deprecated in favour of \"Texdp3Tex\"")]
        [NativeName("Name", "D3DSIO_TEXDP3TEX")]
        SioTexdp3Tex = 0x53,
        [Obsolete("Deprecated in favour of \"Texm3x2Depth\"")]
        [NativeName("Name", "D3DSIO_TEXM3x2DEPTH")]
        SioTexm3x2Depth = 0x54,
        [Obsolete("Deprecated in favour of \"Texdp3\"")]
        [NativeName("Name", "D3DSIO_TEXDP3")]
        SioTexdp3 = 0x55,
        [Obsolete("Deprecated in favour of \"Texm3x3\"")]
        [NativeName("Name", "D3DSIO_TEXM3x3")]
        SioTexm3x3 = 0x56,
        [Obsolete("Deprecated in favour of \"Texdepth\"")]
        [NativeName("Name", "D3DSIO_TEXDEPTH")]
        SioTexdepth = 0x57,
        [Obsolete("Deprecated in favour of \"Cmp\"")]
        [NativeName("Name", "D3DSIO_CMP")]
        SioCmp = 0x58,
        [Obsolete("Deprecated in favour of \"Bem\"")]
        [NativeName("Name", "D3DSIO_BEM")]
        SioBem = 0x59,
        [Obsolete("Deprecated in favour of \"DP2Add\"")]
        [NativeName("Name", "D3DSIO_DP2ADD")]
        SioDP2Add = 0x5A,
        [Obsolete("Deprecated in favour of \"Dsx\"")]
        [NativeName("Name", "D3DSIO_DSX")]
        SioDsx = 0x5B,
        [Obsolete("Deprecated in favour of \"Dsy\"")]
        [NativeName("Name", "D3DSIO_DSY")]
        SioDsy = 0x5C,
        [Obsolete("Deprecated in favour of \"Texldd\"")]
        [NativeName("Name", "D3DSIO_TEXLDD")]
        SioTexldd = 0x5D,
        [Obsolete("Deprecated in favour of \"Setp\"")]
        [NativeName("Name", "D3DSIO_SETP")]
        SioSetp = 0x5E,
        [Obsolete("Deprecated in favour of \"Texldl\"")]
        [NativeName("Name", "D3DSIO_TEXLDL")]
        SioTexldl = 0x5F,
        [Obsolete("Deprecated in favour of \"Breakp\"")]
        [NativeName("Name", "D3DSIO_BREAKP")]
        SioBreakp = 0x60,
        [Obsolete("Deprecated in favour of \"Phase\"")]
        [NativeName("Name", "D3DSIO_PHASE")]
        SioPhase = 0xFFFD,
        [Obsolete("Deprecated in favour of \"Comment\"")]
        [NativeName("Name", "D3DSIO_COMMENT")]
        SioComment = 0xFFFE,
        [Obsolete("Deprecated in favour of \"End\"")]
        [NativeName("Name", "D3DSIO_END")]
        SioEnd = 0xFFFF,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSIO_FORCE_DWORD")]
        SioForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSIO_NOP")]
        Nop = 0x0,
        [NativeName("Name", "D3DSIO_MOV")]
        Mov = 0x1,
        [NativeName("Name", "D3DSIO_ADD")]
        Add = 0x2,
        [NativeName("Name", "D3DSIO_SUB")]
        Sub = 0x3,
        [NativeName("Name", "D3DSIO_MAD")]
        Mad = 0x4,
        [NativeName("Name", "D3DSIO_MUL")]
        Mul = 0x5,
        [NativeName("Name", "D3DSIO_RCP")]
        Rcp = 0x6,
        [NativeName("Name", "D3DSIO_RSQ")]
        Rsq = 0x7,
        [NativeName("Name", "D3DSIO_DP3")]
        DP3 = 0x8,
        [NativeName("Name", "D3DSIO_DP4")]
        DP4 = 0x9,
        [NativeName("Name", "D3DSIO_MIN")]
        Min = 0xA,
        [NativeName("Name", "D3DSIO_MAX")]
        Max = 0xB,
        [NativeName("Name", "D3DSIO_SLT")]
        Slt = 0xC,
        [NativeName("Name", "D3DSIO_SGE")]
        Sge = 0xD,
        [NativeName("Name", "D3DSIO_EXP")]
        Exp = 0xE,
        [NativeName("Name", "D3DSIO_LOG")]
        Log = 0xF,
        [NativeName("Name", "D3DSIO_LIT")]
        Lit = 0x10,
        [NativeName("Name", "D3DSIO_DST")]
        Dst = 0x11,
        [NativeName("Name", "D3DSIO_LRP")]
        Lrp = 0x12,
        [NativeName("Name", "D3DSIO_FRC")]
        Frc = 0x13,
        [NativeName("Name", "D3DSIO_M4x4")]
        M4x4 = 0x14,
        [NativeName("Name", "D3DSIO_M4x3")]
        M4x3 = 0x15,
        [NativeName("Name", "D3DSIO_M3x4")]
        M3x4 = 0x16,
        [NativeName("Name", "D3DSIO_M3x3")]
        M3x3 = 0x17,
        [NativeName("Name", "D3DSIO_M3x2")]
        M3x2 = 0x18,
        [NativeName("Name", "D3DSIO_CALL")]
        Call = 0x19,
        [NativeName("Name", "D3DSIO_CALLNZ")]
        Callnz = 0x1A,
        [NativeName("Name", "D3DSIO_LOOP")]
        Loop = 0x1B,
        [NativeName("Name", "D3DSIO_RET")]
        Ret = 0x1C,
        [NativeName("Name", "D3DSIO_ENDLOOP")]
        Endloop = 0x1D,
        [NativeName("Name", "D3DSIO_LABEL")]
        Label = 0x1E,
        [NativeName("Name", "D3DSIO_DCL")]
        Dcl = 0x1F,
        [NativeName("Name", "D3DSIO_POW")]
        Pow = 0x20,
        [NativeName("Name", "D3DSIO_CRS")]
        Crs = 0x21,
        [NativeName("Name", "D3DSIO_SGN")]
        Sgn = 0x22,
        [NativeName("Name", "D3DSIO_ABS")]
        Abs = 0x23,
        [NativeName("Name", "D3DSIO_NRM")]
        Nrm = 0x24,
        [NativeName("Name", "D3DSIO_SINCOS")]
        Sincos = 0x25,
        [NativeName("Name", "D3DSIO_REP")]
        Rep = 0x26,
        [NativeName("Name", "D3DSIO_ENDREP")]
        Endrep = 0x27,
        [NativeName("Name", "D3DSIO_IF")]
        IF = 0x28,
        [NativeName("Name", "D3DSIO_IFC")]
        Ifc = 0x29,
        [NativeName("Name", "D3DSIO_ELSE")]
        Else = 0x2A,
        [NativeName("Name", "D3DSIO_ENDIF")]
        Endif = 0x2B,
        [NativeName("Name", "D3DSIO_BREAK")]
        Break = 0x2C,
        [NativeName("Name", "D3DSIO_BREAKC")]
        Breakc = 0x2D,
        [NativeName("Name", "D3DSIO_MOVA")]
        Mova = 0x2E,
        [NativeName("Name", "D3DSIO_DEFB")]
        Defb = 0x2F,
        [NativeName("Name", "D3DSIO_DEFI")]
        Defi = 0x30,
        [NativeName("Name", "D3DSIO_TEXCOORD")]
        Texcoord = 0x40,
        [NativeName("Name", "D3DSIO_TEXKILL")]
        Texkill = 0x41,
        [NativeName("Name", "D3DSIO_TEX")]
        Tex = 0x42,
        [NativeName("Name", "D3DSIO_TEXBEM")]
        Texbem = 0x43,
        [NativeName("Name", "D3DSIO_TEXBEML")]
        Texbeml = 0x44,
        [NativeName("Name", "D3DSIO_TEXREG2AR")]
        Texreg2AR = 0x45,
        [NativeName("Name", "D3DSIO_TEXREG2GB")]
        Texreg2GB = 0x46,
        [NativeName("Name", "D3DSIO_TEXM3x2PAD")]
        Texm3x2Pad = 0x47,
        [NativeName("Name", "D3DSIO_TEXM3x2TEX")]
        Texm3x2Tex = 0x48,
        [NativeName("Name", "D3DSIO_TEXM3x3PAD")]
        Texm3x3Pad = 0x49,
        [NativeName("Name", "D3DSIO_TEXM3x3TEX")]
        Texm3x3Tex = 0x4A,
        [NativeName("Name", "D3DSIO_RESERVED0")]
        Reserved0 = 0x4B,
        [NativeName("Name", "D3DSIO_TEXM3x3SPEC")]
        Texm3x3Spec = 0x4C,
        [NativeName("Name", "D3DSIO_TEXM3x3VSPEC")]
        Texm3x3Vspec = 0x4D,
        [NativeName("Name", "D3DSIO_EXPP")]
        Expp = 0x4E,
        [NativeName("Name", "D3DSIO_LOGP")]
        Logp = 0x4F,
        [NativeName("Name", "D3DSIO_CND")]
        Cnd = 0x50,
        [NativeName("Name", "D3DSIO_DEF")]
        Def = 0x51,
        [NativeName("Name", "D3DSIO_TEXREG2RGB")]
        Texreg2Rgb = 0x52,
        [NativeName("Name", "D3DSIO_TEXDP3TEX")]
        Texdp3Tex = 0x53,
        [NativeName("Name", "D3DSIO_TEXM3x2DEPTH")]
        Texm3x2Depth = 0x54,
        [NativeName("Name", "D3DSIO_TEXDP3")]
        Texdp3 = 0x55,
        [NativeName("Name", "D3DSIO_TEXM3x3")]
        Texm3x3 = 0x56,
        [NativeName("Name", "D3DSIO_TEXDEPTH")]
        Texdepth = 0x57,
        [NativeName("Name", "D3DSIO_CMP")]
        Cmp = 0x58,
        [NativeName("Name", "D3DSIO_BEM")]
        Bem = 0x59,
        [NativeName("Name", "D3DSIO_DP2ADD")]
        DP2Add = 0x5A,
        [NativeName("Name", "D3DSIO_DSX")]
        Dsx = 0x5B,
        [NativeName("Name", "D3DSIO_DSY")]
        Dsy = 0x5C,
        [NativeName("Name", "D3DSIO_TEXLDD")]
        Texldd = 0x5D,
        [NativeName("Name", "D3DSIO_SETP")]
        Setp = 0x5E,
        [NativeName("Name", "D3DSIO_TEXLDL")]
        Texldl = 0x5F,
        [NativeName("Name", "D3DSIO_BREAKP")]
        Breakp = 0x60,
        [NativeName("Name", "D3DSIO_PHASE")]
        Phase = 0xFFFD,
        [NativeName("Name", "D3DSIO_COMMENT")]
        Comment = 0xFFFE,
        [NativeName("Name", "D3DSIO_END")]
        End = 0xFFFF,
        [NativeName("Name", "D3DSIO_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
