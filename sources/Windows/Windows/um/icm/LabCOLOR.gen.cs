// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LabCOLOR.xml' path='doc/member[@name="LabCOLOR"]/*'/>
public partial struct LabCOLOR
{
    /// <include file='LabCOLOR.xml' path='doc/member[@name="LabCOLOR.L"]/*'/>
    [NativeTypeName("WORD")]
    public ushort L;
    /// <include file='LabCOLOR.xml' path='doc/member[@name="LabCOLOR.a"]/*'/>
    [NativeTypeName("WORD")]
    public ushort a;
    /// <include file='LabCOLOR.xml' path='doc/member[@name="LabCOLOR.b"]/*'/>
    [NativeTypeName("WORD")]
    public ushort b;
}