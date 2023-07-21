// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IDLDESC.xml' path='doc/member[@name="IDLDESC"]/*' />
public partial struct IDLDESC
{
    /// <include file='IDLDESC.xml' path='doc/member[@name="IDLDESC.dwReserved"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint dwReserved;

    /// <include file='IDLDESC.xml' path='doc/member[@name="IDLDESC.wIDLFlags"]/*' />
    public ushort wIDLFlags;
}
