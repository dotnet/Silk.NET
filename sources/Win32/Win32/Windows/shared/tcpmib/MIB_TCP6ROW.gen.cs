// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_TCP6ROW
{
    public MIB_TCP_STATE State;
    public IN6_ADDR LocalAddr;

    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;

    [NativeTypeName("DWORD")]
    public uint dwLocalPort;
    public IN6_ADDR RemoteAddr;

    [NativeTypeName("DWORD")]
    public uint dwRemoteScopeId;

    [NativeTypeName("DWORD")]
    public uint dwRemotePort;
}
