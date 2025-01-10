// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_TIER
{
    public Guid Id;

    [NativeTypeName("WCHAR[256]")]
    public _Name_e__FixedBuffer Name;

    [NativeTypeName("WCHAR[256]")]
    public _Description_e__FixedBuffer Description;

    [NativeTypeName("DWORDLONG")]
    public ulong Flags;

    [NativeTypeName("DWORDLONG")]
    public ulong ProvisionedCapacity;
    public STORAGE_TIER_MEDIA_TYPE MediaType;
    public STORAGE_TIER_CLASS Class;

    [InlineArray(256)]
    public partial struct _Name_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(256)]
    public partial struct _Description_e__FixedBuffer
    {
        public ushort e0;
    }
}
