// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct LSA_FOREST_TRUST_COLLISION_RECORD
{
    [NativeTypeName("ULONG")]
    public uint Index;
    public LSA_FOREST_TRUST_COLLISION_RECORD_TYPE Type;

    [NativeTypeName("ULONG")]
    public uint Flags;
    public LSA_UNICODE_STRING Name;
}
