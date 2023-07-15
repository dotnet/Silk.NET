// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COORD.xml' path='doc/member[@name="COORD"]/*'/>
public partial struct COORD
{
    /// <include file='COORD.xml' path='doc/member[@name="COORD.X"]/*'/>
    public short X;
    /// <include file='COORD.xml' path='doc/member[@name="COORD.Y"]/*'/>
    public short Y;
}