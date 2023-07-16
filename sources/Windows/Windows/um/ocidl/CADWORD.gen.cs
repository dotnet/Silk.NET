// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CADWORD.xml' path='doc/member[@name="CADWORD"]/*'/>
public unsafe partial struct CADWORD
{
    /// <include file='CADWORD.xml' path='doc/member[@name="CADWORD.cElems"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cElems;
    /// <include file='CADWORD.xml' path='doc/member[@name="CADWORD.pElems"]/*'/>
    [NativeTypeName("DWORD *")]
    public uint* pElems;
}