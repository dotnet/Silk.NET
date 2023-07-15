// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMTVDISPINFOW.xml' path='doc/member[@name="NMTVDISPINFOW"]/*'/>
public partial struct NMTVDISPINFOW
{
    /// <include file='NMTVDISPINFOW.xml' path='doc/member[@name="NMTVDISPINFOW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTVDISPINFOW.xml' path='doc/member[@name="NMTVDISPINFOW.item"]/*'/>
    public TVITEMW item;
}