// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.xml' path='doc/member[@name="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS"]/*'/>
public unsafe partial struct IP_UNIDIRECTIONAL_ADAPTER_ADDRESS
{
    /// <include file='IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.xml' path='doc/member[@name="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.NumAdapters"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NumAdapters;
    /// <include file='IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.xml' path='doc/member[@name="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS.Address"]/*'/>
    [NativeTypeName("IPAddr[1]")]
    public fixed uint Address[1];
}