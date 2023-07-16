// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='GamutBoundaryDescription.xml' path='doc/member[@name="GamutBoundaryDescription"]/*'/>
public unsafe partial struct GamutBoundaryDescription
{
    /// <include file='GamutBoundaryDescription.xml' path='doc/member[@name="GamutBoundaryDescription.pPrimaries"]/*'/>
    public PrimaryJabColors* pPrimaries;
    /// <include file='GamutBoundaryDescription.xml' path='doc/member[@name="GamutBoundaryDescription.cNeutralSamples"]/*'/>
    public uint cNeutralSamples;
    /// <include file='GamutBoundaryDescription.xml' path='doc/member[@name="GamutBoundaryDescription.pNeutralSamples"]/*'/>
    public JabColorF* pNeutralSamples;
    /// <include file='GamutBoundaryDescription.xml' path='doc/member[@name="GamutBoundaryDescription.pReferenceShell"]/*'/>
    public GamutShell* pReferenceShell;
    /// <include file='GamutBoundaryDescription.xml' path='doc/member[@name="GamutBoundaryDescription.pPlausibleShell"]/*'/>
    public GamutShell* pPlausibleShell;
    /// <include file='GamutBoundaryDescription.xml' path='doc/member[@name="GamutBoundaryDescription.pPossibleShell"]/*'/>
    public GamutShell* pPossibleShell;
}