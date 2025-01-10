// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProfInfo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROFILEINFOW
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("LPWSTR")]
    public ushort* lpUserName;

    [NativeTypeName("LPWSTR")]
    public ushort* lpProfilePath;

    [NativeTypeName("LPWSTR")]
    public ushort* lpDefaultPath;

    [NativeTypeName("LPWSTR")]
    public ushort* lpServerName;

    [NativeTypeName("LPWSTR")]
    public ushort* lpPolicyPath;
    public HANDLE hProfile;
}
