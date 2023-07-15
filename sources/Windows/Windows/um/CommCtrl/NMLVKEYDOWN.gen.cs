// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='NMLVKEYDOWN.xml' path='doc/member[@name="NMLVKEYDOWN"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NMLVKEYDOWN
{
    /// <include file='NMLVKEYDOWN.xml' path='doc/member[@name="NMLVKEYDOWN.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLVKEYDOWN.xml' path='doc/member[@name="NMLVKEYDOWN.wVKey"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wVKey;
    /// <include file='NMLVKEYDOWN.xml' path='doc/member[@name="NMLVKEYDOWN.flags"]/*'/>
    public uint flags;
}