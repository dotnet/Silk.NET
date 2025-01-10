// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS
{
    [NativeTypeName("__AnonymousRecord_d3d9types_L2100_C5")]
    public _Anonymous_e__Union Anonymous;
    public uint ProtectionEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.ProtectionEnabled; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.ProtectionEnabled = value; }
    }
    public uint OverlayOrFullscreenRequired
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.OverlayOrFullscreenRequired; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.OverlayOrFullscreenRequired = value; }
    }
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Reserved; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Reserved = value; }
    }

    [UnscopedRef]
    public ref uint Value
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_d3d9types_L2102_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        public uint Value;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("uint : 1")]
            public uint ProtectionEnabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("uint : 1")]
            public uint OverlayOrFullscreenRequired
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
            }

            [NativeTypeName("uint : 30")]
            public uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 2) & 0x3FFFFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                }
            }
        }
    }
}
