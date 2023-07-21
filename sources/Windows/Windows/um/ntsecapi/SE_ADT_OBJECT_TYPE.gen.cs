// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='SE_ADT_OBJECT_TYPE.xml' path='doc/member[@name="SE_ADT_OBJECT_TYPE"]/*' />
public partial struct SE_ADT_OBJECT_TYPE
{
    /// <include file='SE_ADT_OBJECT_TYPE.xml' path='doc/member[@name="SE_ADT_OBJECT_TYPE.ObjectType"]/*' />
    public Guid ObjectType;

    /// <include file='SE_ADT_OBJECT_TYPE.xml' path='doc/member[@name="SE_ADT_OBJECT_TYPE.Flags"]/*' />
    public ushort Flags;

    /// <include file='SE_ADT_OBJECT_TYPE.xml' path='doc/member[@name="SE_ADT_OBJECT_TYPE.Level"]/*' />
    public ushort Level;

    /// <include file='SE_ADT_OBJECT_TYPE.xml' path='doc/member[@name="SE_ADT_OBJECT_TYPE.AccessMask"]/*' />
    [NativeTypeName("ACCESS_MASK")]
    public uint AccessMask;
}
