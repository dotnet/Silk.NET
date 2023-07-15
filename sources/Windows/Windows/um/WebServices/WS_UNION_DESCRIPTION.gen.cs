// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_UNION_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_DESCRIPTION"]/*'/>
public unsafe partial struct WS_UNION_DESCRIPTION
{
    /// <include file='WS_UNION_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_DESCRIPTION.size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint size;
    /// <include file='WS_UNION_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_DESCRIPTION.alignment"]/*'/>
    [NativeTypeName("ULONG")]
    public uint alignment;
    /// <include file='WS_UNION_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_DESCRIPTION.fields"]/*'/>
    public WS_UNION_FIELD_DESCRIPTION** fields;
    /// <include file='WS_UNION_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_DESCRIPTION.fieldCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fieldCount;
    /// <include file='WS_UNION_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_DESCRIPTION.enumOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint enumOffset;
    /// <include file='WS_UNION_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_DESCRIPTION.noneEnumValue"]/*'/>
    public int noneEnumValue;
    /// <include file='WS_UNION_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_DESCRIPTION.valueIndices"]/*'/>
    [NativeTypeName("ULONG *")]
    public uint* valueIndices;
}