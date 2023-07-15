// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct USN_RECORD_V4
{
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.Header"]/*'/>
    public USN_RECORD_COMMON_HEADER Header;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.FileReferenceNumber"]/*'/>
    public FILE_ID_128 FileReferenceNumber;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.ParentFileReferenceNumber"]/*'/>
    public FILE_ID_128 ParentFileReferenceNumber;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.Usn"]/*'/>
    [NativeTypeName("USN")]
    public long Usn;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.Reason"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reason;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.SourceInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SourceInfo;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.RemainingExtents"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RemainingExtents;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.NumberOfExtents"]/*'/>
    [NativeTypeName("WORD")]
    public ushort NumberOfExtents;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.ExtentSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ExtentSize;
    /// <include file='USN_RECORD_V4.xml' path='doc/member[@name="USN_RECORD_V4.Extents"]/*'/>
    [NativeTypeName("USN_RECORD_EXTENT[1]")]
    public _Extents_e__FixedBuffer Extents;
    /// <include file='_Extents_e__FixedBuffer.xml' path='doc/member[@name="_Extents_e__FixedBuffer"]/*'/>
    public partial struct _Extents_e__FixedBuffer
    {
        public USN_RECORD_EXTENT e0;
        [UnscopedRef]
        public ref USN_RECORD_EXTENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<USN_RECORD_EXTENT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}