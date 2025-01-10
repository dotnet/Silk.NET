// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TOKEN_STATISTICS
{
    public LUID TokenId;
    public LUID AuthenticationId;
    public LARGE_INTEGER ExpirationTime;
    public TOKEN_TYPE TokenType;
    public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

    [NativeTypeName("DWORD")]
    public uint DynamicCharged;

    [NativeTypeName("DWORD")]
    public uint DynamicAvailable;

    [NativeTypeName("DWORD")]
    public uint GroupCount;

    [NativeTypeName("DWORD")]
    public uint PrivilegeCount;
    public LUID ModifiedId;
}
