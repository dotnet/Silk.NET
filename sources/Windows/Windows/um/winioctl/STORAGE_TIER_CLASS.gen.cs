// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_TIER_CLASS.xml' path='doc/member[@name="STORAGE_TIER_CLASS"]/*'/>
public enum STORAGE_TIER_CLASS
{
    /// <include file='STORAGE_TIER_CLASS.xml' path='doc/member[@name="STORAGE_TIER_CLASS.StorageTierClassUnspecified"]/*'/>
    StorageTierClassUnspecified = 0,
    /// <include file='STORAGE_TIER_CLASS.xml' path='doc/member[@name="STORAGE_TIER_CLASS.StorageTierClassCapacity"]/*'/>
    StorageTierClassCapacity,
    /// <include file='STORAGE_TIER_CLASS.xml' path='doc/member[@name="STORAGE_TIER_CLASS.StorageTierClassPerformance"]/*'/>
    StorageTierClassPerformance,
    /// <include file='STORAGE_TIER_CLASS.xml' path='doc/member[@name="STORAGE_TIER_CLASS.StorageTierClassMax"]/*'/>
    StorageTierClassMax,
}