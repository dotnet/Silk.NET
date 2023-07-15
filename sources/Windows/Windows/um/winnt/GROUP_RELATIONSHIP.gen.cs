// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP"]/*'/>
public unsafe partial struct GROUP_RELATIONSHIP
{
    /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP.MaximumGroupCount"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MaximumGroupCount;
    /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP.ActiveGroupCount"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ActiveGroupCount;
    /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP.Reserved"]/*'/>
    [NativeTypeName("BYTE[20]")]
    public fixed byte Reserved[20];
    /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP.GroupInfo"]/*'/>
    [NativeTypeName("PROCESSOR_GROUP_INFO[1]")]
    public _GroupInfo_e__FixedBuffer GroupInfo;
    /// <include file='_GroupInfo_e__FixedBuffer.xml' path='doc/member[@name="_GroupInfo_e__FixedBuffer"]/*'/>
    public partial struct _GroupInfo_e__FixedBuffer
    {
        public PROCESSOR_GROUP_INFO e0;
        [UnscopedRef]
        public ref PROCESSOR_GROUP_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PROCESSOR_GROUP_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}