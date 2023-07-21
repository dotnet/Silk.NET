// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='NMTCKEYDOWN.xml' path='doc/member[@name="NMTCKEYDOWN"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NMTCKEYDOWN
{
    /// <include file='NMTCKEYDOWN.xml' path='doc/member[@name="NMTCKEYDOWN.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTCKEYDOWN.xml' path='doc/member[@name="NMTCKEYDOWN.wVKey"]/*' />
    [NativeTypeName("WORD")]
    public ushort wVKey;

    /// <include file='NMTCKEYDOWN.xml' path='doc/member[@name="NMTCKEYDOWN.flags"]/*' />
    public uint flags;
}
