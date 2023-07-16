// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MOVEREGION_INFO.xml' path='doc/member[@name="MOVEREGION_INFO"]/*'/>
public partial struct MOVEREGION_INFO
{
    /// <include file='MOVEREGION_INFO.xml' path='doc/member[@name="MOVEREGION_INFO.FrameNumber"]/*'/>
    public uint FrameNumber;
    /// <include file='MOVEREGION_INFO.xml' path='doc/member[@name="MOVEREGION_INFO.NumMoveRegions"]/*'/>
    public uint NumMoveRegions;
    /// <include file='MOVEREGION_INFO.xml' path='doc/member[@name="MOVEREGION_INFO.MoveRegions"]/*'/>
    [NativeTypeName("MOVE_RECT[1]")]
    public _MoveRegions_e__FixedBuffer MoveRegions;
    /// <include file='_MoveRegions_e__FixedBuffer.xml' path='doc/member[@name="_MoveRegions_e__FixedBuffer"]/*'/>
    public partial struct _MoveRegions_e__FixedBuffer
    {
        public MOVE_RECT e0;
        [UnscopedRef]
        public ref MOVE_RECT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MOVE_RECT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}