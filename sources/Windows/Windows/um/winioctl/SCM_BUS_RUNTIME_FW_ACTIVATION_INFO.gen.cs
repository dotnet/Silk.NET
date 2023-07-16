// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;
/// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO"]/*'/>
public partial struct SCM_BUS_RUNTIME_FW_ACTIVATION_INFO
{
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.RuntimeFwActivationSupported"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte RuntimeFwActivationSupported;
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.FirmwareActivationState"]/*'/>
    public SCM_BUS_FIRMWARE_ACTIVATION_STATE FirmwareActivationState;
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.FirmwareActivationCapability"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L7213_C5")]
    public _FirmwareActivationCapability_e__Struct FirmwareActivationCapability;
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.EstimatedFirmwareActivationTimeInUSecs"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong EstimatedFirmwareActivationTimeInUSecs;
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.EstimatedProcessorAccessQuiesceTimeInUSecs"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong EstimatedProcessorAccessQuiesceTimeInUSecs;
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.EstimatedIOAccessQuiesceTimeInUSecs"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong EstimatedIOAccessQuiesceTimeInUSecs;
    /// <include file='SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_BUS_RUNTIME_FW_ACTIVATION_INFO.PlatformSupportedMaxIOAccessQuiesceTimeInUSecs"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong PlatformSupportedMaxIOAccessQuiesceTimeInUSecs;
    /// <include file='_FirmwareActivationCapability_e__Struct.xml' path='doc/member[@name="_FirmwareActivationCapability_e__Struct"]/*'/>
    public partial struct _FirmwareActivationCapability_e__Struct
    {
        public uint _bitfield;
        /// <include file='_FirmwareActivationCapability_e__Struct.xml' path='doc/member[@name="_FirmwareActivationCapability_e__Struct.FwManagedIoQuiesceFwActivationSupported"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint FwManagedIoQuiesceFwActivationSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        /// <include file='_FirmwareActivationCapability_e__Struct.xml' path='doc/member[@name="_FirmwareActivationCapability_e__Struct.OsManagedIoQuiesceFwActivationSupported"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint OsManagedIoQuiesceFwActivationSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
            }
        }

        /// <include file='_FirmwareActivationCapability_e__Struct.xml' path='doc/member[@name="_FirmwareActivationCapability_e__Struct.WarmResetBasedFwActivationSupported"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint WarmResetBasedFwActivationSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 2) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
            }
        }

        /// <include file='_FirmwareActivationCapability_e__Struct.xml' path='doc/member[@name="_FirmwareActivationCapability_e__Struct.Reserved"]/*'/>
        [NativeTypeName("DWORD : 29")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 3) & 0x1FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3);
            }
        }
    }
}