// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CMC_TAGGED_CONTENT_INFO.xml' path='doc/member[@name="CMC_TAGGED_CONTENT_INFO"]/*' />
public partial struct CMC_TAGGED_CONTENT_INFO
{
    /// <include file='CMC_TAGGED_CONTENT_INFO.xml' path='doc/member[@name="CMC_TAGGED_CONTENT_INFO.dwBodyPartID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBodyPartID;

    /// <include file='CMC_TAGGED_CONTENT_INFO.xml' path='doc/member[@name="CMC_TAGGED_CONTENT_INFO.EncodedContentInfo"]/*' />
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB EncodedContentInfo;
}
