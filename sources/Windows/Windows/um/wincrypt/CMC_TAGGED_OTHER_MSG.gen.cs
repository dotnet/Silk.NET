// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CMC_TAGGED_OTHER_MSG.xml' path='doc/member[@name="CMC_TAGGED_OTHER_MSG"]/*' />
public unsafe partial struct CMC_TAGGED_OTHER_MSG
{
    /// <include file='CMC_TAGGED_OTHER_MSG.xml' path='doc/member[@name="CMC_TAGGED_OTHER_MSG.dwBodyPartID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBodyPartID;

    /// <include file='CMC_TAGGED_OTHER_MSG.xml' path='doc/member[@name="CMC_TAGGED_OTHER_MSG.pszObjId"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;

    /// <include file='CMC_TAGGED_OTHER_MSG.xml' path='doc/member[@name="CMC_TAGGED_OTHER_MSG.Value"]/*' />
    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Value;
}
