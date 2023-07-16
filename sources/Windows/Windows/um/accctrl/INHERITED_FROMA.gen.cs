// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='INHERITED_FROMA.xml' path='doc/member[@name="INHERITED_FROMA"]/*'/>
public unsafe partial struct INHERITED_FROMA
{
    /// <include file='INHERITED_FROMA.xml' path='doc/member[@name="INHERITED_FROMA.GenerationGap"]/*'/>
    [NativeTypeName("LONG")]
    public int GenerationGap;
    /// <include file='INHERITED_FROMA.xml' path='doc/member[@name="INHERITED_FROMA.AncestorName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* AncestorName;
}