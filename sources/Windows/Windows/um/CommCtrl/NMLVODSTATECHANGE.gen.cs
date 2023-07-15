// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMLVODSTATECHANGE.xml' path='doc/member[@name="NMLVODSTATECHANGE"]/*'/>
public partial struct NMLVODSTATECHANGE
{
    /// <include file='NMLVODSTATECHANGE.xml' path='doc/member[@name="NMLVODSTATECHANGE.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLVODSTATECHANGE.xml' path='doc/member[@name="NMLVODSTATECHANGE.iFrom"]/*'/>
    public int iFrom;
    /// <include file='NMLVODSTATECHANGE.xml' path='doc/member[@name="NMLVODSTATECHANGE.iTo"]/*'/>
    public int iTo;
    /// <include file='NMLVODSTATECHANGE.xml' path='doc/member[@name="NMLVODSTATECHANGE.uNewState"]/*'/>
    public uint uNewState;
    /// <include file='NMLVODSTATECHANGE.xml' path='doc/member[@name="NMLVODSTATECHANGE.uOldState"]/*'/>
    public uint uOldState;
}