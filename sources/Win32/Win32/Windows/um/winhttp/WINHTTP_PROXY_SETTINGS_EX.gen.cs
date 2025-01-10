// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WINHTTP_PROXY_SETTINGS_EX
{
    [NativeTypeName("ULONGLONG")]
    public ulong ullGenerationId;

    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;

    [NativeTypeName("PCWSTR")]
    public ushort* pcwszAutoconfigUrl;

    [NativeTypeName("PCWSTR")]
    public ushort* pcwszProxy;

    [NativeTypeName("PCWSTR")]
    public ushort* pcwszSecureProxy;

    [NativeTypeName("DWORD")]
    public uint cProxyBypasses;

    [NativeTypeName("PCWSTR *")]
    public ushort** rgpcwszProxyBypasses;

    [NativeTypeName("DWORD")]
    public uint dwInterfaceIndex;

    [NativeTypeName("PCWSTR")]
    public ushort* pcwszConnectionName;
}
