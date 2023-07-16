// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL"]/*'/>
public enum INSTALLUILEVEL
{
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_NOCHANGE"]/*'/>
    INSTALLUILEVEL_NOCHANGE = 0,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_DEFAULT"]/*'/>
    INSTALLUILEVEL_DEFAULT = 1,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_NONE"]/*'/>
    INSTALLUILEVEL_NONE = 2,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_BASIC"]/*'/>
    INSTALLUILEVEL_BASIC = 3,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_REDUCED"]/*'/>
    INSTALLUILEVEL_REDUCED = 4,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_FULL"]/*'/>
    INSTALLUILEVEL_FULL = 5,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_ENDDIALOG"]/*'/>
    INSTALLUILEVEL_ENDDIALOG = 0x80,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_PROGRESSONLY"]/*'/>
    INSTALLUILEVEL_PROGRESSONLY = 0x40,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_HIDECANCEL"]/*'/>
    INSTALLUILEVEL_HIDECANCEL = 0x20,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_SOURCERESONLY"]/*'/>
    INSTALLUILEVEL_SOURCERESONLY = 0x100,
    /// <include file='INSTALLUILEVEL.xml' path='doc/member[@name="INSTALLUILEVEL.INSTALLUILEVEL_UACONLY"]/*'/>
    INSTALLUILEVEL_UACONLY = 0x200,
}