// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CTL_USAGE_MATCH.xml' path='doc/member[@name="CTL_USAGE_MATCH"]/*'/>
public partial struct CTL_USAGE_MATCH
{
    /// <include file='CTL_USAGE_MATCH.xml' path='doc/member[@name="CTL_USAGE_MATCH.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='CTL_USAGE_MATCH.xml' path='doc/member[@name="CTL_USAGE_MATCH.Usage"]/*'/>
    public CTL_USAGE Usage;
}