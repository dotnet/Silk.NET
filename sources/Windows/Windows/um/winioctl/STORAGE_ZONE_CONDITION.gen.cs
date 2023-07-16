// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION"]/*'/>
public enum STORAGE_ZONE_CONDITION
{
    /// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION.ZoneConditionConventional"]/*'/>
    ZoneConditionConventional = 0x00,
    /// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION.ZoneConditionEmpty"]/*'/>
    ZoneConditionEmpty = 0x01,
    /// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION.ZoneConditionImplicitlyOpened"]/*'/>
    ZoneConditionImplicitlyOpened = 0x02,
    /// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION.ZoneConditionExplicitlyOpened"]/*'/>
    ZoneConditionExplicitlyOpened = 0x03,
    /// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION.ZoneConditionClosed"]/*'/>
    ZoneConditionClosed = 0x04,
    /// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION.ZoneConditionReadOnly"]/*'/>
    ZoneConditionReadOnly = 0x0D,
    /// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION.ZoneConditionFull"]/*'/>
    ZoneConditionFull = 0x0E,
    /// <include file='STORAGE_ZONE_CONDITION.xml' path='doc/member[@name="STORAGE_ZONE_CONDITION.ZoneConditionOffline"]/*'/>
    ZoneConditionOffline = 0x0F,
}