// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CAPROPVARIANT.xml' path='doc/member[@name="CAPROPVARIANT"]/*'/>
public unsafe partial struct CAPROPVARIANT
{
    /// <include file='CAPROPVARIANT.xml' path='doc/member[@name="CAPROPVARIANT.cElems"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cElems;
    /// <include file='CAPROPVARIANT.xml' path='doc/member[@name="CAPROPVARIANT.pElems"]/*'/>
    public PROPVARIANT* pElems;
}