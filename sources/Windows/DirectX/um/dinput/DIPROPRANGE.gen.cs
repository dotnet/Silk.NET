// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DIPROPRANGE.xml' path='doc/member[@name="DIPROPRANGE"]/*'/>
public partial struct DIPROPRANGE
{
    /// <include file='DIPROPRANGE.xml' path='doc/member[@name="DIPROPRANGE.diph"]/*'/>
    public DIPROPHEADER diph;
    /// <include file='DIPROPRANGE.xml' path='doc/member[@name="DIPROPRANGE.lMin"]/*'/>
    [NativeTypeName("LONG")]
    public int lMin;
    /// <include file='DIPROPRANGE.xml' path='doc/member[@name="DIPROPRANGE.lMax"]/*'/>
    [NativeTypeName("LONG")]
    public int lMax;
}