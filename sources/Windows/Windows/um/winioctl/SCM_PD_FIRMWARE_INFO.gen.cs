// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SCM_PD_FIRMWARE_INFO.xml' path='doc/member[@name="SCM_PD_FIRMWARE_INFO"]/*'/>
public partial struct SCM_PD_FIRMWARE_INFO
{
    /// <include file='SCM_PD_FIRMWARE_INFO.xml' path='doc/member[@name="SCM_PD_FIRMWARE_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_PD_FIRMWARE_INFO.xml' path='doc/member[@name="SCM_PD_FIRMWARE_INFO.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_PD_FIRMWARE_INFO.xml' path='doc/member[@name="SCM_PD_FIRMWARE_INFO.ActiveSlot"]/*'/>
    public byte ActiveSlot;
    /// <include file='SCM_PD_FIRMWARE_INFO.xml' path='doc/member[@name="SCM_PD_FIRMWARE_INFO.NextActiveSlot"]/*'/>
    public byte NextActiveSlot;
    /// <include file='SCM_PD_FIRMWARE_INFO.xml' path='doc/member[@name="SCM_PD_FIRMWARE_INFO.SlotCount"]/*'/>
    public byte SlotCount;
    /// <include file='SCM_PD_FIRMWARE_INFO.xml' path='doc/member[@name="SCM_PD_FIRMWARE_INFO.Slots"]/*'/>
    [NativeTypeName("SCM_PD_FIRMWARE_SLOT_INFO[1]")]
    public _Slots_e__FixedBuffer Slots;
    /// <include file='_Slots_e__FixedBuffer.xml' path='doc/member[@name="_Slots_e__FixedBuffer"]/*'/>
    public partial struct _Slots_e__FixedBuffer
    {
        public SCM_PD_FIRMWARE_SLOT_INFO e0;
        [UnscopedRef]
        public ref SCM_PD_FIRMWARE_SLOT_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_PD_FIRMWARE_SLOT_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}