// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CALPOLESTR.xml' path='doc/member[@name="CALPOLESTR"]/*'/>
public unsafe partial struct CALPOLESTR
{
    /// <include file='CALPOLESTR.xml' path='doc/member[@name="CALPOLESTR.cElems"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cElems;
    /// <include file='CALPOLESTR.xml' path='doc/member[@name="CALPOLESTR.pElems"]/*'/>
    [NativeTypeName("LPOLESTR *")]
    public ushort** pElems;
}