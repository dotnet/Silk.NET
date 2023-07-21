// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR"]/*' />
public partial struct IMAGE_IMPORT_DESCRIPTOR
{
    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L19638_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.ForwarderChain"]/*' />
    [NativeTypeName("DWORD")]
    public uint ForwarderChain;

    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.Name"]/*' />
    [NativeTypeName("DWORD")]
    public uint Name;

    /// <include file='IMAGE_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_IMPORT_DESCRIPTOR.FirstThunk"]/*' />
    [NativeTypeName("DWORD")]
    public uint FirstThunk;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Characteristics"]/*' />
    [UnscopedRef]
    public ref uint Characteristics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Characteristics;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginalFirstThunk"]/*' />
    [UnscopedRef]
    public ref uint OriginalFirstThunk
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.OriginalFirstThunk;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Characteristics"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Characteristics;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.OriginalFirstThunk"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint OriginalFirstThunk;
    }
}
