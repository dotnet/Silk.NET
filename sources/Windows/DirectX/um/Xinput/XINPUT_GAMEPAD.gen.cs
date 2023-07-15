// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='XINPUT_GAMEPAD.xml' path='doc/member[@name="XINPUT_GAMEPAD"]/*'/>
public partial struct XINPUT_GAMEPAD
{
    /// <include file='XINPUT_GAMEPAD.xml' path='doc/member[@name="XINPUT_GAMEPAD.wButtons"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wButtons;
    /// <include file='XINPUT_GAMEPAD.xml' path='doc/member[@name="XINPUT_GAMEPAD.bLeftTrigger"]/*'/>
    public byte bLeftTrigger;
    /// <include file='XINPUT_GAMEPAD.xml' path='doc/member[@name="XINPUT_GAMEPAD.bRightTrigger"]/*'/>
    public byte bRightTrigger;
    /// <include file='XINPUT_GAMEPAD.xml' path='doc/member[@name="XINPUT_GAMEPAD.sThumbLX"]/*'/>
    public short sThumbLX;
    /// <include file='XINPUT_GAMEPAD.xml' path='doc/member[@name="XINPUT_GAMEPAD.sThumbLY"]/*'/>
    public short sThumbLY;
    /// <include file='XINPUT_GAMEPAD.xml' path='doc/member[@name="XINPUT_GAMEPAD.sThumbRX"]/*'/>
    public short sThumbRX;
    /// <include file='XINPUT_GAMEPAD.xml' path='doc/member[@name="XINPUT_GAMEPAD.sThumbRY"]/*'/>
    public short sThumbRY;
}