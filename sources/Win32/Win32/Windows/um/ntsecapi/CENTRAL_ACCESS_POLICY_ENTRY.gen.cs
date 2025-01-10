// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CENTRAL_ACCESS_POLICY_ENTRY
{
    public LSA_UNICODE_STRING Name;
    public LSA_UNICODE_STRING Description;
    public LSA_UNICODE_STRING ChangeId;

    [NativeTypeName("ULONG")]
    public uint LengthAppliesTo;

    [NativeTypeName("PUCHAR")]
    public byte* AppliesTo;

    [NativeTypeName("ULONG")]
    public uint LengthSD;

    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* SD;

    [NativeTypeName("ULONG")]
    public uint LengthStagedSD;

    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* StagedSD;

    [NativeTypeName("ULONG")]
    public uint Flags;
}
