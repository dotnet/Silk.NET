// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SOFTDISTINFO
{
    [NativeTypeName("ULONG")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwAdState;

    [NativeTypeName("LPWSTR")]
    public ushort* szTitle;

    [NativeTypeName("LPWSTR")]
    public ushort* szAbstract;

    [NativeTypeName("LPWSTR")]
    public ushort* szHREF;

    [NativeTypeName("DWORD")]
    public uint dwInstalledVersionMS;

    [NativeTypeName("DWORD")]
    public uint dwInstalledVersionLS;

    [NativeTypeName("DWORD")]
    public uint dwUpdateVersionMS;

    [NativeTypeName("DWORD")]
    public uint dwUpdateVersionLS;

    [NativeTypeName("DWORD")]
    public uint dwAdvertisedVersionMS;

    [NativeTypeName("DWORD")]
    public uint dwAdvertisedVersionLS;

    [NativeTypeName("DWORD")]
    public uint dwReserved;
}
