// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PARAMDESCEX.xml' path='doc/member[@name="PARAMDESCEX"]/*'/>
public partial struct PARAMDESCEX
{
    /// <include file='PARAMDESCEX.xml' path='doc/member[@name="PARAMDESCEX.cBytes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cBytes;
    /// <include file='PARAMDESCEX.xml' path='doc/member[@name="PARAMDESCEX.varDefaultValue"]/*'/>
    [NativeTypeName("VARIANTARG")]
    public VARIANT varDefaultValue;
}