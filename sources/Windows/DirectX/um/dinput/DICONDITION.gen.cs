// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DICONDITION.xml' path='doc/member[@name="DICONDITION"]/*'/>
public partial struct DICONDITION
{
    /// <include file='DICONDITION.xml' path='doc/member[@name="DICONDITION.lOffset"]/*'/>
    [NativeTypeName("LONG")]
    public int lOffset;
    /// <include file='DICONDITION.xml' path='doc/member[@name="DICONDITION.lPositiveCoefficient"]/*'/>
    [NativeTypeName("LONG")]
    public int lPositiveCoefficient;
    /// <include file='DICONDITION.xml' path='doc/member[@name="DICONDITION.lNegativeCoefficient"]/*'/>
    [NativeTypeName("LONG")]
    public int lNegativeCoefficient;
    /// <include file='DICONDITION.xml' path='doc/member[@name="DICONDITION.dwPositiveSaturation"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPositiveSaturation;
    /// <include file='DICONDITION.xml' path='doc/member[@name="DICONDITION.dwNegativeSaturation"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNegativeSaturation;
    /// <include file='DICONDITION.xml' path='doc/member[@name="DICONDITION.lDeadBand"]/*'/>
    [NativeTypeName("LONG")]
    public int lDeadBand;
}