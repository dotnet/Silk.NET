// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSIINSTALLCONTEXT.xml' path='doc/member[@name="MSIINSTALLCONTEXT"]/*'/>
public enum MSIINSTALLCONTEXT
{
    /// <include file='MSIINSTALLCONTEXT.xml' path='doc/member[@name="MSIINSTALLCONTEXT.MSIINSTALLCONTEXT_FIRSTVISIBLE"]/*'/>
    MSIINSTALLCONTEXT_FIRSTVISIBLE = 0,
    /// <include file='MSIINSTALLCONTEXT.xml' path='doc/member[@name="MSIINSTALLCONTEXT.MSIINSTALLCONTEXT_NONE"]/*'/>
    MSIINSTALLCONTEXT_NONE = 0,
    /// <include file='MSIINSTALLCONTEXT.xml' path='doc/member[@name="MSIINSTALLCONTEXT.MSIINSTALLCONTEXT_USERMANAGED"]/*'/>
    MSIINSTALLCONTEXT_USERMANAGED = 1,
    /// <include file='MSIINSTALLCONTEXT.xml' path='doc/member[@name="MSIINSTALLCONTEXT.MSIINSTALLCONTEXT_USERUNMANAGED"]/*'/>
    MSIINSTALLCONTEXT_USERUNMANAGED = 2,
    /// <include file='MSIINSTALLCONTEXT.xml' path='doc/member[@name="MSIINSTALLCONTEXT.MSIINSTALLCONTEXT_MACHINE"]/*'/>
    MSIINSTALLCONTEXT_MACHINE = 4,
    /// <include file='MSIINSTALLCONTEXT.xml' path='doc/member[@name="MSIINSTALLCONTEXT.MSIINSTALLCONTEXT_ALL"]/*'/>
    MSIINSTALLCONTEXT_ALL = (MSIINSTALLCONTEXT_USERMANAGED | MSIINSTALLCONTEXT_USERUNMANAGED | MSIINSTALLCONTEXT_MACHINE),
    /// <include file='MSIINSTALLCONTEXT.xml' path='doc/member[@name="MSIINSTALLCONTEXT.MSIINSTALLCONTEXT_ALLUSERMANAGED"]/*'/>
    MSIINSTALLCONTEXT_ALLUSERMANAGED = 8,
}