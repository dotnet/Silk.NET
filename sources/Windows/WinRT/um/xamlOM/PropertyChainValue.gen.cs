// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;
/// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct PropertyChainValue
{
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.Index"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint Index;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.Type"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* Type;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.DeclaringType"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* DeclaringType;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.ValueType"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* ValueType;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.ItemType"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* ItemType;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.Value"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* Value;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.Overridden"]/*'/>
    public BOOL Overridden;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.MetadataBits"]/*'/>
    [NativeTypeName("long long")]
    public long MetadataBits;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.PropertyName"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* PropertyName;
    /// <include file='PropertyChainValue.xml' path='doc/member[@name="PropertyChainValue.PropertyChainIndex"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint PropertyChainIndex;
}