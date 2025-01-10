// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SERVERSILO_BASIC_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint ServiceSessionId;
    public SERVERSILO_STATE State;

    [NativeTypeName("DWORD")]
    public uint ExitStatus;

    [NativeTypeName("BOOLEAN")]
    public byte Reserved;

    [NativeTypeName("PVOID")]
    public void* ApiSetSchema;

    [NativeTypeName("PVOID")]
    public void* HostApiSetSchema;

    [NativeTypeName("DWORD")]
    public uint ContainerBuildNumber;

    [NativeTypeName("DWORD")]
    public uint HostBuildNumber;
}
