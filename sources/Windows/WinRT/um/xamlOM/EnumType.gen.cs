// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.WinRT;
/// <include file='EnumType.xml' path='doc/member[@name="EnumType"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct EnumType
{
    /// <include file='EnumType.xml' path='doc/member[@name="EnumType.Name"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* Name;
    /// <include file='EnumType.xml' path='doc/member[@name="EnumType.ValueInts"]/*'/>
    public SAFEARRAY* ValueInts;
    /// <include file='EnumType.xml' path='doc/member[@name="EnumType.ValueStrings"]/*'/>
    public SAFEARRAY* ValueStrings;
}