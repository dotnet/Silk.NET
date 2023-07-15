// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_BLOB_ARRAY.xml' path='doc/member[@name="CRYPT_BLOB_ARRAY"]/*'/>
public unsafe partial struct CRYPT_BLOB_ARRAY
{
    /// <include file='CRYPT_BLOB_ARRAY.xml' path='doc/member[@name="CRYPT_BLOB_ARRAY.cBlob"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cBlob;
    /// <include file='CRYPT_BLOB_ARRAY.xml' path='doc/member[@name="CRYPT_BLOB_ARRAY.rgBlob"]/*'/>
    [NativeTypeName("PCRYPT_DATA_BLOB")]
    public CRYPT_DATA_BLOB* rgBlob;
}