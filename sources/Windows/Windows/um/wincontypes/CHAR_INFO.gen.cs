// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CHAR_INFO.xml' path='doc/member[@name="CHAR_INFO"]/*'/>
public partial struct CHAR_INFO
{
    /// <include file='CHAR_INFO.xml' path='doc/member[@name="CHAR_INFO.Char"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincontypes_L144_C5")]
    public _Char_e__Union Char;
    /// <include file='CHAR_INFO.xml' path='doc/member[@name="CHAR_INFO.Attributes"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Attributes;
    /// <include file='_Char_e__Union.xml' path='doc/member[@name="_Char_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Char_e__Union
    {
        /// <include file='_Char_e__Union.xml' path='doc/member[@name="_Char_e__Union.UnicodeChar"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("WCHAR")]
        public ushort UnicodeChar;
        /// <include file='_Char_e__Union.xml' path='doc/member[@name="_Char_e__Union.AsciiChar"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("CHAR")]
        public sbyte AsciiChar;
    }
}