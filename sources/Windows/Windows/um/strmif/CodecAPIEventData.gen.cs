// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CodecAPIEventData.xml' path='doc/member[@name="CodecAPIEventData"]/*' />
public unsafe partial struct CodecAPIEventData
{
    /// <include file='CodecAPIEventData.xml' path='doc/member[@name="CodecAPIEventData.guid"]/*' />
    public Guid guid;

    /// <include file='CodecAPIEventData.xml' path='doc/member[@name="CodecAPIEventData.dataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dataLength;

    /// <include file='CodecAPIEventData.xml' path='doc/member[@name="CodecAPIEventData.reserved"]/*' />
    [NativeTypeName("DWORD[3]")]
    public fixed uint reserved[3];
}
