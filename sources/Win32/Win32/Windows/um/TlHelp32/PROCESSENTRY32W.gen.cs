// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESSENTRY32W
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint cntUsage;

    [NativeTypeName("DWORD")]
    public uint th32ProcessID;

    [NativeTypeName("ULONG_PTR")]
    public nuint th32DefaultHeapID;

    [NativeTypeName("DWORD")]
    public uint th32ModuleID;

    [NativeTypeName("DWORD")]
    public uint cntThreads;

    [NativeTypeName("DWORD")]
    public uint th32ParentProcessID;

    [NativeTypeName("LONG")]
    public int pcPriClassBase;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("WCHAR[260]")]
    public _szExeFile_e__FixedBuffer szExeFile;

    [InlineArray(260)]
    public partial struct _szExeFile_e__FixedBuffer
    {
        public ushort e0;
    }
}
