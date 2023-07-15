// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VMRFrequency.xml' path='doc/member[@name="VMRFrequency"]/*'/>
public partial struct VMRFrequency
{
    /// <include file='VMRFrequency.xml' path='doc/member[@name="VMRFrequency.dwNumerator"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumerator;
    /// <include file='VMRFrequency.xml' path='doc/member[@name="VMRFrequency.dwDenominator"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDenominator;
}