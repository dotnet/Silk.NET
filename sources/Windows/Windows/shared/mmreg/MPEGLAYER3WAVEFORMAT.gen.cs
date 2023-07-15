// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='MPEGLAYER3WAVEFORMAT.xml' path='doc/member[@name="MPEGLAYER3WAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEGLAYER3WAVEFORMAT
{
    /// <include file='MPEGLAYER3WAVEFORMAT.xml' path='doc/member[@name="MPEGLAYER3WAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='MPEGLAYER3WAVEFORMAT.xml' path='doc/member[@name="MPEGLAYER3WAVEFORMAT.wID"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wID;
    /// <include file='MPEGLAYER3WAVEFORMAT.xml' path='doc/member[@name="MPEGLAYER3WAVEFORMAT.fdwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwFlags;
    /// <include file='MPEGLAYER3WAVEFORMAT.xml' path='doc/member[@name="MPEGLAYER3WAVEFORMAT.nBlockSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nBlockSize;
    /// <include file='MPEGLAYER3WAVEFORMAT.xml' path='doc/member[@name="MPEGLAYER3WAVEFORMAT.nFramesPerBlock"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nFramesPerBlock;
    /// <include file='MPEGLAYER3WAVEFORMAT.xml' path='doc/member[@name="MPEGLAYER3WAVEFORMAT.nCodecDelay"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nCodecDelay;
}