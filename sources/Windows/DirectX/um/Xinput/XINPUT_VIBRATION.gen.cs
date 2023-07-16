// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='XINPUT_VIBRATION.xml' path='doc/member[@name="XINPUT_VIBRATION"]/*'/>
public partial struct XINPUT_VIBRATION
{
    /// <include file='XINPUT_VIBRATION.xml' path='doc/member[@name="XINPUT_VIBRATION.wLeftMotorSpeed"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wLeftMotorSpeed;
    /// <include file='XINPUT_VIBRATION.xml' path='doc/member[@name="XINPUT_VIBRATION.wRightMotorSpeed"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wRightMotorSpeed;
}