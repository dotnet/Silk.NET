// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='INSTALLLEVEL.xml' path='doc/member[@name="INSTALLLEVEL"]/*'/>
public enum INSTALLLEVEL
{
    /// <include file='INSTALLLEVEL.xml' path='doc/member[@name="INSTALLLEVEL.INSTALLLEVEL_DEFAULT"]/*'/>
    INSTALLLEVEL_DEFAULT = 0,
    /// <include file='INSTALLLEVEL.xml' path='doc/member[@name="INSTALLLEVEL.INSTALLLEVEL_MINIMUM"]/*'/>
    INSTALLLEVEL_MINIMUM = 1,
    /// <include file='INSTALLLEVEL.xml' path='doc/member[@name="INSTALLLEVEL.INSTALLLEVEL_MAXIMUM"]/*'/>
    INSTALLLEVEL_MAXIMUM = 0xFFFF,
}