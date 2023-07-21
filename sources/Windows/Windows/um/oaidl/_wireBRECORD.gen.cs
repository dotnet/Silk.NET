// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='_wireBRECORD.xml' path='doc/member[@name="_wireBRECORD"]/*' />
public unsafe partial struct _wireBRECORD
{
    /// <include file='_wireBRECORD.xml' path='doc/member[@name="_wireBRECORD.fFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint fFlags;

    /// <include file='_wireBRECORD.xml' path='doc/member[@name="_wireBRECORD.clSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint clSize;

    /// <include file='_wireBRECORD.xml' path='doc/member[@name="_wireBRECORD.pRecInfo"]/*' />
    public IRecordInfo* pRecInfo;

    /// <include file='_wireBRECORD.xml' path='doc/member[@name="_wireBRECORD.pRecord"]/*' />
    public byte* pRecord;
}
