// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct TP_CALLBACK_ENVIRON_V3
{
    [NativeTypeName("TP_VERSION")]
    public uint Version;
    public PTP_POOL Pool;
    public PTP_CLEANUP_GROUP CleanupGroup;

    [NativeTypeName("PTP_CLEANUP_GROUP_CANCEL_CALLBACK")]
    public delegate* unmanaged<void*, void*, void> CleanupGroupCancelCallback;

    [NativeTypeName("PVOID")]
    public void* RaceDll;

    [NativeTypeName("struct _ACTIVATION_CONTEXT *")]
    public void* ActivationContext;

    [NativeTypeName("PTP_SIMPLE_CALLBACK")]
    public delegate* unmanaged<PTP_CALLBACK_INSTANCE, void*, void> FinalizationCallback;

    [NativeTypeName("__AnonymousRecord_winnt_L25421_C5")]
    public _u_e__Union u;
    public TP_CALLBACK_PRIORITY CallbackPriority;

    [NativeTypeName("DWORD")]
    public uint Size;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Flags;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L25423_C9")]
        public _s_e__Struct s;

        public partial struct _s_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 1")]
            public uint LongFunction
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint Persistent
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
            }

            [NativeTypeName("DWORD : 30")]
            public uint Private
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
