// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct TOKEN_LOGGING_INFORMATION
{
    public TOKEN_TYPE TokenType;
    public TOKEN_ELEVATION TokenElevation;
    public TOKEN_ELEVATION_TYPE TokenElevationType;
    public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

    [NativeTypeName("DWORD")]
    public uint IntegrityLevel;
    public SID_AND_ATTRIBUTES User;

    [NativeTypeName("PSID")]
    public void* TrustLevelSid;

    [NativeTypeName("DWORD")]
    public uint SessionId;

    [NativeTypeName("DWORD")]
    public uint AppContainerNumber;
    public LUID AuthenticationId;

    [NativeTypeName("DWORD")]
    public uint GroupCount;

    [NativeTypeName("DWORD")]
    public uint GroupsLength;

    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* Groups;
}
