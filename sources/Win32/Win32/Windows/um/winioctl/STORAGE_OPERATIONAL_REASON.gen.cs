// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_OPERATIONAL_REASON
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public STORAGE_OPERATIONAL_STATUS_REASON Reason;

    [NativeTypeName("__AnonymousRecord_winioctl_L2844_C5")]
    public _RawBytes_e__Union RawBytes;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _RawBytes_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2849_C9")]
        public _ScsiSenseKey_e__Struct ScsiSenseKey;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2859_C9")]
        public _NVDIMM_N_e__Struct NVDIMM_N;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AsUlong;

        public partial struct _ScsiSenseKey_e__Struct
        {
            public byte SenseKey;
            public byte ASC;
            public byte ASCQ;
            public byte Reserved;
        }

        public partial struct _NVDIMM_N_e__Struct
        {
            public byte CriticalHealth;

            [NativeTypeName("BYTE[2]")]
            public _ModuleHealth_e__FixedBuffer ModuleHealth;
            public byte ErrorThresholdStatus;

            [InlineArray(2)]
            public partial struct _ModuleHealth_e__FixedBuffer
            {
                public byte e0;
            }
        }
    }
}
