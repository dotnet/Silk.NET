// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='RAWINPUT.xml' path='doc/member[@name="RAWINPUT"]/*'/>
public partial struct RAWINPUT
{
    /// <include file='RAWINPUT.xml' path='doc/member[@name="RAWINPUT.header"]/*'/>
    public RAWINPUTHEADER header;
    /// <include file='RAWINPUT.xml' path='doc/member[@name="RAWINPUT.data"]/*'/>
    [NativeTypeName("__AnonymousRecord_WinUser_L15110_C5")]
    public _data_e__Union data;
    /// <include file='_data_e__Union.xml' path='doc/member[@name="_data_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _data_e__Union
    {
        /// <include file='_data_e__Union.xml' path='doc/member[@name="_data_e__Union.mouse"]/*'/>
        [FieldOffset(0)]
        public RAWMOUSE mouse;
        /// <include file='_data_e__Union.xml' path='doc/member[@name="_data_e__Union.keyboard"]/*'/>
        [FieldOffset(0)]
        public RAWKEYBOARD keyboard;
        /// <include file='_data_e__Union.xml' path='doc/member[@name="_data_e__Union.hid"]/*'/>
        [FieldOffset(0)]
        public RAWHID hid;
    }
}