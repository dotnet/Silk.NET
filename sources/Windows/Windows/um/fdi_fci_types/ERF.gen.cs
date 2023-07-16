// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fdi_fci_types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ERF.xml' path='doc/member[@name="ERF"]/*'/>
public partial struct ERF
{
    /// <include file='ERF.xml' path='doc/member[@name="ERF.erfOper"]/*'/>
    public int erfOper;
    /// <include file='ERF.xml' path='doc/member[@name="ERF.erfType"]/*'/>
    public int erfType;
    /// <include file='ERF.xml' path='doc/member[@name="ERF.fError"]/*'/>
    public BOOL fError;
}