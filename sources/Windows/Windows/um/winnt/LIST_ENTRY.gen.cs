// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LIST_ENTRY.xml' path='doc/member[@name="LIST_ENTRY"]/*'/>
public unsafe partial struct LIST_ENTRY
{
    /// <include file='LIST_ENTRY.xml' path='doc/member[@name="LIST_ENTRY.Flink"]/*'/>
    [NativeTypeName("struct _LIST_ENTRY *")]
    public LIST_ENTRY* Flink;
    /// <include file='LIST_ENTRY.xml' path='doc/member[@name="LIST_ENTRY.Blink"]/*'/>
    [NativeTypeName("struct _LIST_ENTRY *")]
    public LIST_ENTRY* Blink;
}