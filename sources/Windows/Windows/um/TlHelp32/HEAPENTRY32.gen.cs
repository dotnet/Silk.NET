// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32"]/*'/>
public partial struct HEAPENTRY32
{
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.dwSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint dwSize;
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.hHandle"]/*'/>
    public HANDLE hHandle;
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.dwAddress"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwAddress;
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.dwBlockSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint dwBlockSize;
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.dwLockCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLockCount;
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.dwResvd"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwResvd;
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.th32ProcessID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint th32ProcessID;
    /// <include file='HEAPENTRY32.xml' path='doc/member[@name="HEAPENTRY32.th32HeapID"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint th32HeapID;
}