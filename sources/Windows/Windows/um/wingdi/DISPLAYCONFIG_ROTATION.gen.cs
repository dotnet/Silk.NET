// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION"]/*'/>
public enum DISPLAYCONFIG_ROTATION
{
    /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_IDENTITY"]/*'/>
    DISPLAYCONFIG_ROTATION_IDENTITY = 1,
    /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_ROTATE90"]/*'/>
    DISPLAYCONFIG_ROTATION_ROTATE90 = 2,
    /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_ROTATE180"]/*'/>
    DISPLAYCONFIG_ROTATION_ROTATE180 = 3,
    /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_ROTATE270"]/*'/>
    DISPLAYCONFIG_ROTATION_ROTATE270 = 4,
    /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_FORCE_UINT32"]/*'/>
    DISPLAYCONFIG_ROTATION_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}