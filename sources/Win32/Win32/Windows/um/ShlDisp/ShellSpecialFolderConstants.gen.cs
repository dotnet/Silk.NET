// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ShellSpecialFolderConstants
{
    ssfDESKTOP = 0,
    ssfPROGRAMS = 0x2,
    ssfCONTROLS = 0x3,
    ssfPRINTERS = 0x4,
    ssfPERSONAL = 0x5,
    ssfFAVORITES = 0x6,
    ssfSTARTUP = 0x7,
    ssfRECENT = 0x8,
    ssfSENDTO = 0x9,
    ssfBITBUCKET = 0xa,
    ssfSTARTMENU = 0xb,
    ssfDESKTOPDIRECTORY = 0x10,
    ssfDRIVES = 0x11,
    ssfNETWORK = 0x12,
    ssfNETHOOD = 0x13,
    ssfFONTS = 0x14,
    ssfTEMPLATES = 0x15,
    ssfCOMMONSTARTMENU = 0x16,
    ssfCOMMONPROGRAMS = 0x17,
    ssfCOMMONSTARTUP = 0x18,
    ssfCOMMONDESKTOPDIR = 0x19,
    ssfAPPDATA = 0x1a,
    ssfPRINTHOOD = 0x1b,
    ssfLOCALAPPDATA = 0x1c,
    ssfALTSTARTUP = 0x1d,
    ssfCOMMONALTSTARTUP = 0x1e,
    ssfCOMMONFAVORITES = 0x1f,
    ssfINTERNETCACHE = 0x20,
    ssfCOOKIES = 0x21,
    ssfHISTORY = 0x22,
    ssfCOMMONAPPDATA = 0x23,
    ssfWINDOWS = 0x24,
    ssfSYSTEM = 0x25,
    ssfPROGRAMFILES = 0x26,
    ssfMYPICTURES = 0x27,
    ssfPROFILE = 0x28,
    ssfSYSTEMx86 = 0x29,
    ssfPROGRAMFILESx86 = 0x30,
}
