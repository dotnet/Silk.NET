// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GENERIC3CHANNEL.xml' path='doc/member[@name="GENERIC3CHANNEL"]/*' />
public partial struct GENERIC3CHANNEL
{
    /// <include file='GENERIC3CHANNEL.xml' path='doc/member[@name="GENERIC3CHANNEL.ch1"]/*' />
    [NativeTypeName("WORD")]
    public ushort ch1;

    /// <include file='GENERIC3CHANNEL.xml' path='doc/member[@name="GENERIC3CHANNEL.ch2"]/*' />
    [NativeTypeName("WORD")]
    public ushort ch2;

    /// <include file='GENERIC3CHANNEL.xml' path='doc/member[@name="GENERIC3CHANNEL.ch3"]/*' />
    [NativeTypeName("WORD")]
    public ushort ch3;
}
