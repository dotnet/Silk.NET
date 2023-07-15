// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CAUB.xml' path='doc/member[@name="CAUB"]/*'/>
public unsafe partial struct CAUB
{
    /// <include file='CAUB.xml' path='doc/member[@name="CAUB.cElems"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cElems;
    /// <include file='CAUB.xml' path='doc/member[@name="CAUB.pElems"]/*'/>
    [NativeTypeName("UCHAR *")]
    public byte* pElems;
}