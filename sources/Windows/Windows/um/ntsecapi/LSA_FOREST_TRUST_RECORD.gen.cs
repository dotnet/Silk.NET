// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='LSA_FOREST_TRUST_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD"]/*' />
public partial struct LSA_FOREST_TRUST_RECORD
{
    /// <include file='LSA_FOREST_TRUST_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='LSA_FOREST_TRUST_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD.ForestTrustType"]/*' />
    public LSA_FOREST_TRUST_RECORD_TYPE ForestTrustType;

    /// <include file='LSA_FOREST_TRUST_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD.Time"]/*' />
    public LARGE_INTEGER Time;

    /// <include file='LSA_FOREST_TRUST_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD.ForestTrustData"]/*' />
    [NativeTypeName("__AnonymousRecord_ntsecapi_L2716_C5")]
    public _ForestTrustData_e__Union ForestTrustData;

    /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _ForestTrustData_e__Union
    {
        /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union.TopLevelName"]/*' />
        [FieldOffset(0)]
        public LSA_UNICODE_STRING TopLevelName;

        /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union.DomainInfo"]/*' />
        [FieldOffset(0)]
        public LSA_FOREST_TRUST_DOMAIN_INFO DomainInfo;

        /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union.Data"]/*' />
        [FieldOffset(0)]
        public LSA_FOREST_TRUST_BINARY_DATA Data;
    }
}
