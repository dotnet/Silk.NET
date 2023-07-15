// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.WinRT;
/// <include file='CollectionElementValue.xml' path='doc/member[@name="CollectionElementValue"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct CollectionElementValue
{
    /// <include file='CollectionElementValue.xml' path='doc/member[@name="CollectionElementValue.Index"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint Index;
    /// <include file='CollectionElementValue.xml' path='doc/member[@name="CollectionElementValue.ValueType"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* ValueType;
    /// <include file='CollectionElementValue.xml' path='doc/member[@name="CollectionElementValue.Value"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* Value;
    /// <include file='CollectionElementValue.xml' path='doc/member[@name="CollectionElementValue.MetadataBits"]/*'/>
    [NativeTypeName("long long")]
    public long MetadataBits;
}