// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_XML_STRING_DESCRIPTION.xml' path='doc/member[@name="WS_XML_STRING_DESCRIPTION"]/*'/>
public partial struct WS_XML_STRING_DESCRIPTION
{
    /// <include file='WS_XML_STRING_DESCRIPTION.xml' path='doc/member[@name="WS_XML_STRING_DESCRIPTION.minByteCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint minByteCount;
    /// <include file='WS_XML_STRING_DESCRIPTION.xml' path='doc/member[@name="WS_XML_STRING_DESCRIPTION.maxByteCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint maxByteCount;
}