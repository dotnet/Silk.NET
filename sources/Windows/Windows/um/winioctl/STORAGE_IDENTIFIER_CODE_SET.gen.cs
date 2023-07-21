// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_IDENTIFIER_CODE_SET.xml' path='doc/member[@name="STORAGE_IDENTIFIER_CODE_SET"]/*' />
public enum STORAGE_IDENTIFIER_CODE_SET
{
    /// <include file='STORAGE_IDENTIFIER_CODE_SET.xml' path='doc/member[@name="STORAGE_IDENTIFIER_CODE_SET.StorageIdCodeSetReserved"]/*' />
    StorageIdCodeSetReserved = 0,

    /// <include file='STORAGE_IDENTIFIER_CODE_SET.xml' path='doc/member[@name="STORAGE_IDENTIFIER_CODE_SET.StorageIdCodeSetBinary"]/*' />
    StorageIdCodeSetBinary = 1,

    /// <include file='STORAGE_IDENTIFIER_CODE_SET.xml' path='doc/member[@name="STORAGE_IDENTIFIER_CODE_SET.StorageIdCodeSetAscii"]/*' />
    StorageIdCodeSetAscii = 2,

    /// <include file='STORAGE_IDENTIFIER_CODE_SET.xml' path='doc/member[@name="STORAGE_IDENTIFIER_CODE_SET.StorageIdCodeSetUtf8"]/*' />
    StorageIdCodeSetUtf8 = 3,
}
