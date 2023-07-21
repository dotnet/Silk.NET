// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_BYTE_STREAM_CACHE_RANGE.xml' path='doc/member[@name="MF_BYTE_STREAM_CACHE_RANGE"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct MF_BYTE_STREAM_CACHE_RANGE
{
    /// <include file='MF_BYTE_STREAM_CACHE_RANGE.xml' path='doc/member[@name="MF_BYTE_STREAM_CACHE_RANGE.qwStartOffset"]/*' />
    [NativeTypeName("QWORD")]
    public ulong qwStartOffset;

    /// <include file='MF_BYTE_STREAM_CACHE_RANGE.xml' path='doc/member[@name="MF_BYTE_STREAM_CACHE_RANGE.qwEndOffset"]/*' />
    [NativeTypeName("QWORD")]
    public ulong qwEndOffset;
}
