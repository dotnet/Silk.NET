// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public partial struct WS_HTTP_HEADER_MAPPING
{
    public const int WS_HTTP_HEADER_MAPPING_COMMA_SEPARATOR = 0x1;
    public const int WS_HTTP_HEADER_MAPPING_SEMICOLON_SEPARATOR = 0x2;
    public const int WS_HTTP_HEADER_MAPPING_QUOTED_VALUE = 0x4;
    /// <include file='WS_HTTP_HEADER_MAPPING.xml' path='doc/member[@name="WS_HTTP_HEADER_MAPPING.headerName"]/*'/>
    public WS_XML_STRING headerName;
    /// <include file='WS_HTTP_HEADER_MAPPING.xml' path='doc/member[@name="WS_HTTP_HEADER_MAPPING.headerMappingOptions"]/*'/>
    [NativeTypeName("ULONG")]
    public uint headerMappingOptions;
}