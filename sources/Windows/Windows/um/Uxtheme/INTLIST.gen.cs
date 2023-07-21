// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='INTLIST.xml' path='doc/member[@name="INTLIST"]/*' />
public unsafe partial struct INTLIST
{
    /// <include file='INTLIST.xml' path='doc/member[@name="INTLIST.iValueCount"]/*' />
    public int iValueCount;

    /// <include file='INTLIST.xml' path='doc/member[@name="INTLIST.iValues"]/*' />
    [NativeTypeName("int[402]")]
    public fixed int iValues[402];
}
