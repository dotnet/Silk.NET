// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_CRYPTO_ALGORITHM_ID.xml' path='doc/member[@name="STORAGE_CRYPTO_ALGORITHM_ID"]/*'/>
public enum STORAGE_CRYPTO_ALGORITHM_ID
{
    /// <include file='STORAGE_CRYPTO_ALGORITHM_ID.xml' path='doc/member[@name="STORAGE_CRYPTO_ALGORITHM_ID.StorageCryptoAlgorithmUnknown"]/*'/>
    StorageCryptoAlgorithmUnknown = 0,
    /// <include file='STORAGE_CRYPTO_ALGORITHM_ID.xml' path='doc/member[@name="STORAGE_CRYPTO_ALGORITHM_ID.StorageCryptoAlgorithmXTSAES"]/*'/>
    StorageCryptoAlgorithmXTSAES = 1,
    /// <include file='STORAGE_CRYPTO_ALGORITHM_ID.xml' path='doc/member[@name="STORAGE_CRYPTO_ALGORITHM_ID.StorageCryptoAlgorithmBitlockerAESCBC"]/*'/>
    StorageCryptoAlgorithmBitlockerAESCBC,
    /// <include file='STORAGE_CRYPTO_ALGORITHM_ID.xml' path='doc/member[@name="STORAGE_CRYPTO_ALGORITHM_ID.StorageCryptoAlgorithmAESECB"]/*'/>
    StorageCryptoAlgorithmAESECB,
    /// <include file='STORAGE_CRYPTO_ALGORITHM_ID.xml' path='doc/member[@name="STORAGE_CRYPTO_ALGORITHM_ID.StorageCryptoAlgorithmESSIVAESCBC"]/*'/>
    StorageCryptoAlgorithmESSIVAESCBC,
    /// <include file='STORAGE_CRYPTO_ALGORITHM_ID.xml' path='doc/member[@name="STORAGE_CRYPTO_ALGORITHM_ID.StorageCryptoAlgorithmMax"]/*'/>
    StorageCryptoAlgorithmMax,
}