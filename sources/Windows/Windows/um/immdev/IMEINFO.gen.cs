// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMEINFO.xml' path='doc/member[@name="IMEINFO"]/*'/>
public partial struct IMEINFO
{
    /// <include file='IMEINFO.xml' path='doc/member[@name="IMEINFO.dwPrivateDataSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPrivateDataSize;
    /// <include file='IMEINFO.xml' path='doc/member[@name="IMEINFO.fdwProperty"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwProperty;
    /// <include file='IMEINFO.xml' path='doc/member[@name="IMEINFO.fdwConversionCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwConversionCaps;
    /// <include file='IMEINFO.xml' path='doc/member[@name="IMEINFO.fdwSentenceCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwSentenceCaps;
    /// <include file='IMEINFO.xml' path='doc/member[@name="IMEINFO.fdwUICaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwUICaps;
    /// <include file='IMEINFO.xml' path='doc/member[@name="IMEINFO.fdwSCSCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwSCSCaps;
    /// <include file='IMEINFO.xml' path='doc/member[@name="IMEINFO.fdwSelectCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwSelectCaps;
}