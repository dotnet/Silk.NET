// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='URLZONEREG.xml' path='doc/member[@name="URLZONEREG"]/*'/>
public enum URLZONEREG
{
    /// <include file='URLZONEREG.xml' path='doc/member[@name="URLZONEREG.URLZONEREG_DEFAULT"]/*'/>
    URLZONEREG_DEFAULT = 0,
    /// <include file='URLZONEREG.xml' path='doc/member[@name="URLZONEREG.URLZONEREG_HKLM"]/*'/>
    URLZONEREG_HKLM = (URLZONEREG_DEFAULT + 1),
    /// <include file='URLZONEREG.xml' path='doc/member[@name="URLZONEREG.URLZONEREG_HKCU"]/*'/>
    URLZONEREG_HKCU = (URLZONEREG_HKLM + 1),
}