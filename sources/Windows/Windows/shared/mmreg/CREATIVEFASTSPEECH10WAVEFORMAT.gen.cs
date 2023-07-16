// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='CREATIVEFASTSPEECH10WAVEFORMAT.xml' path='doc/member[@name="CREATIVEFASTSPEECH10WAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CREATIVEFASTSPEECH10WAVEFORMAT
{
    /// <include file='CREATIVEFASTSPEECH10WAVEFORMAT.xml' path='doc/member[@name="CREATIVEFASTSPEECH10WAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='CREATIVEFASTSPEECH10WAVEFORMAT.xml' path='doc/member[@name="CREATIVEFASTSPEECH10WAVEFORMAT.wRevision"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wRevision;
}