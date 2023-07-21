// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SIP_INDIRECT_DATA.xml' path='doc/member[@name="SIP_INDIRECT_DATA"]/*' />
public partial struct SIP_INDIRECT_DATA
{
    /// <include file='SIP_INDIRECT_DATA.xml' path='doc/member[@name="SIP_INDIRECT_DATA.Data"]/*' />
    public CRYPT_ATTRIBUTE_TYPE_VALUE Data;

    /// <include file='SIP_INDIRECT_DATA.xml' path='doc/member[@name="SIP_INDIRECT_DATA.DigestAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER DigestAlgorithm;

    /// <include file='SIP_INDIRECT_DATA.xml' path='doc/member[@name="SIP_INDIRECT_DATA.Digest"]/*' />
    [NativeTypeName("CRYPT_HASH_BLOB")]
    public CRYPT_DATA_BLOB Digest;
}
