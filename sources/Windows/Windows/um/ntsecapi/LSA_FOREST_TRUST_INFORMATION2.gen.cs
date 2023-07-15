// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LSA_FOREST_TRUST_INFORMATION2.xml' path='doc/member[@name="LSA_FOREST_TRUST_INFORMATION2"]/*'/>
public unsafe partial struct LSA_FOREST_TRUST_INFORMATION2
{
    /// <include file='LSA_FOREST_TRUST_INFORMATION2.xml' path='doc/member[@name="LSA_FOREST_TRUST_INFORMATION2.RecordCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RecordCount;
    /// <include file='LSA_FOREST_TRUST_INFORMATION2.xml' path='doc/member[@name="LSA_FOREST_TRUST_INFORMATION2.Entries"]/*'/>
    [NativeTypeName("PLSA_FOREST_TRUST_RECORD2 *")]
    public LSA_FOREST_TRUST_RECORD2** Entries;
}