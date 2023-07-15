// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='MilMatrix3x2D.xml' path='doc/member[@name="MilMatrix3x2D"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MilMatrix3x2D
{
    /// <include file='MilMatrix3x2D.xml' path='doc/member[@name="MilMatrix3x2D.S_11"]/*'/>
    public double S_11;
    /// <include file='MilMatrix3x2D.xml' path='doc/member[@name="MilMatrix3x2D.S_12"]/*'/>
    public double S_12;
    /// <include file='MilMatrix3x2D.xml' path='doc/member[@name="MilMatrix3x2D.S_21"]/*'/>
    public double S_21;
    /// <include file='MilMatrix3x2D.xml' path='doc/member[@name="MilMatrix3x2D.S_22"]/*'/>
    public double S_22;
    /// <include file='MilMatrix3x2D.xml' path='doc/member[@name="MilMatrix3x2D.DX"]/*'/>
    public double DX;
    /// <include file='MilMatrix3x2D.xml' path='doc/member[@name="MilMatrix3x2D.DY"]/*'/>
    public double DY;
}