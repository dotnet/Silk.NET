// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public unsafe partial struct DXGI_INFO_QUEUE_MESSAGE
{
    [NativeTypeName("DXGI_DEBUG_ID")]
    public Guid Producer;
    public DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category;
    public DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity;

    [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")]
    public int ID;

    [NativeTypeName("const char *")]
    public sbyte* pDescription;

    [NativeTypeName("SIZE_T")]
    public nuint DescriptionByteLength;
}
