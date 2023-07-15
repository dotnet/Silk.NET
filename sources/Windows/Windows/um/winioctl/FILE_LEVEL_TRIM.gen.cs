// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='FILE_LEVEL_TRIM.xml' path='doc/member[@name="FILE_LEVEL_TRIM"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct FILE_LEVEL_TRIM
{
    /// <include file='FILE_LEVEL_TRIM.xml' path='doc/member[@name="FILE_LEVEL_TRIM.Key"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Key;
    /// <include file='FILE_LEVEL_TRIM.xml' path='doc/member[@name="FILE_LEVEL_TRIM.NumRanges"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumRanges;
    /// <include file='FILE_LEVEL_TRIM.xml' path='doc/member[@name="FILE_LEVEL_TRIM.Ranges"]/*'/>
    [NativeTypeName("FILE_LEVEL_TRIM_RANGE[1]")]
    public _Ranges_e__FixedBuffer Ranges;
    /// <include file='_Ranges_e__FixedBuffer.xml' path='doc/member[@name="_Ranges_e__FixedBuffer"]/*'/>
    public partial struct _Ranges_e__FixedBuffer
    {
        public FILE_LEVEL_TRIM_RANGE e0;
        [UnscopedRef]
        public ref FILE_LEVEL_TRIM_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<FILE_LEVEL_TRIM_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}