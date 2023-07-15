// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GamutShell.xml' path='doc/member[@name="GamutShell"]/*'/>
public unsafe partial struct GamutShell
{
    /// <include file='GamutShell.xml' path='doc/member[@name="GamutShell.JMin"]/*'/>
    public float JMin;
    /// <include file='GamutShell.xml' path='doc/member[@name="GamutShell.JMax"]/*'/>
    public float JMax;
    /// <include file='GamutShell.xml' path='doc/member[@name="GamutShell.cVertices"]/*'/>
    public uint cVertices;
    /// <include file='GamutShell.xml' path='doc/member[@name="GamutShell.cTriangles"]/*'/>
    public uint cTriangles;
    /// <include file='GamutShell.xml' path='doc/member[@name="GamutShell.pVertices"]/*'/>
    public JabColorF* pVertices;
    /// <include file='GamutShell.xml' path='doc/member[@name="GamutShell.pTriangles"]/*'/>
    public GamutShellTriangle* pTriangles;
}