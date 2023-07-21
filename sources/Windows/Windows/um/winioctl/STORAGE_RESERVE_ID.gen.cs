// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_RESERVE_ID.xml' path='doc/member[@name="STORAGE_RESERVE_ID"]/*' />
public enum STORAGE_RESERVE_ID
{
    /// <include file='STORAGE_RESERVE_ID.xml' path='doc/member[@name="STORAGE_RESERVE_ID.StorageReserveIdNone"]/*' />
    StorageReserveIdNone = 0,

    /// <include file='STORAGE_RESERVE_ID.xml' path='doc/member[@name="STORAGE_RESERVE_ID.StorageReserveIdHard"]/*' />
    StorageReserveIdHard,

    /// <include file='STORAGE_RESERVE_ID.xml' path='doc/member[@name="STORAGE_RESERVE_ID.StorageReserveIdSoft"]/*' />
    StorageReserveIdSoft,

    /// <include file='STORAGE_RESERVE_ID.xml' path='doc/member[@name="STORAGE_RESERVE_ID.StorageReserveIdUpdateScratch"]/*' />
    StorageReserveIdUpdateScratch,

    /// <include file='STORAGE_RESERVE_ID.xml' path='doc/member[@name="STORAGE_RESERVE_ID.StorageReserveIdMax"]/*' />
    StorageReserveIdMax,
}
