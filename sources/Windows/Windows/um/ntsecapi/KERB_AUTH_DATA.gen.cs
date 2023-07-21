// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KERB_AUTH_DATA.xml' path='doc/member[@name="KERB_AUTH_DATA"]/*' />
public unsafe partial struct KERB_AUTH_DATA
{
    /// <include file='KERB_AUTH_DATA.xml' path='doc/member[@name="KERB_AUTH_DATA.Type"]/*' />
    [NativeTypeName("ULONG")]
    public uint Type;

    /// <include file='KERB_AUTH_DATA.xml' path='doc/member[@name="KERB_AUTH_DATA.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='KERB_AUTH_DATA.xml' path='doc/member[@name="KERB_AUTH_DATA.Data"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* Data;
}
