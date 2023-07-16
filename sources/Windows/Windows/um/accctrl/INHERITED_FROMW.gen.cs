// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='INHERITED_FROMW.xml' path='doc/member[@name="INHERITED_FROMW"]/*'/>
public unsafe partial struct INHERITED_FROMW
{
    /// <include file='INHERITED_FROMW.xml' path='doc/member[@name="INHERITED_FROMW.GenerationGap"]/*'/>
    [NativeTypeName("LONG")]
    public int GenerationGap;
    /// <include file='INHERITED_FROMW.xml' path='doc/member[@name="INHERITED_FROMW.AncestorName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* AncestorName;
}