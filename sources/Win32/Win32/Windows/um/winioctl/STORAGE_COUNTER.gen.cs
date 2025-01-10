// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_COUNTER
{
    public STORAGE_COUNTER_TYPE Type;

    [NativeTypeName("__AnonymousRecord_winioctl_L6623_C5")]
    public _Value_e__Union Value;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Value_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6625_C9")]
        public _ManufactureDate_e__Struct ManufactureDate;

        [FieldOffset(0)]
        [NativeTypeName("DWORDLONG")]
        public ulong AsUlonglong;

        public partial struct _ManufactureDate_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint Week;

            [NativeTypeName("DWORD")]
            public uint Year;
        }
    }
}
