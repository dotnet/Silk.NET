// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_LINENUMBER.xml' path='doc/member[@name="IMAGE_LINENUMBER"]/*'/>
public partial struct IMAGE_LINENUMBER
{
    /// <include file='IMAGE_LINENUMBER.xml' path='doc/member[@name="IMAGE_LINENUMBER.Type"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L19426_C5")]
    public _Type_e__Union Type;
    /// <include file='IMAGE_LINENUMBER.xml' path='doc/member[@name="IMAGE_LINENUMBER.Linenumber"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Linenumber;
    /// <include file='_Type_e__Union.xml' path='doc/member[@name="_Type_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public partial struct _Type_e__Union
    {
        /// <include file='_Type_e__Union.xml' path='doc/member[@name="_Type_e__Union.SymbolTableIndex"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint SymbolTableIndex;
        /// <include file='_Type_e__Union.xml' path='doc/member[@name="_Type_e__Union.VirtualAddress"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint VirtualAddress;
    }
}