// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PctPublicKey.xml' path='doc/member[@name="PctPublicKey"]/*' />
public unsafe partial struct PctPublicKey
{
    /// <include file='PctPublicKey.xml' path='doc/member[@name="PctPublicKey.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='PctPublicKey.xml' path='doc/member[@name="PctPublicKey.cbKey"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbKey;

    /// <include file='PctPublicKey.xml' path='doc/member[@name="PctPublicKey.pKey"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public fixed byte pKey[1];
}
