// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SLIST_ENTRY.xml' path='doc/member[@name="SLIST_ENTRY"]/*'/>
public unsafe partial struct SLIST_ENTRY
{
    /// <include file='SLIST_ENTRY.xml' path='doc/member[@name="SLIST_ENTRY.Next"]/*'/>
    [NativeTypeName("struct _SLIST_ENTRY *")]
    public SLIST_ENTRY* Next;
}