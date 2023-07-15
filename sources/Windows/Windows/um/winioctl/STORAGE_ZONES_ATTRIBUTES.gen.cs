// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_ZONES_ATTRIBUTES.xml' path='doc/member[@name="STORAGE_ZONES_ATTRIBUTES"]/*'/>
public enum STORAGE_ZONES_ATTRIBUTES
{
    /// <include file='STORAGE_ZONES_ATTRIBUTES.xml' path='doc/member[@name="STORAGE_ZONES_ATTRIBUTES.ZonesAttributeTypeAndLengthMayDifferent"]/*'/>
    ZonesAttributeTypeAndLengthMayDifferent = 0,
    /// <include file='STORAGE_ZONES_ATTRIBUTES.xml' path='doc/member[@name="STORAGE_ZONES_ATTRIBUTES.ZonesAttributeTypeSameLengthSame"]/*'/>
    ZonesAttributeTypeSameLengthSame = 1,
    /// <include file='STORAGE_ZONES_ATTRIBUTES.xml' path='doc/member[@name="STORAGE_ZONES_ATTRIBUTES.ZonesAttributeTypeSameLastZoneLengthDifferent"]/*'/>
    ZonesAttributeTypeSameLastZoneLengthDifferent = 2,
    /// <include file='STORAGE_ZONES_ATTRIBUTES.xml' path='doc/member[@name="STORAGE_ZONES_ATTRIBUTES.ZonesAttributeTypeMayDifferentLengthSame"]/*'/>
    ZonesAttributeTypeMayDifferentLengthSame = 3,
}