// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IP_ADAPTER_INDEX_MAP.xml' path='doc/member[@name="IP_ADAPTER_INDEX_MAP"]/*'/>
public unsafe partial struct IP_ADAPTER_INDEX_MAP
{
    /// <include file='IP_ADAPTER_INDEX_MAP.xml' path='doc/member[@name="IP_ADAPTER_INDEX_MAP.Index"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Index;
    /// <include file='IP_ADAPTER_INDEX_MAP.xml' path='doc/member[@name="IP_ADAPTER_INDEX_MAP.Name"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort Name[128];
}