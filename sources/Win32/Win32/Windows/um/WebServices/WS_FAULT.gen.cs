// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_FAULT
{
    public WS_FAULT_CODE* code;
    public WS_FAULT_REASON* reasons;

    [NativeTypeName("ULONG")]
    public uint reasonCount;
    public WS_STRING actor;
    public WS_STRING node;

    [NativeTypeName("WS_XML_BUFFER*")]
    public void* detail;
}
