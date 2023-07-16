// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="FILE_STORAGE_TIER_MEDIA_TYPE"]/*'/>
public enum FILE_STORAGE_TIER_MEDIA_TYPE
{
    /// <include file='FILE_STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="FILE_STORAGE_TIER_MEDIA_TYPE.FileStorageTierMediaTypeUnspecified"]/*'/>
    FileStorageTierMediaTypeUnspecified = 0,
    /// <include file='FILE_STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="FILE_STORAGE_TIER_MEDIA_TYPE.FileStorageTierMediaTypeDisk"]/*'/>
    FileStorageTierMediaTypeDisk = 1,
    /// <include file='FILE_STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="FILE_STORAGE_TIER_MEDIA_TYPE.FileStorageTierMediaTypeSsd"]/*'/>
    FileStorageTierMediaTypeSsd = 2,
    /// <include file='FILE_STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="FILE_STORAGE_TIER_MEDIA_TYPE.FileStorageTierMediaTypeScm"]/*'/>
    FileStorageTierMediaTypeScm = 4,
    /// <include file='FILE_STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="FILE_STORAGE_TIER_MEDIA_TYPE.FileStorageTierMediaTypeMax"]/*'/>
    FileStorageTierMediaTypeMax,
}