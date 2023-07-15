// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='G723_ADPCMWAVEFORMAT.xml' path='doc/member[@name="G723_ADPCMWAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct G723_ADPCMWAVEFORMAT
{
    /// <include file='G723_ADPCMWAVEFORMAT.xml' path='doc/member[@name="G723_ADPCMWAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='G723_ADPCMWAVEFORMAT.xml' path='doc/member[@name="G723_ADPCMWAVEFORMAT.cbExtraSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbExtraSize;
    /// <include file='G723_ADPCMWAVEFORMAT.xml' path='doc/member[@name="G723_ADPCMWAVEFORMAT.nAuxBlockSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nAuxBlockSize;
}