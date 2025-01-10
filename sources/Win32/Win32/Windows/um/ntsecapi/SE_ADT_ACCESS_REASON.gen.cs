// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SE_ADT_ACCESS_REASON
{
    [NativeTypeName("ACCESS_MASK")]
    public uint AccessMask;

    [NativeTypeName("ULONG[32]")]
    public _AccessReasons_e__FixedBuffer AccessReasons;

    [NativeTypeName("ULONG")]
    public uint ObjectTypeIndex;

    [NativeTypeName("ULONG")]
    public uint AccessGranted;

    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* SecurityDescriptor;

    [InlineArray(32)]
    public partial struct _AccessReasons_e__FixedBuffer
    {
        public uint e0;
    }
}
