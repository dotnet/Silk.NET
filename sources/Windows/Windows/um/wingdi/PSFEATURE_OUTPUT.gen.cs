// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PSFEATURE_OUTPUT.xml' path='doc/member[@name="PSFEATURE_OUTPUT"]/*'/>
public partial struct PSFEATURE_OUTPUT
{
    /// <include file='PSFEATURE_OUTPUT.xml' path='doc/member[@name="PSFEATURE_OUTPUT.bPageIndependent"]/*'/>
    public BOOL bPageIndependent;
    /// <include file='PSFEATURE_OUTPUT.xml' path='doc/member[@name="PSFEATURE_OUTPUT.bSetPageDevice"]/*'/>
    public BOOL bSetPageDevice;
}