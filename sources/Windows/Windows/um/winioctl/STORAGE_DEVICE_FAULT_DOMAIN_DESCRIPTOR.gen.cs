// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR"]/*'/>
public partial struct STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR
{
    /// <include file='STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.NumberOfFaultDomains"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfFaultDomains;
    /// <include file='STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR.FaultDomainIds"]/*'/>
    [NativeTypeName("GUID[1]")]
    public _FaultDomainIds_e__FixedBuffer FaultDomainIds;
    /// <include file='_FaultDomainIds_e__FixedBuffer.xml' path='doc/member[@name="_FaultDomainIds_e__FixedBuffer"]/*'/>
    public partial struct _FaultDomainIds_e__FixedBuffer
    {
        public Guid e0;
        [UnscopedRef]
        public ref Guid this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<Guid> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}