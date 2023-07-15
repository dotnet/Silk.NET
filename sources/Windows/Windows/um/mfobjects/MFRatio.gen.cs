// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFRatio.xml' path='doc/member[@name="MFRatio"]/*'/>
public partial struct MFRatio
{
    /// <include file='MFRatio.xml' path='doc/member[@name="MFRatio.Numerator"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Numerator;
    /// <include file='MFRatio.xml' path='doc/member[@name="MFRatio.Denominator"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Denominator;
}