// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_ZONE_TYPES.xml' path='doc/member[@name="STORAGE_ZONE_TYPES"]/*'/>
public enum STORAGE_ZONE_TYPES
{
    /// <include file='STORAGE_ZONE_TYPES.xml' path='doc/member[@name="STORAGE_ZONE_TYPES.ZoneTypeUnknown"]/*'/>
    ZoneTypeUnknown = 0,
    /// <include file='STORAGE_ZONE_TYPES.xml' path='doc/member[@name="STORAGE_ZONE_TYPES.ZoneTypeConventional"]/*'/>
    ZoneTypeConventional = 1,
    /// <include file='STORAGE_ZONE_TYPES.xml' path='doc/member[@name="STORAGE_ZONE_TYPES.ZoneTypeSequentialWriteRequired"]/*'/>
    ZoneTypeSequentialWriteRequired = 2,
    /// <include file='STORAGE_ZONE_TYPES.xml' path='doc/member[@name="STORAGE_ZONE_TYPES.ZoneTypeSequentialWritePreferred"]/*'/>
    ZoneTypeSequentialWritePreferred = 3,
    /// <include file='STORAGE_ZONE_TYPES.xml' path='doc/member[@name="STORAGE_ZONE_TYPES.ZoneTypeMax"]/*'/>
    ZoneTypeMax,
}