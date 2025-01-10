// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_UDP6ROW_OWNER_PID
{
    [NativeTypeName("UCHAR[16]")]
    public _ucLocalAddr_e__FixedBuffer ucLocalAddr;

    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;

    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    [NativeTypeName("DWORD")]
    public uint dwOwningPid;

    [InlineArray(16)]
    public partial struct _ucLocalAddr_e__FixedBuffer
    {
        public byte e0;
    }
}
