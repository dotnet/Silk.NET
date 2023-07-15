// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COMPOSITIONFORM.xml' path='doc/member[@name="COMPOSITIONFORM"]/*'/>
public partial struct COMPOSITIONFORM
{
    /// <include file='COMPOSITIONFORM.xml' path='doc/member[@name="COMPOSITIONFORM.dwStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStyle;
    /// <include file='COMPOSITIONFORM.xml' path='doc/member[@name="COMPOSITIONFORM.ptCurrentPos"]/*'/>
    public POINT ptCurrentPos;
    /// <include file='COMPOSITIONFORM.xml' path='doc/member[@name="COMPOSITIONFORM.rcArea"]/*'/>
    public RECT rcArea;
}