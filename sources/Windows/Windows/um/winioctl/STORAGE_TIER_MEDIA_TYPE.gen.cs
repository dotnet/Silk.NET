// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_TIER_MEDIA_TYPE"]/*' />
public enum STORAGE_TIER_MEDIA_TYPE
{
    /// <include file='STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_TIER_MEDIA_TYPE.StorageTierMediaTypeUnspecified"]/*' />
    StorageTierMediaTypeUnspecified = 0,

    /// <include file='STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_TIER_MEDIA_TYPE.StorageTierMediaTypeDisk"]/*' />
    StorageTierMediaTypeDisk = 1,

    /// <include file='STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_TIER_MEDIA_TYPE.StorageTierMediaTypeSsd"]/*' />
    StorageTierMediaTypeSsd = 2,

    /// <include file='STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_TIER_MEDIA_TYPE.StorageTierMediaTypeScm"]/*' />
    StorageTierMediaTypeScm = 4,

    /// <include file='STORAGE_TIER_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_TIER_MEDIA_TYPE.StorageTierMediaTypeMax"]/*' />
    StorageTierMediaTypeMax,
}
