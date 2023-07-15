// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SCM_LD_INTERLEAVE_SET_INFO.xml' path='doc/member[@name="SCM_LD_INTERLEAVE_SET_INFO"]/*'/>
public partial struct SCM_LD_INTERLEAVE_SET_INFO
{
    /// <include file='SCM_LD_INTERLEAVE_SET_INFO.xml' path='doc/member[@name="SCM_LD_INTERLEAVE_SET_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_LD_INTERLEAVE_SET_INFO.xml' path='doc/member[@name="SCM_LD_INTERLEAVE_SET_INFO.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_LD_INTERLEAVE_SET_INFO.xml' path='doc/member[@name="SCM_LD_INTERLEAVE_SET_INFO.InterleaveSetSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint InterleaveSetSize;
    /// <include file='SCM_LD_INTERLEAVE_SET_INFO.xml' path='doc/member[@name="SCM_LD_INTERLEAVE_SET_INFO.InterleaveSet"]/*'/>
    [NativeTypeName("SCM_INTERLEAVED_PD_INFO[1]")]
    public _InterleaveSet_e__FixedBuffer InterleaveSet;
    /// <include file='_InterleaveSet_e__FixedBuffer.xml' path='doc/member[@name="_InterleaveSet_e__FixedBuffer"]/*'/>
    public partial struct _InterleaveSet_e__FixedBuffer
    {
        public SCM_INTERLEAVED_PD_INFO e0;
        [UnscopedRef]
        public ref SCM_INTERLEAVED_PD_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_INTERLEAVED_PD_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}