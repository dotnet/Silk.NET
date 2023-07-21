// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='REASON_CONTEXT.xml' path='doc/member[@name="REASON_CONTEXT"]/*' />
public partial struct REASON_CONTEXT
{
    /// <include file='REASON_CONTEXT.xml' path='doc/member[@name="REASON_CONTEXT.Version"]/*' />
    [NativeTypeName("ULONG")]
    public uint Version;

    /// <include file='REASON_CONTEXT.xml' path='doc/member[@name="REASON_CONTEXT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='REASON_CONTEXT.xml' path='doc/member[@name="REASON_CONTEXT.Reason"]/*' />
    [NativeTypeName("__AnonymousRecord_minwinbase_L273_C5")]
    public _Reason_e__Union Reason;

    /// <include file='_Reason_e__Union.xml' path='doc/member[@name="_Reason_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Reason_e__Union
    {
        /// <include file='_Reason_e__Union.xml' path='doc/member[@name="_Reason_e__Union.Detailed"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minwinbase_L274_C9")]
        public _Detailed_e__Struct Detailed;

        /// <include file='_Reason_e__Union.xml' path='doc/member[@name="_Reason_e__Union.SimpleReasonString"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* SimpleReasonString;

        /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct"]/*' />
        public unsafe partial struct _Detailed_e__Struct
        {
            /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct.LocalizedReasonModule"]/*' />
            public HMODULE LocalizedReasonModule;

            /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct.LocalizedReasonId"]/*' />
            [NativeTypeName("ULONG")]
            public uint LocalizedReasonId;

            /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct.ReasonStringCount"]/*' />
            [NativeTypeName("ULONG")]
            public uint ReasonStringCount;

            /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct.ReasonStrings"]/*' />
            [NativeTypeName("LPWSTR *")]
            public ushort** ReasonStrings;
        }
    }
}
