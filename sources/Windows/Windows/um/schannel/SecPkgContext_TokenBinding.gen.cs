// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SecPkgContext_TokenBinding.xml' path='doc/member[@name="SecPkgContext_TokenBinding"]/*'/>
public unsafe partial struct SecPkgContext_TokenBinding
{
    /// <include file='SecPkgContext_TokenBinding.xml' path='doc/member[@name="SecPkgContext_TokenBinding.MajorVersion"]/*'/>
    public byte MajorVersion;
    /// <include file='SecPkgContext_TokenBinding.xml' path='doc/member[@name="SecPkgContext_TokenBinding.MinorVersion"]/*'/>
    public byte MinorVersion;
    /// <include file='SecPkgContext_TokenBinding.xml' path='doc/member[@name="SecPkgContext_TokenBinding.KeyParametersSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort KeyParametersSize;
    /// <include file='SecPkgContext_TokenBinding.xml' path='doc/member[@name="SecPkgContext_TokenBinding.KeyParameters"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* KeyParameters;
}