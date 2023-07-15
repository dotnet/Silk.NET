// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMTVDISPINFOA.xml' path='doc/member[@name="NMTVDISPINFOA"]/*'/>
public partial struct NMTVDISPINFOA
{
    /// <include file='NMTVDISPINFOA.xml' path='doc/member[@name="NMTVDISPINFOA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTVDISPINFOA.xml' path='doc/member[@name="NMTVDISPINFOA.item"]/*'/>
    public TVITEMA item;
}