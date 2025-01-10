// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct OSVERSIONINFOEXA
{
    [NativeTypeName("DWORD")]
    public uint dwOSVersionInfoSize;

    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;

    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;

    [NativeTypeName("DWORD")]
    public uint dwBuildNumber;

    [NativeTypeName("DWORD")]
    public uint dwPlatformId;

    [NativeTypeName("CHAR[128]")]
    public _szCSDVersion_e__FixedBuffer szCSDVersion;

    [NativeTypeName("WORD")]
    public ushort wServicePackMajor;

    [NativeTypeName("WORD")]
    public ushort wServicePackMinor;

    [NativeTypeName("WORD")]
    public ushort wSuiteMask;
    public byte wProductType;
    public byte wReserved;

    [InlineArray(128)]
    public partial struct _szCSDVersion_e__FixedBuffer
    {
        public sbyte e0;
    }
}
