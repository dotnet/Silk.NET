// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HEAPENTRY32
{
    [NativeTypeName("SIZE_T")]
    public nuint dwSize;
    public HANDLE hHandle;

    [NativeTypeName("ULONG_PTR")]
    public nuint dwAddress;

    [NativeTypeName("SIZE_T")]
    public nuint dwBlockSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwLockCount;

    [NativeTypeName("DWORD")]
    public uint dwResvd;

    [NativeTypeName("DWORD")]
    public uint th32ProcessID;

    [NativeTypeName("ULONG_PTR")]
    public nuint th32HeapID;
}
