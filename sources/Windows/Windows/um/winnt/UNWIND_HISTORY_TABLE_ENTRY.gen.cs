// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='UNWIND_HISTORY_TABLE_ENTRY.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE_ENTRY"]/*'/>
public unsafe partial struct UNWIND_HISTORY_TABLE_ENTRY
{
    /// <include file='UNWIND_HISTORY_TABLE_ENTRY.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE_ENTRY.ImageBase"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint ImageBase;
    /// <include file='UNWIND_HISTORY_TABLE_ENTRY.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE_ENTRY.FunctionEntry"]/*'/>
    [NativeTypeName("PRUNTIME_FUNCTION")]
    public void* FunctionEntry;
}