// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SecPkgContext_MappedCredAttr.xml' path='doc/member[@name="SecPkgContext_MappedCredAttr"]/*'/>
public unsafe partial struct SecPkgContext_MappedCredAttr
{
    /// <include file='SecPkgContext_MappedCredAttr.xml' path='doc/member[@name="SecPkgContext_MappedCredAttr.dwAttribute"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAttribute;
    /// <include file='SecPkgContext_MappedCredAttr.xml' path='doc/member[@name="SecPkgContext_MappedCredAttr.pvBuffer"]/*'/>
    [NativeTypeName("PVOID")]
    public void* pvBuffer;
}