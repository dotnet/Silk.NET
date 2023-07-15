// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR"]/*'/>
public partial struct FILE_ID_DESCRIPTOR
{
    /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.Type"]/*'/>
    public FILE_ID_TYPE Type;
    /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_WinBase_L9267_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FileId"]/*'/>
    [UnscopedRef]
    public ref LARGE_INTEGER FileId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FileId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ObjectId"]/*'/>
    [UnscopedRef]
    public ref Guid ObjectId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ObjectId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedFileId"]/*'/>
    [UnscopedRef]
    public ref FILE_ID_128 ExtendedFileId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ExtendedFileId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FileId"]/*'/>
        [FieldOffset(0)]
        public LARGE_INTEGER FileId;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ObjectId"]/*'/>
        [FieldOffset(0)]
        public Guid ObjectId;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedFileId"]/*'/>
        [FieldOffset(0)]
        public FILE_ID_128 ExtendedFileId;
    }
}