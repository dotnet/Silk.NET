// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_STORAGE_TIER_CLASS.xml' path='doc/member[@name="FILE_STORAGE_TIER_CLASS"]/*'/>
public enum FILE_STORAGE_TIER_CLASS
{
    /// <include file='FILE_STORAGE_TIER_CLASS.xml' path='doc/member[@name="FILE_STORAGE_TIER_CLASS.FileStorageTierClassUnspecified"]/*'/>
    FileStorageTierClassUnspecified = 0,
    /// <include file='FILE_STORAGE_TIER_CLASS.xml' path='doc/member[@name="FILE_STORAGE_TIER_CLASS.FileStorageTierClassCapacity"]/*'/>
    FileStorageTierClassCapacity,
    /// <include file='FILE_STORAGE_TIER_CLASS.xml' path='doc/member[@name="FILE_STORAGE_TIER_CLASS.FileStorageTierClassPerformance"]/*'/>
    FileStorageTierClassPerformance,
    /// <include file='FILE_STORAGE_TIER_CLASS.xml' path='doc/member[@name="FILE_STORAGE_TIER_CLASS.FileStorageTierClassMax"]/*'/>
    FileStorageTierClassMax,
}