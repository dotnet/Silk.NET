// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ACCESS_DENIED_OBJECT_ACE
{
    public ACE_HEADER Header;

    [NativeTypeName("ACCESS_MASK")]
    public uint Mask;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public Guid ObjectType;
    public Guid InheritedObjectType;

    [NativeTypeName("DWORD")]
    public uint SidStart;
}
