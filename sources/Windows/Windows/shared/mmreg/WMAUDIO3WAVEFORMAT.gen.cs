// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='WMAUDIO3WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO3WAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WMAUDIO3WAVEFORMAT
{
    /// <include file='WMAUDIO3WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO3WAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='WMAUDIO3WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO3WAVEFORMAT.wValidBitsPerSample"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wValidBitsPerSample;
    /// <include file='WMAUDIO3WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO3WAVEFORMAT.dwChannelMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwChannelMask;
    /// <include file='WMAUDIO3WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO3WAVEFORMAT.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='WMAUDIO3WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO3WAVEFORMAT.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
    /// <include file='WMAUDIO3WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO3WAVEFORMAT.wEncodeOptions"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wEncodeOptions;
    /// <include file='WMAUDIO3WAVEFORMAT.xml' path='doc/member[@name="WMAUDIO3WAVEFORMAT.wReserved3"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved3;
}