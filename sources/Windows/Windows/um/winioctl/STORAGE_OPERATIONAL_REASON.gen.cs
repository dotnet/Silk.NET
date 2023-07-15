// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_OPERATIONAL_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_REASON"]/*'/>
public partial struct STORAGE_OPERATIONAL_REASON
{
    /// <include file='STORAGE_OPERATIONAL_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_REASON.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_OPERATIONAL_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_REASON.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_OPERATIONAL_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_REASON.Reason"]/*'/>
    public STORAGE_OPERATIONAL_STATUS_REASON Reason;
    /// <include file='STORAGE_OPERATIONAL_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_REASON.RawBytes"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L2649_C5")]
    public _RawBytes_e__Union RawBytes;
    /// <include file='_RawBytes_e__Union.xml' path='doc/member[@name="_RawBytes_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _RawBytes_e__Union
    {
        /// <include file='_RawBytes_e__Union.xml' path='doc/member[@name="_RawBytes_e__Union.ScsiSenseKey"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2654_C9")]
        public _ScsiSenseKey_e__Struct ScsiSenseKey;
        /// <include file='_RawBytes_e__Union.xml' path='doc/member[@name="_RawBytes_e__Union.NVDIMM_N"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2664_C9")]
        public _NVDIMM_N_e__Struct NVDIMM_N;
        /// <include file='_RawBytes_e__Union.xml' path='doc/member[@name="_RawBytes_e__Union.AsUlong"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AsUlong;
        /// <include file='_ScsiSenseKey_e__Struct.xml' path='doc/member[@name="_ScsiSenseKey_e__Struct"]/*'/>
        public partial struct _ScsiSenseKey_e__Struct
        {
            /// <include file='_ScsiSenseKey_e__Struct.xml' path='doc/member[@name="_ScsiSenseKey_e__Struct.SenseKey"]/*'/>
            public byte SenseKey;
            /// <include file='_ScsiSenseKey_e__Struct.xml' path='doc/member[@name="_ScsiSenseKey_e__Struct.ASC"]/*'/>
            public byte ASC;
            /// <include file='_ScsiSenseKey_e__Struct.xml' path='doc/member[@name="_ScsiSenseKey_e__Struct.ASCQ"]/*'/>
            public byte ASCQ;
            /// <include file='_ScsiSenseKey_e__Struct.xml' path='doc/member[@name="_ScsiSenseKey_e__Struct.Reserved"]/*'/>
            public byte Reserved;
        }

        /// <include file='_NVDIMM_N_e__Struct.xml' path='doc/member[@name="_NVDIMM_N_e__Struct"]/*'/>
        public unsafe partial struct _NVDIMM_N_e__Struct
        {
            /// <include file='_NVDIMM_N_e__Struct.xml' path='doc/member[@name="_NVDIMM_N_e__Struct.CriticalHealth"]/*'/>
            public byte CriticalHealth;
            /// <include file='_NVDIMM_N_e__Struct.xml' path='doc/member[@name="_NVDIMM_N_e__Struct.ModuleHealth"]/*'/>
            [NativeTypeName("BYTE[2]")]
            public fixed byte ModuleHealth[2];
            /// <include file='_NVDIMM_N_e__Struct.xml' path='doc/member[@name="_NVDIMM_N_e__Struct.ErrorThresholdStatus"]/*'/>
            public byte ErrorThresholdStatus;
        }
    }
}