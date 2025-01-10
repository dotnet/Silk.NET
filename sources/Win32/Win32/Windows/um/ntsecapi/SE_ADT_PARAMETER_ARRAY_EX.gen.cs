// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SE_ADT_PARAMETER_ARRAY_EX
{
    [NativeTypeName("ULONG")]
    public uint CategoryId;

    [NativeTypeName("ULONG")]
    public uint AuditId;

    [NativeTypeName("ULONG")]
    public uint Version;

    [NativeTypeName("ULONG")]
    public uint ParameterCount;

    [NativeTypeName("ULONG")]
    public uint Length;
    public ushort FlatSubCategoryId;
    public ushort Type;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("SE_ADT_PARAMETER_ARRAY_ENTRY[32]")]
    public _Parameters_e__FixedBuffer Parameters;

    [InlineArray(32)]
    public partial struct _Parameters_e__FixedBuffer
    {
        public SE_ADT_PARAMETER_ARRAY_ENTRY e0;
    }
}
