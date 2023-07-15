// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='MARK_HANDLE_INFO.xml' path='doc/member[@name="MARK_HANDLE_INFO"]/*'/>
public partial struct MARK_HANDLE_INFO
{
    /// <include file='MARK_HANDLE_INFO.xml' path='doc/member[@name="MARK_HANDLE_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L11614_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='MARK_HANDLE_INFO.xml' path='doc/member[@name="MARK_HANDLE_INFO.VolumeHandle"]/*'/>
    public HANDLE VolumeHandle;
    /// <include file='MARK_HANDLE_INFO.xml' path='doc/member[@name="MARK_HANDLE_INFO.HandleInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HandleInfo;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UsnSourceInfo"]/*'/>
    [UnscopedRef]
    public ref uint UsnSourceInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.UsnSourceInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CopyNumber"]/*'/>
    [UnscopedRef]
    public ref uint CopyNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.CopyNumber;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UsnSourceInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint UsnSourceInfo;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CopyNumber"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint CopyNumber;
    }
}