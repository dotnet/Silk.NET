// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='OBJECT_TYPE_LIST.xml' path='doc/member[@name="OBJECT_TYPE_LIST"]/*'/>
public unsafe partial struct OBJECT_TYPE_LIST
{
    /// <include file='OBJECT_TYPE_LIST.xml' path='doc/member[@name="OBJECT_TYPE_LIST.Level"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Level;
    /// <include file='OBJECT_TYPE_LIST.xml' path='doc/member[@name="OBJECT_TYPE_LIST.Sbz"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Sbz;
    /// <include file='OBJECT_TYPE_LIST.xml' path='doc/member[@name="OBJECT_TYPE_LIST.ObjectType"]/*'/>
    public Guid* ObjectType;
}