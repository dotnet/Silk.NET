// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SecPkgContext_EapKeyBlock.xml' path='doc/member[@name="SecPkgContext_EapKeyBlock"]/*'/>
public unsafe partial struct SecPkgContext_EapKeyBlock
{
    /// <include file='SecPkgContext_EapKeyBlock.xml' path='doc/member[@name="SecPkgContext_EapKeyBlock.rgbKeys"]/*'/>
    [NativeTypeName("BYTE[128]")]
    public fixed byte rgbKeys[128];
    /// <include file='SecPkgContext_EapKeyBlock.xml' path='doc/member[@name="SecPkgContext_EapKeyBlock.rgbIVs"]/*'/>
    [NativeTypeName("BYTE[64]")]
    public fixed byte rgbIVs[64];
}