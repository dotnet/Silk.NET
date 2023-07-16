// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_CRYPTO_KEY_SIZE.xml' path='doc/member[@name="STORAGE_CRYPTO_KEY_SIZE"]/*'/>
public enum STORAGE_CRYPTO_KEY_SIZE
{
    /// <include file='STORAGE_CRYPTO_KEY_SIZE.xml' path='doc/member[@name="STORAGE_CRYPTO_KEY_SIZE.StorageCryptoKeySizeUnknown"]/*'/>
    StorageCryptoKeySizeUnknown = 0,
    /// <include file='STORAGE_CRYPTO_KEY_SIZE.xml' path='doc/member[@name="STORAGE_CRYPTO_KEY_SIZE.StorageCryptoKeySize128Bits"]/*'/>
    StorageCryptoKeySize128Bits = 1,
    /// <include file='STORAGE_CRYPTO_KEY_SIZE.xml' path='doc/member[@name="STORAGE_CRYPTO_KEY_SIZE.StorageCryptoKeySize192Bits"]/*'/>
    StorageCryptoKeySize192Bits,
    /// <include file='STORAGE_CRYPTO_KEY_SIZE.xml' path='doc/member[@name="STORAGE_CRYPTO_KEY_SIZE.StorageCryptoKeySize256Bits"]/*'/>
    StorageCryptoKeySize256Bits,
    /// <include file='STORAGE_CRYPTO_KEY_SIZE.xml' path='doc/member[@name="STORAGE_CRYPTO_KEY_SIZE.StorageCryptoKeySize512Bits"]/*'/>
    StorageCryptoKeySize512Bits,
}