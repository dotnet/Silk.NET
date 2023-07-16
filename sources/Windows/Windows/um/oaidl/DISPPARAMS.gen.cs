// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPPARAMS.xml' path='doc/member[@name="DISPPARAMS"]/*'/>
public unsafe partial struct DISPPARAMS
{
    /// <include file='DISPPARAMS.xml' path='doc/member[@name="DISPPARAMS.rgvarg"]/*'/>
    [NativeTypeName("VARIANTARG *")]
    public VARIANT* rgvarg;
    /// <include file='DISPPARAMS.xml' path='doc/member[@name="DISPPARAMS.rgdispidNamedArgs"]/*'/>
    [NativeTypeName("DISPID *")]
    public int* rgdispidNamedArgs;
    /// <include file='DISPPARAMS.xml' path='doc/member[@name="DISPPARAMS.cArgs"]/*'/>
    public uint cArgs;
    /// <include file='DISPPARAMS.xml' path='doc/member[@name="DISPPARAMS.cNamedArgs"]/*'/>
    public uint cNamedArgs;
}