// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='D3D10_BUFFER_SRV.xml' path='doc/member[@name="D3D10_BUFFER_SRV"]/*' />
public partial struct D3D10_BUFFER_SRV
{
    /// <include file='D3D10_BUFFER_SRV.xml' path='doc/member[@name="D3D10_BUFFER_SRV.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d10_L2836_C5")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='D3D10_BUFFER_SRV.xml' path='doc/member[@name="D3D10_BUFFER_SRV.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d10_L2841_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.FirstElement"]/*' />
    [UnscopedRef]
    public ref uint FirstElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.FirstElement;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.ElementOffset"]/*' />
    [UnscopedRef]
    public ref uint ElementOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.ElementOffset;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.NumElements"]/*' />
    [UnscopedRef]
    public ref uint NumElements
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.NumElements;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ElementWidth"]/*' />
    [UnscopedRef]
    public ref uint ElementWidth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.ElementWidth;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.FirstElement"]/*' />
        [FieldOffset(0)]
        public uint FirstElement;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.ElementOffset"]/*' />
        [FieldOffset(0)]
        public uint ElementOffset;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.NumElements"]/*' />
        [FieldOffset(0)]
        public uint NumElements;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ElementWidth"]/*' />
        [FieldOffset(0)]
        public uint ElementWidth;
    }
}
