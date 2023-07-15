// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFVideoArea.xml' path='doc/member[@name="MFVideoArea"]/*'/>
public partial struct MFVideoArea
{
    /// <include file='MFVideoArea.xml' path='doc/member[@name="MFVideoArea.OffsetX"]/*'/>
    public MFOffset OffsetX;
    /// <include file='MFVideoArea.xml' path='doc/member[@name="MFVideoArea.OffsetY"]/*'/>
    public MFOffset OffsetY;
    /// <include file='MFVideoArea.xml' path='doc/member[@name="MFVideoArea.Area"]/*'/>
    public SIZE Area;
}