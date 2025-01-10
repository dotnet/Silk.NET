// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KCRM_TRANSACTION_BLOB
{
    [NativeTypeName("UOW")]
    public Guid UOW;
    public Guid TmIdentity;

    [NativeTypeName("ULONG")]
    public uint IsolationLevel;

    [NativeTypeName("ULONG")]
    public uint IsolationFlags;

    [NativeTypeName("ULONG")]
    public uint Timeout;

    [NativeTypeName("WCHAR[64]")]
    public _Description_e__FixedBuffer Description;

    [InlineArray(64)]
    public partial struct _Description_e__FixedBuffer
    {
        public ushort e0;
    }
}
