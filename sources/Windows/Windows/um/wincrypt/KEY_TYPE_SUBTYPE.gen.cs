// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='KEY_TYPE_SUBTYPE.xml' path='doc/member[@name="KEY_TYPE_SUBTYPE"]/*'/>
public partial struct KEY_TYPE_SUBTYPE
{
    /// <include file='KEY_TYPE_SUBTYPE.xml' path='doc/member[@name="KEY_TYPE_SUBTYPE.dwKeySpec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;
    /// <include file='KEY_TYPE_SUBTYPE.xml' path='doc/member[@name="KEY_TYPE_SUBTYPE.Type"]/*'/>
    public Guid Type;
    /// <include file='KEY_TYPE_SUBTYPE.xml' path='doc/member[@name="KEY_TYPE_SUBTYPE.Subtype"]/*'/>
    public Guid Subtype;
}