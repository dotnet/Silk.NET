// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct LSA_FOREST_TRUST_RECORD
{
    [NativeTypeName("ULONG")]
    public uint Flags;
    public LSA_FOREST_TRUST_RECORD_TYPE ForestTrustType;
    public LARGE_INTEGER Time;

    [NativeTypeName("__AnonymousRecord_ntsecapi_L2716_C5")]
    public _ForestTrustData_e__Union ForestTrustData;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _ForestTrustData_e__Union
    {
        [FieldOffset(0)]
        public LSA_UNICODE_STRING TopLevelName;

        [FieldOffset(0)]
        public LSA_FOREST_TRUST_DOMAIN_INFO DomainInfo;

        [FieldOffset(0)]
        public LSA_FOREST_TRUST_BINARY_DATA Data;
    }
}
