// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct MODULEENTRY32
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint th32ModuleID;

    [NativeTypeName("DWORD")]
    public uint th32ProcessID;

    [NativeTypeName("DWORD")]
    public uint GlblcntUsage;

    [NativeTypeName("DWORD")]
    public uint ProccntUsage;
    public byte* modBaseAddr;

    [NativeTypeName("DWORD")]
    public uint modBaseSize;
    public HMODULE hModule;

    [NativeTypeName("char[256]")]
    public _szModule_e__FixedBuffer szModule;

    [NativeTypeName("char[260]")]
    public _szExePath_e__FixedBuffer szExePath;

    [InlineArray(256)]
    public partial struct _szModule_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(260)]
    public partial struct _szExePath_e__FixedBuffer
    {
        public sbyte e0;
    }
}
