// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='YxyCOLOR.xml' path='doc/member[@name="YxyCOLOR"]/*'/>
public partial struct YxyCOLOR
{
    /// <include file='YxyCOLOR.xml' path='doc/member[@name="YxyCOLOR.Y"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Y;
    /// <include file='YxyCOLOR.xml' path='doc/member[@name="YxyCOLOR.x"]/*'/>
    [NativeTypeName("WORD")]
    public ushort x;
    /// <include file='YxyCOLOR.xml' path='doc/member[@name="YxyCOLOR.y"]/*'/>
    [NativeTypeName("WORD")]
    public ushort y;
}