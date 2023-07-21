// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='M128A.xml' path='doc/member[@name="M128A"]/*' />
public partial struct M128A
{
    /// <include file='M128A.xml' path='doc/member[@name="M128A.Low"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong Low;

    /// <include file='M128A.xml' path='doc/member[@name="M128A.High"]/*' />
    [NativeTypeName("LONGLONG")]
    public long High;
}
