// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='WMAUDIO2WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO2WAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WMAUDIO2WAVEFORMAT
{
    /// <include file='WMAUDIO2WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO2WAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='WMAUDIO2WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO2WAVEFORMAT.dwSamplesPerBlock"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSamplesPerBlock;
    /// <include file='WMAUDIO2WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO2WAVEFORMAT.wEncodeOptions"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wEncodeOptions;
    /// <include file='WMAUDIO2WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO2WAVEFORMAT.dwSuperBlockAlign"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSuperBlockAlign;
}