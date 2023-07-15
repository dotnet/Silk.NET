// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER"]/*'/>
public unsafe partial struct IMAGE_SECTION_HEADER
{
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.Name"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte Name[8];
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.Misc"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L18655_C5")]
    public _Misc_e__Union Misc;
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.VirtualAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint VirtualAddress;
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.SizeOfRawData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfRawData;
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.PointerToRawData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PointerToRawData;
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.PointerToRelocations"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PointerToRelocations;
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.PointerToLinenumbers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PointerToLinenumbers;
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.NumberOfRelocations"]/*'/>
    [NativeTypeName("WORD")]
    public ushort NumberOfRelocations;
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.NumberOfLinenumbers"]/*'/>
    [NativeTypeName("WORD")]
    public ushort NumberOfLinenumbers;
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.Characteristics"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Characteristics;
    /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Misc_e__Union
    {
        /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union.PhysicalAddress"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint PhysicalAddress;
        /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union.VirtualSize"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint VirtualSize;
    }
}