// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='GSM610WAVEFORMAT.xml' path='doc/member[@name="GSM610WAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct GSM610WAVEFORMAT
{
    /// <include file='GSM610WAVEFORMAT.xml' path='doc/member[@name="GSM610WAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='GSM610WAVEFORMAT.xml' path='doc/member[@name="GSM610WAVEFORMAT.wSamplesPerBlock"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wSamplesPerBlock;
}