// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OVERLAPPED_ENTRY.xml' path='doc/member[@name="OVERLAPPED_ENTRY"]/*'/>
public unsafe partial struct OVERLAPPED_ENTRY
{
    /// <include file='OVERLAPPED_ENTRY.xml' path='doc/member[@name="OVERLAPPED_ENTRY.lpCompletionKey"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint lpCompletionKey;
    /// <include file='OVERLAPPED_ENTRY.xml' path='doc/member[@name="OVERLAPPED_ENTRY.lpOverlapped"]/*'/>
    [NativeTypeName("LPOVERLAPPED")]
    public OVERLAPPED* lpOverlapped;
    /// <include file='OVERLAPPED_ENTRY.xml' path='doc/member[@name="OVERLAPPED_ENTRY.Internal"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint Internal;
    /// <include file='OVERLAPPED_ENTRY.xml' path='doc/member[@name="OVERLAPPED_ENTRY.dwNumberOfBytesTransferred"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumberOfBytesTransferred;
}