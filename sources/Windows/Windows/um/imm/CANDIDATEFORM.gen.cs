// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CANDIDATEFORM.xml' path='doc/member[@name="CANDIDATEFORM"]/*'/>
public partial struct CANDIDATEFORM
{
    /// <include file='CANDIDATEFORM.xml' path='doc/member[@name="CANDIDATEFORM.dwIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIndex;
    /// <include file='CANDIDATEFORM.xml' path='doc/member[@name="CANDIDATEFORM.dwStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStyle;
    /// <include file='CANDIDATEFORM.xml' path='doc/member[@name="CANDIDATEFORM.ptCurrentPos"]/*'/>
    public POINT ptCurrentPos;
    /// <include file='CANDIDATEFORM.xml' path='doc/member[@name="CANDIDATEFORM.rcArea"]/*'/>
    public RECT rcArea;
}