// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DEVICE_DSM_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NOTIFICATION_PARAMETERS"]/*'/>
public partial struct DEVICE_DSM_NOTIFICATION_PARAMETERS
{
    /// <include file='DEVICE_DSM_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NOTIFICATION_PARAMETERS.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_DSM_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NOTIFICATION_PARAMETERS.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='DEVICE_DSM_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NOTIFICATION_PARAMETERS.NumFileTypeIDs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumFileTypeIDs;
    /// <include file='DEVICE_DSM_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NOTIFICATION_PARAMETERS.FileTypeID"]/*'/>
    [NativeTypeName("GUID[1]")]
    public _FileTypeID_e__FixedBuffer FileTypeID;
    /// <include file='_FileTypeID_e__FixedBuffer.xml' path='doc/member[@name="_FileTypeID_e__FixedBuffer"]/*'/>
    public partial struct _FileTypeID_e__FixedBuffer
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