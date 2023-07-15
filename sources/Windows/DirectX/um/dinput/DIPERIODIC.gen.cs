// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DIPERIODIC.xml' path='doc/member[@name="DIPERIODIC"]/*'/>
public partial struct DIPERIODIC
{
    /// <include file='DIPERIODIC.xml' path='doc/member[@name="DIPERIODIC.dwMagnitude"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMagnitude;
    /// <include file='DIPERIODIC.xml' path='doc/member[@name="DIPERIODIC.lOffset"]/*'/>
    [NativeTypeName("LONG")]
    public int lOffset;
    /// <include file='DIPERIODIC.xml' path='doc/member[@name="DIPERIODIC.dwPhase"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPhase;
    /// <include file='DIPERIODIC.xml' path='doc/member[@name="DIPERIODIC.dwPeriod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPeriod;
}