// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SAFEARR_VARIANT.xml' path='doc/member[@name="SAFEARR_VARIANT"]/*'/>
public unsafe partial struct SAFEARR_VARIANT
{
    /// <include file='SAFEARR_VARIANT.xml' path='doc/member[@name="SAFEARR_VARIANT.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='SAFEARR_VARIANT.xml' path='doc/member[@name="SAFEARR_VARIANT.aVariant"]/*'/>
    [NativeTypeName("wireVARIANT *")]
    public _wireVARIANT** aVariant;
}