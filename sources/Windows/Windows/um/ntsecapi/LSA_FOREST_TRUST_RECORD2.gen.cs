// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='LSA_FOREST_TRUST_RECORD2.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD2"]/*'/>
public partial struct LSA_FOREST_TRUST_RECORD2
{
    /// <include file='LSA_FOREST_TRUST_RECORD2.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD2.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='LSA_FOREST_TRUST_RECORD2.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD2.ForestTrustType"]/*'/>
    public LSA_FOREST_TRUST_RECORD_TYPE ForestTrustType;
    /// <include file='LSA_FOREST_TRUST_RECORD2.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD2.Time"]/*'/>
    public LARGE_INTEGER Time;
    /// <include file='LSA_FOREST_TRUST_RECORD2.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD2.ForestTrustData"]/*'/>
    [NativeTypeName("__AnonymousRecord_ntsecapi_L2743_C5")]
    public _ForestTrustData_e__Union ForestTrustData;
    /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _ForestTrustData_e__Union
    {
        /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union.TopLevelName"]/*'/>
        [FieldOffset(0)]
        public LSA_UNICODE_STRING TopLevelName;
        /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union.DomainInfo"]/*'/>
        [FieldOffset(0)]
        public LSA_FOREST_TRUST_DOMAIN_INFO DomainInfo;
        /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union.BinaryData"]/*'/>
        [FieldOffset(0)]
        public LSA_FOREST_TRUST_BINARY_DATA BinaryData;
        /// <include file='_ForestTrustData_e__Union.xml' path='doc/member[@name="_ForestTrustData_e__Union.ScannerInfo"]/*'/>
        [FieldOffset(0)]
        public LSA_FOREST_TRUST_SCANNER_INFO ScannerInfo;
    }
}