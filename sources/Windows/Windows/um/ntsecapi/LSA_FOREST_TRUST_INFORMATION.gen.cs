// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LSA_FOREST_TRUST_INFORMATION.xml' path='doc/member[@name="LSA_FOREST_TRUST_INFORMATION"]/*' />
public unsafe partial struct LSA_FOREST_TRUST_INFORMATION
{
    /// <include file='LSA_FOREST_TRUST_INFORMATION.xml' path='doc/member[@name="LSA_FOREST_TRUST_INFORMATION.RecordCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint RecordCount;

    /// <include file='LSA_FOREST_TRUST_INFORMATION.xml' path='doc/member[@name="LSA_FOREST_TRUST_INFORMATION.Entries"]/*' />
    [NativeTypeName("PLSA_FOREST_TRUST_RECORD *")]
    public LSA_FOREST_TRUST_RECORD** Entries;
}
