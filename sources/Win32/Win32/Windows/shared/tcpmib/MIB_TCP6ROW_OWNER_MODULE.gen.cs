// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_TCP6ROW_OWNER_MODULE
{
    [NativeTypeName("UCHAR[16]")]
    public _ucLocalAddr_e__FixedBuffer ucLocalAddr;

    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;

    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    [NativeTypeName("UCHAR[16]")]
    public _ucRemoteAddr_e__FixedBuffer ucRemoteAddr;

    [NativeTypeName("DWORD")]
    public uint dwRemoteScopeId;

    [NativeTypeName("DWORD")]
    public uint dwRemotePort;

    [NativeTypeName("DWORD")]
    public uint dwState;

    [NativeTypeName("DWORD")]
    public uint dwOwningPid;
    public LARGE_INTEGER liCreateTimestamp;

    [NativeTypeName("ULONGLONG[16]")]
    public _OwningModuleInfo_e__FixedBuffer OwningModuleInfo;

    [InlineArray(16)]
    public partial struct _ucLocalAddr_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _ucRemoteAddr_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _OwningModuleInfo_e__FixedBuffer
    {
        public ulong e0;
    }
}
