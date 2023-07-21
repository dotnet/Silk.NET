// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION"]/*' />
[SupportedOSPlatform("windows10.0.16299.0")]
public unsafe partial struct FILE_NOTIFY_EXTENDED_INFORMATION
{
    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.NextEntryOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.Action"]/*' />
    [NativeTypeName("DWORD")]
    public uint Action;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.CreationTime"]/*' />
    public LARGE_INTEGER CreationTime;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.LastModificationTime"]/*' />
    public LARGE_INTEGER LastModificationTime;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.LastChangeTime"]/*' />
    public LARGE_INTEGER LastChangeTime;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.LastAccessTime"]/*' />
    public LARGE_INTEGER LastAccessTime;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.AllocatedLength"]/*' />
    public LARGE_INTEGER AllocatedLength;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileSize"]/*' />
    public LARGE_INTEGER FileSize;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L14459_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileId"]/*' />
    public LARGE_INTEGER FileId;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.ParentFileId"]/*' />
    public LARGE_INTEGER ParentFileId;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort FileName[1];

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ReparsePointTag"]/*' />
    [UnscopedRef]
    public ref uint ReparsePointTag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ReparsePointTag;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EaSize"]/*' />
    [UnscopedRef]
    public ref uint EaSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.EaSize;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ReparsePointTag"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ReparsePointTag;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EaSize"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint EaSize;
    }
}
