// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HEAACWAVEFORMAT.xml' path='doc/member[@name="HEAACWAVEFORMAT"]/*'/>
public unsafe partial struct HEAACWAVEFORMAT
{
    /// <include file='HEAACWAVEFORMAT.xml' path='doc/member[@name="HEAACWAVEFORMAT.wfInfo"]/*'/>
    public HEAACWAVEINFO wfInfo;
    /// <include file='HEAACWAVEFORMAT.xml' path='doc/member[@name="HEAACWAVEFORMAT.pbAudioSpecificConfig"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte pbAudioSpecificConfig[1];
}