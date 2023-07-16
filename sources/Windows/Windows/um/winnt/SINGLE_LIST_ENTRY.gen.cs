// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SINGLE_LIST_ENTRY.xml' path='doc/member[@name="SINGLE_LIST_ENTRY"]/*'/>
public unsafe partial struct SINGLE_LIST_ENTRY
{
    /// <include file='SINGLE_LIST_ENTRY.xml' path='doc/member[@name="SINGLE_LIST_ENTRY.Next"]/*'/>
    [NativeTypeName("struct _SINGLE_LIST_ENTRY *")]
    public SINGLE_LIST_ENTRY* Next;
}