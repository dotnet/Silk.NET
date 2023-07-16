// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DRMWAVEFORMAT.xml' path='doc/member[@name="DRMWAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DRMWAVEFORMAT
{
    /// <include file='DRMWAVEFORMAT.xml' path='doc/member[@name="DRMWAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='DRMWAVEFORMAT.xml' path='doc/member[@name="DRMWAVEFORMAT.wReserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved;
    /// <include file='DRMWAVEFORMAT.xml' path='doc/member[@name="DRMWAVEFORMAT.ulContentId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulContentId;
    /// <include file='DRMWAVEFORMAT.xml' path='doc/member[@name="DRMWAVEFORMAT.wfxSecure"]/*'/>
    public WAVEFORMATEX wfxSecure;
}