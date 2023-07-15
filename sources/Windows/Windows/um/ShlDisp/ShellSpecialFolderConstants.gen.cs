// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants"]/*'/>
public enum ShellSpecialFolderConstants
{
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfDESKTOP"]/*'/>
    ssfDESKTOP = 0,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfPROGRAMS"]/*'/>
    ssfPROGRAMS = 0x2,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCONTROLS"]/*'/>
    ssfCONTROLS = 0x3,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfPRINTERS"]/*'/>
    ssfPRINTERS = 0x4,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfPERSONAL"]/*'/>
    ssfPERSONAL = 0x5,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfFAVORITES"]/*'/>
    ssfFAVORITES = 0x6,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfSTARTUP"]/*'/>
    ssfSTARTUP = 0x7,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfRECENT"]/*'/>
    ssfRECENT = 0x8,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfSENDTO"]/*'/>
    ssfSENDTO = 0x9,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfBITBUCKET"]/*'/>
    ssfBITBUCKET = 0xa,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfSTARTMENU"]/*'/>
    ssfSTARTMENU = 0xb,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfDESKTOPDIRECTORY"]/*'/>
    ssfDESKTOPDIRECTORY = 0x10,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfDRIVES"]/*'/>
    ssfDRIVES = 0x11,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfNETWORK"]/*'/>
    ssfNETWORK = 0x12,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfNETHOOD"]/*'/>
    ssfNETHOOD = 0x13,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfFONTS"]/*'/>
    ssfFONTS = 0x14,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfTEMPLATES"]/*'/>
    ssfTEMPLATES = 0x15,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCOMMONSTARTMENU"]/*'/>
    ssfCOMMONSTARTMENU = 0x16,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCOMMONPROGRAMS"]/*'/>
    ssfCOMMONPROGRAMS = 0x17,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCOMMONSTARTUP"]/*'/>
    ssfCOMMONSTARTUP = 0x18,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCOMMONDESKTOPDIR"]/*'/>
    ssfCOMMONDESKTOPDIR = 0x19,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfAPPDATA"]/*'/>
    ssfAPPDATA = 0x1a,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfPRINTHOOD"]/*'/>
    ssfPRINTHOOD = 0x1b,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfLOCALAPPDATA"]/*'/>
    ssfLOCALAPPDATA = 0x1c,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfALTSTARTUP"]/*'/>
    ssfALTSTARTUP = 0x1d,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCOMMONALTSTARTUP"]/*'/>
    ssfCOMMONALTSTARTUP = 0x1e,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCOMMONFAVORITES"]/*'/>
    ssfCOMMONFAVORITES = 0x1f,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfINTERNETCACHE"]/*'/>
    ssfINTERNETCACHE = 0x20,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCOOKIES"]/*'/>
    ssfCOOKIES = 0x21,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfHISTORY"]/*'/>
    ssfHISTORY = 0x22,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfCOMMONAPPDATA"]/*'/>
    ssfCOMMONAPPDATA = 0x23,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfWINDOWS"]/*'/>
    ssfWINDOWS = 0x24,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfSYSTEM"]/*'/>
    ssfSYSTEM = 0x25,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfPROGRAMFILES"]/*'/>
    ssfPROGRAMFILES = 0x26,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfMYPICTURES"]/*'/>
    ssfMYPICTURES = 0x27,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfPROFILE"]/*'/>
    ssfPROFILE = 0x28,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfSYSTEMx86"]/*'/>
    ssfSYSTEMx86 = 0x29,
    /// <include file='ShellSpecialFolderConstants.xml' path='doc/member[@name="ShellSpecialFolderConstants.ssfPROGRAMFILESx86"]/*'/>
    ssfPROGRAMFILESx86 = 0x30,
}