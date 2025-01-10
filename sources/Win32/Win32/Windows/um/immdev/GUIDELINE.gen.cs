// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct GUIDELINE
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwLevel;

    [NativeTypeName("DWORD")]
    public uint dwIndex;

    [NativeTypeName("DWORD")]
    public uint dwStrLen;

    [NativeTypeName("DWORD")]
    public uint dwStrOffset;

    [NativeTypeName("DWORD")]
    public uint dwPrivateSize;

    [NativeTypeName("DWORD")]
    public uint dwPrivateOffset;
}
