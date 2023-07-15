// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CTL_USAGE.xml' path='doc/member[@name="CTL_USAGE"]/*'/>
public unsafe partial struct CTL_USAGE
{
    /// <include file='CTL_USAGE.xml' path='doc/member[@name="CTL_USAGE.cUsageIdentifier"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cUsageIdentifier;
    /// <include file='CTL_USAGE.xml' path='doc/member[@name="CTL_USAGE.rgpszUsageIdentifier"]/*'/>
    [NativeTypeName("LPSTR *")]
    public sbyte** rgpszUsageIdentifier;
}