// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESS_MITIGATION_SIDE_CHANNEL_ISOLATION_POLICY
{
    [NativeTypeName("__AnonymousRecord_winnt_L13221_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Flags; }
    }
    public uint SmtBranchTargetIsolation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.SmtBranchTargetIsolation; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.SmtBranchTargetIsolation = value; }
    }
    public uint IsolateSecurityDomain
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.IsolateSecurityDomain; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.IsolateSecurityDomain = value; }
    }
    public uint DisablePageCombine
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.DisablePageCombine; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.DisablePageCombine = value; }
    }
    public uint SpeculativeStoreBypassDisable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.SpeculativeStoreBypassDisable; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.SpeculativeStoreBypassDisable = value; }
    }
    public uint RestrictCoreSharing
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.RestrictCoreSharing; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.RestrictCoreSharing = value; }
    }
    public uint ReservedFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.ReservedFlags; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.ReservedFlags = value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Flags;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13223_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 1")]
            public uint SmtBranchTargetIsolation
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint IsolateSecurityDomain
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint DisablePageCombine
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 2) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint SpeculativeStoreBypassDisable
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 3) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint RestrictCoreSharing
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 4) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4); }
            }

            [NativeTypeName("DWORD : 27")]
            public uint ReservedFlags
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 5) & 0x7FFFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x7FFFFFFu << 5)) | ((value & 0x7FFFFFFu) << 5); }
            }
        }
    }
}
