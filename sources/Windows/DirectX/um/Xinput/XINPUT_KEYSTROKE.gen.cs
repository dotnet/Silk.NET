// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='XINPUT_KEYSTROKE.xml' path='doc/member[@name="XINPUT_KEYSTROKE"]/*'/>
public partial struct XINPUT_KEYSTROKE
{
    /// <include file='XINPUT_KEYSTROKE.xml' path='doc/member[@name="XINPUT_KEYSTROKE.VirtualKey"]/*'/>
    [NativeTypeName("WORD")]
    public ushort VirtualKey;
    /// <include file='XINPUT_KEYSTROKE.xml' path='doc/member[@name="XINPUT_KEYSTROKE.Unicode"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort Unicode;
    /// <include file='XINPUT_KEYSTROKE.xml' path='doc/member[@name="XINPUT_KEYSTROKE.Flags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Flags;
    /// <include file='XINPUT_KEYSTROKE.xml' path='doc/member[@name="XINPUT_KEYSTROKE.UserIndex"]/*'/>
    public byte UserIndex;
    /// <include file='XINPUT_KEYSTROKE.xml' path='doc/member[@name="XINPUT_KEYSTROKE.HidCode"]/*'/>
    public byte HidCode;
}