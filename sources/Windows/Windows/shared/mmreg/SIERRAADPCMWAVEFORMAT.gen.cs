// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SIERRAADPCMWAVEFORMAT.xml' path='doc/member[@name="SIERRAADPCMWAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SIERRAADPCMWAVEFORMAT
{
    /// <include file='SIERRAADPCMWAVEFORMAT.xml' path='doc/member[@name="SIERRAADPCMWAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='SIERRAADPCMWAVEFORMAT.xml' path='doc/member[@name="SIERRAADPCMWAVEFORMAT.wRevision"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wRevision;
}