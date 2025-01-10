// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct HTTP_CHANNEL_BIND_INFO
{
    public HTTP_AUTHENTICATION_HARDENING_LEVELS Hardening;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("PHTTP_SERVICE_BINDING_BASE *")]
    public HTTP_SERVICE_BINDING_BASE** ServiceNames;

    [NativeTypeName("ULONG")]
    public uint NumberOfServiceNames;
}
