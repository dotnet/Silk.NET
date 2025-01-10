// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct DEVPROPERTY
{
    public DEVPROPCOMPKEY CompKey;

    [NativeTypeName("DEVPROPTYPE")]
    public uint Type;

    [NativeTypeName("ULONG")]
    public uint BufferSize;

    [NativeTypeName("PVOID")]
    public void* Buffer;
}
