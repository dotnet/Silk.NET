// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SecPkgContext_SrtpParameters.xml' path='doc/member[@name="SecPkgContext_SrtpParameters"]/*'/>
public unsafe partial struct SecPkgContext_SrtpParameters
{
    /// <include file='SecPkgContext_SrtpParameters.xml' path='doc/member[@name="SecPkgContext_SrtpParameters.ProtectionProfile"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ProtectionProfile;
    /// <include file='SecPkgContext_SrtpParameters.xml' path='doc/member[@name="SecPkgContext_SrtpParameters.MasterKeyIdentifierSize"]/*'/>
    public byte MasterKeyIdentifierSize;
    /// <include file='SecPkgContext_SrtpParameters.xml' path='doc/member[@name="SecPkgContext_SrtpParameters.MasterKeyIdentifier"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* MasterKeyIdentifier;
}