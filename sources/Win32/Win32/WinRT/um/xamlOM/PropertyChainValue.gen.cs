// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[SupportedOSPlatform("windows10.0")]
public unsafe partial struct PropertyChainValue
{
    [NativeTypeName("unsigned int")]
    public uint Index;

    [NativeTypeName("BSTR")]
    public ushort* Type;

    [NativeTypeName("BSTR")]
    public ushort* DeclaringType;

    [NativeTypeName("BSTR")]
    public ushort* ValueType;

    [NativeTypeName("BSTR")]
    public ushort* ItemType;

    [NativeTypeName("BSTR")]
    public ushort* Value;
    public BOOL Overridden;

    [NativeTypeName("long long")]
    public long MetadataBits;

    [NativeTypeName("BSTR")]
    public ushort* PropertyName;

    [NativeTypeName("unsigned int")]
    public uint PropertyChainIndex;
}
