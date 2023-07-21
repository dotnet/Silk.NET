// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_LEAKY_BUCKET_PAIR.xml' path='doc/member[@name="MF_LEAKY_BUCKET_PAIR"]/*' />
public partial struct MF_LEAKY_BUCKET_PAIR
{
    /// <include file='MF_LEAKY_BUCKET_PAIR.xml' path='doc/member[@name="MF_LEAKY_BUCKET_PAIR.dwBitrate"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBitrate;

    /// <include file='MF_LEAKY_BUCKET_PAIR.xml' path='doc/member[@name="MF_LEAKY_BUCKET_PAIR.msBufferWindow"]/*' />
    [NativeTypeName("DWORD")]
    public uint msBufferWindow;
}
