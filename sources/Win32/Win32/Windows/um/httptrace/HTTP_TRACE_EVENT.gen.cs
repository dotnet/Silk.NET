// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct HTTP_TRACE_EVENT
{
    [NativeTypeName("LPCGUID")]
    public Guid* pProviderGuid;

    [NativeTypeName("DWORD")]
    public uint dwArea;

    [NativeTypeName("LPCGUID")]
    public Guid* pAreaGuid;

    [NativeTypeName("DWORD")]
    public uint dwEvent;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszEventName;

    [NativeTypeName("DWORD")]
    public uint dwEventVersion;

    [NativeTypeName("DWORD")]
    public uint dwVerbosity;

    [NativeTypeName("LPCGUID")]
    public Guid* pActivityGuid;

    [NativeTypeName("LPCGUID")]
    public Guid* pRelatedActivityGuid;

    [NativeTypeName("DWORD")]
    public uint dwTimeStamp;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint cEventItems;

    [NativeTypeName("struct HTTP_TRACE_EVENT_ITEM *")]
    public HTTP_TRACE_EVENT_ITEM* pEventItems;
}
