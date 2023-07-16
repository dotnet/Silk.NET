// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='READ_ELEMENT_ADDRESS_INFO.xml' path='doc/member[@name="READ_ELEMENT_ADDRESS_INFO"]/*'/>
public partial struct READ_ELEMENT_ADDRESS_INFO
{
    /// <include file='READ_ELEMENT_ADDRESS_INFO.xml' path='doc/member[@name="READ_ELEMENT_ADDRESS_INFO.NumberOfElements"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfElements;
    /// <include file='READ_ELEMENT_ADDRESS_INFO.xml' path='doc/member[@name="READ_ELEMENT_ADDRESS_INFO.ElementStatus"]/*'/>
    [NativeTypeName("CHANGER_ELEMENT_STATUS[1]")]
    public _ElementStatus_e__FixedBuffer ElementStatus;
    /// <include file='_ElementStatus_e__FixedBuffer.xml' path='doc/member[@name="_ElementStatus_e__FixedBuffer"]/*'/>
    public partial struct _ElementStatus_e__FixedBuffer
    {
        public CHANGER_ELEMENT_STATUS e0;
        [UnscopedRef]
        public ref CHANGER_ELEMENT_STATUS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<CHANGER_ELEMENT_STATUS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}