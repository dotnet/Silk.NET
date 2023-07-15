// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DIPROPPOINTER.xml' path='doc/member[@name="DIPROPPOINTER"]/*'/>
public partial struct DIPROPPOINTER
{
    /// <include file='DIPROPPOINTER.xml' path='doc/member[@name="DIPROPPOINTER.diph"]/*'/>
    public DIPROPHEADER diph;
    /// <include file='DIPROPPOINTER.xml' path='doc/member[@name="DIPROPPOINTER.uData"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint uData;
}