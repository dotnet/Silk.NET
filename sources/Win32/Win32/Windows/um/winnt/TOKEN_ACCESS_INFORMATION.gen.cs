// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct TOKEN_ACCESS_INFORMATION
{
    [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
    public SID_AND_ATTRIBUTES_HASH* SidHash;

    [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
    public SID_AND_ATTRIBUTES_HASH* RestrictedSidHash;

    [NativeTypeName("PTOKEN_PRIVILEGES")]
    public TOKEN_PRIVILEGES* Privileges;
    public LUID AuthenticationId;
    public TOKEN_TYPE TokenType;
    public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;
    public TOKEN_MANDATORY_POLICY MandatoryPolicy;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint AppContainerNumber;

    [NativeTypeName("PSID")]
    public void* PackageSid;

    [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
    public SID_AND_ATTRIBUTES_HASH* CapabilitiesHash;

    [NativeTypeName("PSID")]
    public void* TrustLevelSid;

    [NativeTypeName("PSECURITY_ATTRIBUTES_OPAQUE")]
    public void* SecurityAttributes;
}
