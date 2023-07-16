// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IP_ADAPTER_ORDER_MAP.xml' path='doc/member[@name="IP_ADAPTER_ORDER_MAP"]/*'/>
public unsafe partial struct IP_ADAPTER_ORDER_MAP
{
    /// <include file='IP_ADAPTER_ORDER_MAP.xml' path='doc/member[@name="IP_ADAPTER_ORDER_MAP.NumAdapters"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NumAdapters;
    /// <include file='IP_ADAPTER_ORDER_MAP.xml' path='doc/member[@name="IP_ADAPTER_ORDER_MAP.AdapterOrder"]/*'/>
    [NativeTypeName("ULONG[1]")]
    public fixed uint AdapterOrder[1];
}