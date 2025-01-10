// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProfInfo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROFILEINFOA
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("LPSTR")]
    public sbyte* lpUserName;

    [NativeTypeName("LPSTR")]
    public sbyte* lpProfilePath;

    [NativeTypeName("LPSTR")]
    public sbyte* lpDefaultPath;

    [NativeTypeName("LPSTR")]
    public sbyte* lpServerName;

    [NativeTypeName("LPSTR")]
    public sbyte* lpPolicyPath;
    public HANDLE hProfile;
}
