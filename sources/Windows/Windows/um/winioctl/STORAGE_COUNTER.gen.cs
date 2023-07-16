// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='STORAGE_COUNTER.xml' path='doc/member[@name="STORAGE_COUNTER"]/*'/>
public partial struct STORAGE_COUNTER
{
    /// <include file='STORAGE_COUNTER.xml' path='doc/member[@name="STORAGE_COUNTER.Type"]/*'/>
    public STORAGE_COUNTER_TYPE Type;
    /// <include file='STORAGE_COUNTER.xml' path='doc/member[@name="STORAGE_COUNTER.Value"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L6362_C5")]
    public _Value_e__Union Value;
    /// <include file='_Value_e__Union.xml' path='doc/member[@name="_Value_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Value_e__Union
    {
        /// <include file='_Value_e__Union.xml' path='doc/member[@name="_Value_e__Union.ManufactureDate"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6364_C9")]
        public _ManufactureDate_e__Struct ManufactureDate;
        /// <include file='_Value_e__Union.xml' path='doc/member[@name="_Value_e__Union.AsUlonglong"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORDLONG")]
        public ulong AsUlonglong;
        /// <include file='_ManufactureDate_e__Struct.xml' path='doc/member[@name="_ManufactureDate_e__Struct"]/*'/>
        public partial struct _ManufactureDate_e__Struct
        {
            /// <include file='_ManufactureDate_e__Struct.xml' path='doc/member[@name="_ManufactureDate_e__Struct.Week"]/*'/>
            [NativeTypeName("DWORD")]
            public uint Week;
            /// <include file='_ManufactureDate_e__Struct.xml' path='doc/member[@name="_ManufactureDate_e__Struct.Year"]/*'/>
            [NativeTypeName("DWORD")]
            public uint Year;
        }
    }
}