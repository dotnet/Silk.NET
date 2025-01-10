// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CREDENTIAL_TARGET_INFORMATIONW
{
    [NativeTypeName("LPWSTR")]
    public ushort* TargetName;

    [NativeTypeName("LPWSTR")]
    public ushort* NetbiosServerName;

    [NativeTypeName("LPWSTR")]
    public ushort* DnsServerName;

    [NativeTypeName("LPWSTR")]
    public ushort* NetbiosDomainName;

    [NativeTypeName("LPWSTR")]
    public ushort* DnsDomainName;

    [NativeTypeName("LPWSTR")]
    public ushort* DnsTreeName;

    [NativeTypeName("LPWSTR")]
    public ushort* PackageName;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint CredTypeCount;

    [NativeTypeName("LPDWORD")]
    public uint* CredTypes;
}
