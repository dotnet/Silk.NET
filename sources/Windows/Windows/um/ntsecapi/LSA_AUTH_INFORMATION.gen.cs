// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LSA_AUTH_INFORMATION.xml' path='doc/member[@name="LSA_AUTH_INFORMATION"]/*' />
public unsafe partial struct LSA_AUTH_INFORMATION
{
    /// <include file='LSA_AUTH_INFORMATION.xml' path='doc/member[@name="LSA_AUTH_INFORMATION.LastUpdateTime"]/*' />
    public LARGE_INTEGER LastUpdateTime;

    /// <include file='LSA_AUTH_INFORMATION.xml' path='doc/member[@name="LSA_AUTH_INFORMATION.AuthType"]/*' />
    [NativeTypeName("ULONG")]
    public uint AuthType;

    /// <include file='LSA_AUTH_INFORMATION.xml' path='doc/member[@name="LSA_AUTH_INFORMATION.AuthInfoLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint AuthInfoLength;

    /// <include file='LSA_AUTH_INFORMATION.xml' path='doc/member[@name="LSA_AUTH_INFORMATION.AuthInfo"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* AuthInfo;
}
