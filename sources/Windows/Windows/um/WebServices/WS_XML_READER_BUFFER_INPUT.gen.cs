// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_XML_READER_BUFFER_INPUT.xml' path='doc/member[@name="WS_XML_READER_BUFFER_INPUT"]/*'/>
public unsafe partial struct WS_XML_READER_BUFFER_INPUT
{
    /// <include file='WS_XML_READER_BUFFER_INPUT.xml' path='doc/member[@name="WS_XML_READER_BUFFER_INPUT.input"]/*'/>
    public WS_XML_READER_INPUT input;
    /// <include file='WS_XML_READER_BUFFER_INPUT.xml' path='doc/member[@name="WS_XML_READER_BUFFER_INPUT.encodedData"]/*'/>
    public void* encodedData;
    /// <include file='WS_XML_READER_BUFFER_INPUT.xml' path='doc/member[@name="WS_XML_READER_BUFFER_INPUT.encodedDataSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint encodedDataSize;
}