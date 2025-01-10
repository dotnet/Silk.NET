// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SP_REGISTER_CONTROL_STATUSA
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("PCSTR")]
    public sbyte* FileName;

    [NativeTypeName("DWORD")]
    public uint Win32Error;

    [NativeTypeName("DWORD")]
    public uint FailureCode;
}
