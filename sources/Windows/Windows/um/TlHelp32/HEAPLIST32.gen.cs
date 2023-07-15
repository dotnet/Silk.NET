// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HEAPLIST32.xml' path='doc/member[@name="HEAPLIST32"]/*'/>
public partial struct HEAPLIST32
{
    /// <include file='HEAPLIST32.xml' path='doc/member[@name="HEAPLIST32.dwSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint dwSize;
    /// <include file='HEAPLIST32.xml' path='doc/member[@name="HEAPLIST32.th32ProcessID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint th32ProcessID;
    /// <include file='HEAPLIST32.xml' path='doc/member[@name="HEAPLIST32.th32HeapID"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint th32HeapID;
    /// <include file='HEAPLIST32.xml' path='doc/member[@name="HEAPLIST32.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}