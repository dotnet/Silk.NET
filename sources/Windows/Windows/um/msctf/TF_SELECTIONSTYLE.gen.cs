// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TF_SELECTIONSTYLE.xml' path='doc/member[@name="TF_SELECTIONSTYLE"]/*'/>
public partial struct TF_SELECTIONSTYLE
{
    /// <include file='TF_SELECTIONSTYLE.xml' path='doc/member[@name="TF_SELECTIONSTYLE.ase"]/*'/>
    public TfActiveSelEnd ase;
    /// <include file='TF_SELECTIONSTYLE.xml' path='doc/member[@name="TF_SELECTIONSTYLE.fInterimChar"]/*'/>
    public BOOL fInterimChar;
}