// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_INSTRUCTION_OPCODE_TYPE")]
    public enum ShaderInstructionOpcodeType : int
    {
        [NativeName("Name", "D3DSIO_NOP")]
        SioNop = 0x0,
        [NativeName("Name", "D3DSIO_MOV")]
        SioMov = 0x1,
        [NativeName("Name", "D3DSIO_ADD")]
        SioAdd = 0x2,
        [NativeName("Name", "D3DSIO_SUB")]
        SioSub = 0x3,
        [NativeName("Name", "D3DSIO_MAD")]
        SioMad = 0x4,
        [NativeName("Name", "D3DSIO_MUL")]
        SioMul = 0x5,
        [NativeName("Name", "D3DSIO_RCP")]
        SioRcp = 0x6,
        [NativeName("Name", "D3DSIO_RSQ")]
        SioRsq = 0x7,
        [NativeName("Name", "D3DSIO_DP3")]
        SioDP3 = 0x8,
        [NativeName("Name", "D3DSIO_DP4")]
        SioDP4 = 0x9,
        [NativeName("Name", "D3DSIO_MIN")]
        SioMin = 0xA,
        [NativeName("Name", "D3DSIO_MAX")]
        SioMax = 0xB,
        [NativeName("Name", "D3DSIO_SLT")]
        SioSlt = 0xC,
        [NativeName("Name", "D3DSIO_SGE")]
        SioSge = 0xD,
        [NativeName("Name", "D3DSIO_EXP")]
        SioExp = 0xE,
        [NativeName("Name", "D3DSIO_LOG")]
        SioLog = 0xF,
        [NativeName("Name", "D3DSIO_LIT")]
        SioLit = 0x10,
        [NativeName("Name", "D3DSIO_DST")]
        SioDst = 0x11,
        [NativeName("Name", "D3DSIO_LRP")]
        SioLrp = 0x12,
        [NativeName("Name", "D3DSIO_FRC")]
        SioFrc = 0x13,
        [NativeName("Name", "D3DSIO_M4x4")]
        SioM4x4 = 0x14,
        [NativeName("Name", "D3DSIO_M4x3")]
        SioM4x3 = 0x15,
        [NativeName("Name", "D3DSIO_M3x4")]
        SioM3x4 = 0x16,
        [NativeName("Name", "D3DSIO_M3x3")]
        SioM3x3 = 0x17,
        [NativeName("Name", "D3DSIO_M3x2")]
        SioM3x2 = 0x18,
        [NativeName("Name", "D3DSIO_CALL")]
        SioCall = 0x19,
        [NativeName("Name", "D3DSIO_CALLNZ")]
        SioCallnz = 0x1A,
        [NativeName("Name", "D3DSIO_LOOP")]
        SioLoop = 0x1B,
        [NativeName("Name", "D3DSIO_RET")]
        SioRet = 0x1C,
        [NativeName("Name", "D3DSIO_ENDLOOP")]
        SioEndloop = 0x1D,
        [NativeName("Name", "D3DSIO_LABEL")]
        SioLabel = 0x1E,
        [NativeName("Name", "D3DSIO_DCL")]
        SioDcl = 0x1F,
        [NativeName("Name", "D3DSIO_POW")]
        SioPow = 0x20,
        [NativeName("Name", "D3DSIO_CRS")]
        SioCrs = 0x21,
        [NativeName("Name", "D3DSIO_SGN")]
        SioSgn = 0x22,
        [NativeName("Name", "D3DSIO_ABS")]
        SioAbs = 0x23,
        [NativeName("Name", "D3DSIO_NRM")]
        SioNrm = 0x24,
        [NativeName("Name", "D3DSIO_SINCOS")]
        SioSincos = 0x25,
        [NativeName("Name", "D3DSIO_REP")]
        SioRep = 0x26,
        [NativeName("Name", "D3DSIO_ENDREP")]
        SioEndrep = 0x27,
        [NativeName("Name", "D3DSIO_IF")]
        SioIF = 0x28,
        [NativeName("Name", "D3DSIO_IFC")]
        SioIfc = 0x29,
        [NativeName("Name", "D3DSIO_ELSE")]
        SioElse = 0x2A,
        [NativeName("Name", "D3DSIO_ENDIF")]
        SioEndif = 0x2B,
        [NativeName("Name", "D3DSIO_BREAK")]
        SioBreak = 0x2C,
        [NativeName("Name", "D3DSIO_BREAKC")]
        SioBreakc = 0x2D,
        [NativeName("Name", "D3DSIO_MOVA")]
        SioMova = 0x2E,
        [NativeName("Name", "D3DSIO_DEFB")]
        SioDefb = 0x2F,
        [NativeName("Name", "D3DSIO_DEFI")]
        SioDefi = 0x30,
        [NativeName("Name", "D3DSIO_TEXCOORD")]
        SioTexcoord = 0x40,
        [NativeName("Name", "D3DSIO_TEXKILL")]
        SioTexkill = 0x41,
        [NativeName("Name", "D3DSIO_TEX")]
        SioTex = 0x42,
        [NativeName("Name", "D3DSIO_TEXBEM")]
        SioTexbem = 0x43,
        [NativeName("Name", "D3DSIO_TEXBEML")]
        SioTexbeml = 0x44,
        [NativeName("Name", "D3DSIO_TEXREG2AR")]
        SioTexreg2AR = 0x45,
        [NativeName("Name", "D3DSIO_TEXREG2GB")]
        SioTexreg2GB = 0x46,
        [NativeName("Name", "D3DSIO_TEXM3x2PAD")]
        SioTexm3x2Pad = 0x47,
        [NativeName("Name", "D3DSIO_TEXM3x2TEX")]
        SioTexm3x2Tex = 0x48,
        [NativeName("Name", "D3DSIO_TEXM3x3PAD")]
        SioTexm3x3Pad = 0x49,
        [NativeName("Name", "D3DSIO_TEXM3x3TEX")]
        SioTexm3x3Tex = 0x4A,
        [NativeName("Name", "D3DSIO_RESERVED0")]
        SioReserved0 = 0x4B,
        [NativeName("Name", "D3DSIO_TEXM3x3SPEC")]
        SioTexm3x3Spec = 0x4C,
        [NativeName("Name", "D3DSIO_TEXM3x3VSPEC")]
        SioTexm3x3Vspec = 0x4D,
        [NativeName("Name", "D3DSIO_EXPP")]
        SioExpp = 0x4E,
        [NativeName("Name", "D3DSIO_LOGP")]
        SioLogp = 0x4F,
        [NativeName("Name", "D3DSIO_CND")]
        SioCnd = 0x50,
        [NativeName("Name", "D3DSIO_DEF")]
        SioDef = 0x51,
        [NativeName("Name", "D3DSIO_TEXREG2RGB")]
        SioTexreg2Rgb = 0x52,
        [NativeName("Name", "D3DSIO_TEXDP3TEX")]
        SioTexdp3Tex = 0x53,
        [NativeName("Name", "D3DSIO_TEXM3x2DEPTH")]
        SioTexm3x2Depth = 0x54,
        [NativeName("Name", "D3DSIO_TEXDP3")]
        SioTexdp3 = 0x55,
        [NativeName("Name", "D3DSIO_TEXM3x3")]
        SioTexm3x3 = 0x56,
        [NativeName("Name", "D3DSIO_TEXDEPTH")]
        SioTexdepth = 0x57,
        [NativeName("Name", "D3DSIO_CMP")]
        SioCmp = 0x58,
        [NativeName("Name", "D3DSIO_BEM")]
        SioBem = 0x59,
        [NativeName("Name", "D3DSIO_DP2ADD")]
        SioDP2Add = 0x5A,
        [NativeName("Name", "D3DSIO_DSX")]
        SioDsx = 0x5B,
        [NativeName("Name", "D3DSIO_DSY")]
        SioDsy = 0x5C,
        [NativeName("Name", "D3DSIO_TEXLDD")]
        SioTexldd = 0x5D,
        [NativeName("Name", "D3DSIO_SETP")]
        SioSetp = 0x5E,
        [NativeName("Name", "D3DSIO_TEXLDL")]
        SioTexldl = 0x5F,
        [NativeName("Name", "D3DSIO_BREAKP")]
        SioBreakp = 0x60,
        [NativeName("Name", "D3DSIO_PHASE")]
        SioPhase = 0xFFFD,
        [NativeName("Name", "D3DSIO_COMMENT")]
        SioComment = 0xFFFE,
        [NativeName("Name", "D3DSIO_END")]
        SioEnd = 0xFFFF,
        [NativeName("Name", "D3DSIO_FORCE_DWORD")]
        SioForceDword = 0x7FFFFFFF,
    }
}
