// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DROPFILES.xml' path='doc/member[@name="DROPFILES"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DROPFILES
{
    /// <include file='DROPFILES.xml' path='doc/member[@name="DROPFILES.pFiles"]/*'/>
    [NativeTypeName("DWORD")]
    public uint pFiles;
    /// <include file='DROPFILES.xml' path='doc/member[@name="DROPFILES.pt"]/*'/>
    public POINT pt;
    /// <include file='DROPFILES.xml' path='doc/member[@name="DROPFILES.fNC"]/*'/>
    public BOOL fNC;
    /// <include file='DROPFILES.xml' path='doc/member[@name="DROPFILES.fWide"]/*'/>
    public BOOL fWide;
}