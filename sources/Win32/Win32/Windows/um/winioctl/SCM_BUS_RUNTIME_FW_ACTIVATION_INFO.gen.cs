// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_BUS_RUNTIME_FW_ACTIVATION_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("BOOLEAN")]
    public byte RuntimeFwActivationSupported;
    public SCM_BUS_FIRMWARE_ACTIVATION_STATE FirmwareActivationState;

    [NativeTypeName("__AnonymousRecord_winioctl_L7487_C5")]
    public _FirmwareActivationCapability_e__Struct FirmwareActivationCapability;

    [NativeTypeName("DWORDLONG")]
    public ulong EstimatedFirmwareActivationTimeInUSecs;

    [NativeTypeName("DWORDLONG")]
    public ulong EstimatedProcessorAccessQuiesceTimeInUSecs;

    [NativeTypeName("DWORDLONG")]
    public ulong EstimatedIOAccessQuiesceTimeInUSecs;

    [NativeTypeName("DWORDLONG")]
    public ulong PlatformSupportedMaxIOAccessQuiesceTimeInUSecs;

    public partial struct _FirmwareActivationCapability_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint FwManagedIoQuiesceFwActivationSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
        }

        [NativeTypeName("DWORD : 1")]
        public uint OsManagedIoQuiesceFwActivationSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 1) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
        }

        [NativeTypeName("DWORD : 1")]
        public uint WarmResetBasedFwActivationSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 2) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
        }

        [NativeTypeName("DWORD : 29")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 3) & 0x1FFFFFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3); }
        }
    }
}
