// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMC_ADD_EXTENSIONS_INFO.xml' path='doc/member[@name="CMC_ADD_EXTENSIONS_INFO"]/*'/>
public unsafe partial struct CMC_ADD_EXTENSIONS_INFO
{
    /// <include file='CMC_ADD_EXTENSIONS_INFO.xml' path='doc/member[@name="CMC_ADD_EXTENSIONS_INFO.dwCmcDataReference"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCmcDataReference;
    /// <include file='CMC_ADD_EXTENSIONS_INFO.xml' path='doc/member[@name="CMC_ADD_EXTENSIONS_INFO.cCertReference"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCertReference;
    /// <include file='CMC_ADD_EXTENSIONS_INFO.xml' path='doc/member[@name="CMC_ADD_EXTENSIONS_INFO.rgdwCertReference"]/*'/>
    [NativeTypeName("DWORD *")]
    public uint* rgdwCertReference;
    /// <include file='CMC_ADD_EXTENSIONS_INFO.xml' path='doc/member[@name="CMC_ADD_EXTENSIONS_INFO.cExtension"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExtension;
    /// <include file='CMC_ADD_EXTENSIONS_INFO.xml' path='doc/member[@name="CMC_ADD_EXTENSIONS_INFO.rgExtension"]/*'/>
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}