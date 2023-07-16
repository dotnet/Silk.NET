// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_METADATA_ENDPOINTS.xml' path='doc/member[@name="WS_METADATA_ENDPOINTS"]/*'/>
public unsafe partial struct WS_METADATA_ENDPOINTS
{
    /// <include file='WS_METADATA_ENDPOINTS.xml' path='doc/member[@name="WS_METADATA_ENDPOINTS.endpoints"]/*'/>
    public WS_METADATA_ENDPOINT* endpoints;
    /// <include file='WS_METADATA_ENDPOINTS.xml' path='doc/member[@name="WS_METADATA_ENDPOINTS.endpointCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint endpointCount;
}