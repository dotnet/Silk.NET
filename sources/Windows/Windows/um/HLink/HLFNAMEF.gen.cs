// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HLFNAMEF.xml' path='doc/member[@name="HLFNAMEF"]/*'/>
public enum HLFNAMEF
{
    /// <include file='HLFNAMEF.xml' path='doc/member[@name="HLFNAMEF.HLFNAMEF_DEFAULT"]/*'/>
    HLFNAMEF_DEFAULT = 0,
    /// <include file='HLFNAMEF.xml' path='doc/member[@name="HLFNAMEF.HLFNAMEF_TRYCACHE"]/*'/>
    HLFNAMEF_TRYCACHE = 0x1,
    /// <include file='HLFNAMEF.xml' path='doc/member[@name="HLFNAMEF.HLFNAMEF_TRYPRETTYTARGET"]/*'/>
    HLFNAMEF_TRYPRETTYTARGET = 0x2,
    /// <include file='HLFNAMEF.xml' path='doc/member[@name="HLFNAMEF.HLFNAMEF_TRYFULLTARGET"]/*'/>
    HLFNAMEF_TRYFULLTARGET = 0x4,
    /// <include file='HLFNAMEF.xml' path='doc/member[@name="HLFNAMEF.HLFNAMEF_TRYWIN95SHORTCUT"]/*'/>
    HLFNAMEF_TRYWIN95SHORTCUT = 0x8,
}