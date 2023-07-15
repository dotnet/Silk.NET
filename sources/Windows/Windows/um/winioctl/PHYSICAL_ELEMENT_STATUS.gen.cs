// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='PHYSICAL_ELEMENT_STATUS.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS"]/*'/>
public partial struct PHYSICAL_ELEMENT_STATUS
{
    /// <include file='PHYSICAL_ELEMENT_STATUS.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='PHYSICAL_ELEMENT_STATUS.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='PHYSICAL_ELEMENT_STATUS.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS.DescriptorCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DescriptorCount;
    /// <include file='PHYSICAL_ELEMENT_STATUS.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS.ReturnedDescriptorCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReturnedDescriptorCount;
    /// <include file='PHYSICAL_ELEMENT_STATUS.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS.ElementIdentifierBeingDepoped"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ElementIdentifierBeingDepoped;
    /// <include file='PHYSICAL_ELEMENT_STATUS.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='PHYSICAL_ELEMENT_STATUS.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS.Descriptors"]/*'/>
    [NativeTypeName("PHYSICAL_ELEMENT_STATUS_DESCRIPTOR[1]")]
    public _Descriptors_e__FixedBuffer Descriptors;
    /// <include file='_Descriptors_e__FixedBuffer.xml' path='doc/member[@name="_Descriptors_e__FixedBuffer"]/*'/>
    public partial struct _Descriptors_e__FixedBuffer
    {
        public PHYSICAL_ELEMENT_STATUS_DESCRIPTOR e0;
        [UnscopedRef]
        public ref PHYSICAL_ELEMENT_STATUS_DESCRIPTOR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PHYSICAL_ELEMENT_STATUS_DESCRIPTOR> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}