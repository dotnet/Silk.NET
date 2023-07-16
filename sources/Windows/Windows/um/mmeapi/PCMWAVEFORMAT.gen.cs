// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PCMWAVEFORMAT.xml' path='doc/member[@name="PCMWAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PCMWAVEFORMAT
{
    /// <include file='PCMWAVEFORMAT.xml' path='doc/member[@name="PCMWAVEFORMAT.wf"]/*'/>
    public WAVEFORMAT wf;
    /// <include file='PCMWAVEFORMAT.xml' path='doc/member[@name="PCMWAVEFORMAT.wBitsPerSample"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wBitsPerSample;
}