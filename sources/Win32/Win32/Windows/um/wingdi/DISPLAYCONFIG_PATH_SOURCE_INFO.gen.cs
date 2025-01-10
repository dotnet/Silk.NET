// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAYCONFIG_PATH_SOURCE_INFO
{
    public LUID adapterId;

    [NativeTypeName("UINT32")]
    public uint id;

    [NativeTypeName("__AnonymousRecord_wingdi_L2954_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("UINT32")]
    public uint statusFlags;

    [UnscopedRef]
    public ref uint modeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.modeInfoIdx; }
    }
    public uint cloneGroupId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.cloneGroupId; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.cloneGroupId = value; }
    }
    public uint sourceModeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.sourceModeInfoIdx; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.sourceModeInfoIdx = value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint modeInfoIdx;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2957_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("UINT32 : 16")]
            public uint cloneGroupId
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0xFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu); }
            }

            [NativeTypeName("UINT32 : 16")]
            public uint sourceModeInfoIdx
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 16) & 0xFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16); }
            }
        }
    }
}
