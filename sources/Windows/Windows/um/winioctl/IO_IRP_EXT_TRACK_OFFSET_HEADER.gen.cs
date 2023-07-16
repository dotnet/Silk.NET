// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IO_IRP_EXT_TRACK_OFFSET_HEADER.xml' path='doc/member[@name="IO_IRP_EXT_TRACK_OFFSET_HEADER"]/*'/>
public unsafe partial struct IO_IRP_EXT_TRACK_OFFSET_HEADER
{
    /// <include file='IO_IRP_EXT_TRACK_OFFSET_HEADER.xml' path='doc/member[@name="IO_IRP_EXT_TRACK_OFFSET_HEADER.Validation"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Validation;
    /// <include file='IO_IRP_EXT_TRACK_OFFSET_HEADER.xml' path='doc/member[@name="IO_IRP_EXT_TRACK_OFFSET_HEADER.Flags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Flags;
    /// <include file='IO_IRP_EXT_TRACK_OFFSET_HEADER.xml' path='doc/member[@name="IO_IRP_EXT_TRACK_OFFSET_HEADER.TrackedOffsetCallback"]/*'/>
    [NativeTypeName("PIO_IRP_EXT_PROCESS_TRACKED_OFFSET_CALLBACK")]
    public delegate* unmanaged<IO_IRP_EXT_TRACK_OFFSET_HEADER*, IO_IRP_EXT_TRACK_OFFSET_HEADER*, long, void> TrackedOffsetCallback;
}