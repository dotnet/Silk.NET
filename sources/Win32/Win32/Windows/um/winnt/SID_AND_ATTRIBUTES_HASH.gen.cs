// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SID_AND_ATTRIBUTES_HASH
{
    [NativeTypeName("DWORD")]
    public uint SidCount;

    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* SidAttr;

    [NativeTypeName("SID_HASH_ENTRY[32]")]
    public _Hash_e__FixedBuffer Hash;

    [InlineArray(32)]
    public partial struct _Hash_e__FixedBuffer
    {
        public nuint e0;
    }
}
