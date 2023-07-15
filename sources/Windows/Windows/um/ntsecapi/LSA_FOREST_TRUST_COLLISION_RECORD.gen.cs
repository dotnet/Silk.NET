// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LSA_FOREST_TRUST_COLLISION_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_COLLISION_RECORD"]/*'/>
public partial struct LSA_FOREST_TRUST_COLLISION_RECORD
{
    /// <include file='LSA_FOREST_TRUST_COLLISION_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_COLLISION_RECORD.Index"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Index;
    /// <include file='LSA_FOREST_TRUST_COLLISION_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_COLLISION_RECORD.Type"]/*'/>
    public LSA_FOREST_TRUST_COLLISION_RECORD_TYPE Type;
    /// <include file='LSA_FOREST_TRUST_COLLISION_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_COLLISION_RECORD.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='LSA_FOREST_TRUST_COLLISION_RECORD.xml' path='doc/member[@name="LSA_FOREST_TRUST_COLLISION_RECORD.Name"]/*'/>
    public LSA_UNICODE_STRING Name;
}