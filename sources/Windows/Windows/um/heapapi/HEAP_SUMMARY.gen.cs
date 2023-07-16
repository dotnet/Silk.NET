// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/heapapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HEAP_SUMMARY.xml' path='doc/member[@name="HEAP_SUMMARY"]/*'/>
public partial struct HEAP_SUMMARY
{
    /// <include file='HEAP_SUMMARY.xml' path='doc/member[@name="HEAP_SUMMARY.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='HEAP_SUMMARY.xml' path='doc/member[@name="HEAP_SUMMARY.cbAllocated"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint cbAllocated;
    /// <include file='HEAP_SUMMARY.xml' path='doc/member[@name="HEAP_SUMMARY.cbCommitted"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint cbCommitted;
    /// <include file='HEAP_SUMMARY.xml' path='doc/member[@name="HEAP_SUMMARY.cbReserved"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint cbReserved;
    /// <include file='HEAP_SUMMARY.xml' path='doc/member[@name="HEAP_SUMMARY.cbMaxReserve"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint cbMaxReserve;
}