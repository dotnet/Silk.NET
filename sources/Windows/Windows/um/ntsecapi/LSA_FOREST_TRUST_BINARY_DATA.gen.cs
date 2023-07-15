// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LSA_FOREST_TRUST_BINARY_DATA.xml' path='doc/member[@name="LSA_FOREST_TRUST_BINARY_DATA"]/*'/>
public unsafe partial struct LSA_FOREST_TRUST_BINARY_DATA
{
    /// <include file='LSA_FOREST_TRUST_BINARY_DATA.xml' path='doc/member[@name="LSA_FOREST_TRUST_BINARY_DATA.Length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Length;
    /// <include file='LSA_FOREST_TRUST_BINARY_DATA.xml' path='doc/member[@name="LSA_FOREST_TRUST_BINARY_DATA.Buffer"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* Buffer;
}