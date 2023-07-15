// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION"]/*'/>
public unsafe partial struct WS_FIELD_DESCRIPTION
{
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.mapping"]/*'/>
    public WS_FIELD_MAPPING mapping;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.localName"]/*'/>
    public WS_XML_STRING* localName;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.ns"]/*'/>
    public WS_XML_STRING* ns;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.type"]/*'/>
    public WS_TYPE type;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.typeDescription"]/*'/>
    public void* typeDescription;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.offset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint offset;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.options"]/*'/>
    [NativeTypeName("ULONG")]
    public uint options;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.defaultValue"]/*'/>
    public WS_DEFAULT_VALUE* defaultValue;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.countOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint countOffset;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.itemLocalName"]/*'/>
    public WS_XML_STRING* itemLocalName;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.itemNs"]/*'/>
    public WS_XML_STRING* itemNs;
    /// <include file='WS_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_FIELD_DESCRIPTION.itemRange"]/*'/>
    public WS_ITEM_RANGE* itemRange;
}