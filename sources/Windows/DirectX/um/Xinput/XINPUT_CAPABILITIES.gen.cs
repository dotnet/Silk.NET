// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='XINPUT_CAPABILITIES.xml' path='doc/member[@name="XINPUT_CAPABILITIES"]/*'/>
public partial struct XINPUT_CAPABILITIES
{
    /// <include file='XINPUT_CAPABILITIES.xml' path='doc/member[@name="XINPUT_CAPABILITIES.Type"]/*'/>
    public byte Type;
    /// <include file='XINPUT_CAPABILITIES.xml' path='doc/member[@name="XINPUT_CAPABILITIES.SubType"]/*'/>
    public byte SubType;
    /// <include file='XINPUT_CAPABILITIES.xml' path='doc/member[@name="XINPUT_CAPABILITIES.Flags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Flags;
    /// <include file='XINPUT_CAPABILITIES.xml' path='doc/member[@name="XINPUT_CAPABILITIES.Gamepad"]/*'/>
    public XINPUT_GAMEPAD Gamepad;
    /// <include file='XINPUT_CAPABILITIES.xml' path='doc/member[@name="XINPUT_CAPABILITIES.Vibration"]/*'/>
    public XINPUT_VIBRATION Vibration;
}