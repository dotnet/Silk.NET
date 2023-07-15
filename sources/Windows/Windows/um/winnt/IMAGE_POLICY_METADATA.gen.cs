// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA"]/*'/>
public unsafe partial struct IMAGE_POLICY_METADATA
{
    /// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA.Version"]/*'/>
    public byte Version;
    /// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA.Reserved0"]/*'/>
    [NativeTypeName("BYTE[7]")]
    public fixed byte Reserved0[7];
    /// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA.ApplicationId"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ApplicationId;
    /// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA.Policies"]/*'/>
    [NativeTypeName("IMAGE_POLICY_ENTRY[]")]
    public _Policies_e__FixedBuffer Policies;
    /// <include file='_Policies_e__FixedBuffer.xml' path='doc/member[@name="_Policies_e__FixedBuffer"]/*'/>
    public partial struct _Policies_e__FixedBuffer
    {
        public IMAGE_POLICY_ENTRY e0;
        [UnscopedRef]
        public ref IMAGE_POLICY_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<IMAGE_POLICY_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}