// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3DCONTENTPROTECTIONCAPS
{
    [NativeTypeName("DWORD")]
    public uint Caps;
    public Guid KeyExchangeType;
    public uint BufferAlignmentStart;
    public uint BlockAlignmentSize;

    [NativeTypeName("ULONGLONG")]
    public ulong ProtectedMemorySize;
}
