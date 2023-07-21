// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='NMTVKEYDOWN.xml' path='doc/member[@name="NMTVKEYDOWN"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NMTVKEYDOWN
{
    /// <include file='NMTVKEYDOWN.xml' path='doc/member[@name="NMTVKEYDOWN.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTVKEYDOWN.xml' path='doc/member[@name="NMTVKEYDOWN.wVKey"]/*' />
    [NativeTypeName("WORD")]
    public ushort wVKey;

    /// <include file='NMTVKEYDOWN.xml' path='doc/member[@name="NMTVKEYDOWN.flags"]/*' />
    public uint flags;
}
