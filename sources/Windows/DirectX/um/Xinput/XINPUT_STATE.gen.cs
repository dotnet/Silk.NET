// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='XINPUT_STATE.xml' path='doc/member[@name="XINPUT_STATE"]/*'/>
public partial struct XINPUT_STATE
{
    /// <include file='XINPUT_STATE.xml' path='doc/member[@name="XINPUT_STATE.dwPacketNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPacketNumber;
    /// <include file='XINPUT_STATE.xml' path='doc/member[@name="XINPUT_STATE.Gamepad"]/*'/>
    public XINPUT_GAMEPAD Gamepad;
}