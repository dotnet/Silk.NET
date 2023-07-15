// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYSTEM_EVENT_DATA.xml' path='doc/member[@name="SYSTEM_EVENT_DATA"]/*'/>
public partial struct SYSTEM_EVENT_DATA
{
    /// <include file='SYSTEM_EVENT_DATA.xml' path='doc/member[@name="SYSTEM_EVENT_DATA.bModifier"]/*'/>
    public byte bModifier;
    /// <include file='SYSTEM_EVENT_DATA.xml' path='doc/member[@name="SYSTEM_EVENT_DATA.wKey"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort wKey;
    /// <include file='SYSTEM_EVENT_DATA.xml' path='doc/member[@name="SYSTEM_EVENT_DATA.xPos"]/*'/>
    [NativeTypeName("LONG")]
    public int xPos;
    /// <include file='SYSTEM_EVENT_DATA.xml' path='doc/member[@name="SYSTEM_EVENT_DATA.yPos"]/*'/>
    [NativeTypeName("LONG")]
    public int yPos;
    /// <include file='SYSTEM_EVENT_DATA.xml' path='doc/member[@name="SYSTEM_EVENT_DATA.bCursorMode"]/*'/>
    public byte bCursorMode;
    /// <include file='SYSTEM_EVENT_DATA.xml' path='doc/member[@name="SYSTEM_EVENT_DATA.dwButtonState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwButtonState;
}