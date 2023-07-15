// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SIGDN.xml' path='doc/member[@name="SIGDN"]/*'/>
public enum SIGDN
{
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_NORMALDISPLAY"]/*'/>
    SIGDN_NORMALDISPLAY = 0,
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_PARENTRELATIVEPARSING"]/*'/>
    SIGDN_PARENTRELATIVEPARSING = unchecked((int)(0x80018001)),
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_DESKTOPABSOLUTEPARSING"]/*'/>
    SIGDN_DESKTOPABSOLUTEPARSING = unchecked((int)(0x80028000)),
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_PARENTRELATIVEEDITING"]/*'/>
    SIGDN_PARENTRELATIVEEDITING = unchecked((int)(0x80031001)),
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_DESKTOPABSOLUTEEDITING"]/*'/>
    SIGDN_DESKTOPABSOLUTEEDITING = unchecked((int)(0x8004c000)),
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_FILESYSPATH"]/*'/>
    SIGDN_FILESYSPATH = unchecked((int)(0x80058000)),
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_URL"]/*'/>
    SIGDN_URL = unchecked((int)(0x80068000)),
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_PARENTRELATIVEFORADDRESSBAR"]/*'/>
    SIGDN_PARENTRELATIVEFORADDRESSBAR = unchecked((int)(0x8007c001)),
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_PARENTRELATIVE"]/*'/>
    SIGDN_PARENTRELATIVE = unchecked((int)(0x80080001)),
    /// <include file='SIGDN.xml' path='doc/member[@name="SIGDN.SIGDN_PARENTRELATIVEFORUI"]/*'/>
    SIGDN_PARENTRELATIVEFORUI = unchecked((int)(0x80094001)),
}