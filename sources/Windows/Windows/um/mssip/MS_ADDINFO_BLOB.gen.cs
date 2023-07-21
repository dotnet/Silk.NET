// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MS_ADDINFO_BLOB.xml' path='doc/member[@name="MS_ADDINFO_BLOB"]/*' />
public unsafe partial struct MS_ADDINFO_BLOB
{
    /// <include file='MS_ADDINFO_BLOB.xml' path='doc/member[@name="MS_ADDINFO_BLOB.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MS_ADDINFO_BLOB.xml' path='doc/member[@name="MS_ADDINFO_BLOB.cbMemObject"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbMemObject;

    /// <include file='MS_ADDINFO_BLOB.xml' path='doc/member[@name="MS_ADDINFO_BLOB.pbMemObject"]/*' />
    public byte* pbMemObject;

    /// <include file='MS_ADDINFO_BLOB.xml' path='doc/member[@name="MS_ADDINFO_BLOB.cbMemSignedMsg"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbMemSignedMsg;

    /// <include file='MS_ADDINFO_BLOB.xml' path='doc/member[@name="MS_ADDINFO_BLOB.pbMemSignedMsg"]/*' />
    public byte* pbMemSignedMsg;
}
