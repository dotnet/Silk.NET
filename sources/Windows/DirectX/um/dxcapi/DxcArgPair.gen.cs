// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
namespace Silk.NET.DirectX;
/// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair"]/*'/>
public unsafe partial struct DxcArgPair
{
    /// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair.pName"]/*'/>
    [NativeTypeName("const WCHAR *")]
    public ushort* pName;
    /// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair.pValue"]/*'/>
    [NativeTypeName("const WCHAR *")]
    public ushort* pValue;
}