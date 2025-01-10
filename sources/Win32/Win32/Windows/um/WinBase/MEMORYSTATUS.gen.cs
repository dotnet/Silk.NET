// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MEMORYSTATUS
{
    [NativeTypeName("DWORD")]
    public uint dwLength;

    [NativeTypeName("DWORD")]
    public uint dwMemoryLoad;

    [NativeTypeName("SIZE_T")]
    public nuint dwTotalPhys;

    [NativeTypeName("SIZE_T")]
    public nuint dwAvailPhys;

    [NativeTypeName("SIZE_T")]
    public nuint dwTotalPageFile;

    [NativeTypeName("SIZE_T")]
    public nuint dwAvailPageFile;

    [NativeTypeName("SIZE_T")]
    public nuint dwTotalVirtual;

    [NativeTypeName("SIZE_T")]
    public nuint dwAvailVirtual;
}
