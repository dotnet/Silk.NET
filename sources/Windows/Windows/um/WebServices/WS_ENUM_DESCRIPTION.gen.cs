// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_ENUM_DESCRIPTION.xml' path='doc/member[@name="WS_ENUM_DESCRIPTION"]/*'/>
public unsafe partial struct WS_ENUM_DESCRIPTION
{
    /// <include file='WS_ENUM_DESCRIPTION.xml' path='doc/member[@name="WS_ENUM_DESCRIPTION.values"]/*'/>
    public WS_ENUM_VALUE* values;
    /// <include file='WS_ENUM_DESCRIPTION.xml' path='doc/member[@name="WS_ENUM_DESCRIPTION.valueCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint valueCount;
    /// <include file='WS_ENUM_DESCRIPTION.xml' path='doc/member[@name="WS_ENUM_DESCRIPTION.maxByteCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint maxByteCount;
    /// <include file='WS_ENUM_DESCRIPTION.xml' path='doc/member[@name="WS_ENUM_DESCRIPTION.nameIndices"]/*'/>
    [NativeTypeName("ULONG *")]
    public uint* nameIndices;
}