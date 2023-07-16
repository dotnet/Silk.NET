// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CONSOLE_READCONSOLE_CONTROL.xml' path='doc/member[@name="CONSOLE_READCONSOLE_CONTROL"]/*'/>
public partial struct CONSOLE_READCONSOLE_CONTROL
{
    /// <include file='CONSOLE_READCONSOLE_CONTROL.xml' path='doc/member[@name="CONSOLE_READCONSOLE_CONTROL.nLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint nLength;
    /// <include file='CONSOLE_READCONSOLE_CONTROL.xml' path='doc/member[@name="CONSOLE_READCONSOLE_CONTROL.nInitialChars"]/*'/>
    [NativeTypeName("ULONG")]
    public uint nInitialChars;
    /// <include file='CONSOLE_READCONSOLE_CONTROL.xml' path='doc/member[@name="CONSOLE_READCONSOLE_CONTROL.dwCtrlWakeupMask"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwCtrlWakeupMask;
    /// <include file='CONSOLE_READCONSOLE_CONTROL.xml' path='doc/member[@name="CONSOLE_READCONSOLE_CONTROL.dwControlKeyState"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwControlKeyState;
}