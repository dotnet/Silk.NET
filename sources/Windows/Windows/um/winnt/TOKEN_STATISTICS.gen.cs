// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS"]/*' />
public partial struct TOKEN_STATISTICS
{
    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.TokenId"]/*' />
    public LUID TokenId;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.AuthenticationId"]/*' />
    public LUID AuthenticationId;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.ExpirationTime"]/*' />
    public LARGE_INTEGER ExpirationTime;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.TokenType"]/*' />
    public TOKEN_TYPE TokenType;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.ImpersonationLevel"]/*' />
    public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.DynamicCharged"]/*' />
    [NativeTypeName("DWORD")]
    public uint DynamicCharged;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.DynamicAvailable"]/*' />
    [NativeTypeName("DWORD")]
    public uint DynamicAvailable;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.GroupCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint GroupCount;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.PrivilegeCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint PrivilegeCount;

    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.ModifiedId"]/*' />
    public LUID ModifiedId;
}
