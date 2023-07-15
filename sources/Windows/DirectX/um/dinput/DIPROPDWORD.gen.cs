// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DIPROPDWORD.xml' path='doc/member[@name="DIPROPDWORD"]/*'/>
public partial struct DIPROPDWORD
{
    /// <include file='DIPROPDWORD.xml' path='doc/member[@name="DIPROPDWORD.diph"]/*'/>
    public DIPROPHEADER diph;
    /// <include file='DIPROPDWORD.xml' path='doc/member[@name="DIPROPDWORD.dwData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwData;
}