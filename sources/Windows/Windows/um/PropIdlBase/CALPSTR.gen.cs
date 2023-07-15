// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CALPSTR.xml' path='doc/member[@name="CALPSTR"]/*'/>
public unsafe partial struct CALPSTR
{
    /// <include file='CALPSTR.xml' path='doc/member[@name="CALPSTR.cElems"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cElems;
    /// <include file='CALPSTR.xml' path='doc/member[@name="CALPSTR.pElems"]/*'/>
    [NativeTypeName("LPSTR *")]
    public sbyte** pElems;
}