// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS"]/*'/>
public unsafe partial struct HIDP_BUTTON_CAPS
{
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.UsagePage"]/*'/>
    [NativeTypeName("USAGE")]
    public ushort UsagePage;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.ReportID"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte ReportID;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.IsAlias"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte IsAlias;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.BitField"]/*'/>
    public ushort BitField;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.LinkCollection"]/*'/>
    public ushort LinkCollection;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.LinkUsage"]/*'/>
    [NativeTypeName("USAGE")]
    public ushort LinkUsage;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.LinkUsagePage"]/*'/>
    [NativeTypeName("USAGE")]
    public ushort LinkUsagePage;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.IsRange"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte IsRange;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.IsStringRange"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte IsStringRange;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.IsDesignatorRange"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte IsDesignatorRange;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.IsAbsolute"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte IsAbsolute;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.ReportCount"]/*'/>
    public ushort ReportCount;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.Reserved2"]/*'/>
    public ushort Reserved2;
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.Reserved"]/*'/>
    [NativeTypeName("ULONG[9]")]
    public fixed uint Reserved[9];
    /// <include file='HIDP_BUTTON_CAPS.xml' path='doc/member[@name="HIDP_BUTTON_CAPS.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_hidpi_L90_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Range"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._Range_e__Struct Range
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Range;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NotRange"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._NotRange_e__Struct NotRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NotRange;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Range"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_hidpi_L91_C9")]
        public _Range_e__Struct Range;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NotRange"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_hidpi_L97_C9")]
        public _NotRange_e__Struct NotRange;
        /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct"]/*'/>
        public partial struct _Range_e__Struct
        {
            /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct.UsageMin"]/*'/>
            [NativeTypeName("USAGE")]
            public ushort UsageMin;
            /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct.UsageMax"]/*'/>
            [NativeTypeName("USAGE")]
            public ushort UsageMax;
            /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct.StringMin"]/*'/>
            public ushort StringMin;
            /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct.StringMax"]/*'/>
            public ushort StringMax;
            /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct.DesignatorMin"]/*'/>
            public ushort DesignatorMin;
            /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct.DesignatorMax"]/*'/>
            public ushort DesignatorMax;
            /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct.DataIndexMin"]/*'/>
            public ushort DataIndexMin;
            /// <include file='_Range_e__Struct.xml' path='doc/member[@name="_Range_e__Struct.DataIndexMax"]/*'/>
            public ushort DataIndexMax;
        }

        /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct"]/*'/>
        public partial struct _NotRange_e__Struct
        {
            /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct.Usage"]/*'/>
            [NativeTypeName("USAGE")]
            public ushort Usage;
            /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct.Reserved1"]/*'/>
            [NativeTypeName("USAGE")]
            public ushort Reserved1;
            /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct.StringIndex"]/*'/>
            public ushort StringIndex;
            /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct.Reserved2"]/*'/>
            public ushort Reserved2;
            /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct.DesignatorIndex"]/*'/>
            public ushort DesignatorIndex;
            /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct.Reserved3"]/*'/>
            public ushort Reserved3;
            /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct.DataIndex"]/*'/>
            public ushort DataIndex;
            /// <include file='_NotRange_e__Struct.xml' path='doc/member[@name="_NotRange_e__Struct.Reserved4"]/*'/>
            public ushort Reserved4;
        }
    }
}