// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPC_INDIRECT_DATA_CONTENT.xml' path='doc/member[@name="SPC_INDIRECT_DATA_CONTENT"]/*'/>
public partial struct SPC_INDIRECT_DATA_CONTENT
{
    /// <include file='SPC_INDIRECT_DATA_CONTENT.xml' path='doc/member[@name="SPC_INDIRECT_DATA_CONTENT.Data"]/*'/>
    public CRYPT_ATTRIBUTE_TYPE_VALUE Data;
    /// <include file='SPC_INDIRECT_DATA_CONTENT.xml' path='doc/member[@name="SPC_INDIRECT_DATA_CONTENT.DigestAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER DigestAlgorithm;
    /// <include file='SPC_INDIRECT_DATA_CONTENT.xml' path='doc/member[@name="SPC_INDIRECT_DATA_CONTENT.Digest"]/*'/>
    [NativeTypeName("CRYPT_HASH_BLOB")]
    public CRYPT_DATA_BLOB Digest;
}