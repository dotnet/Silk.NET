// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMRBAUTOSIZE.xml' path='doc/member[@name="NMRBAUTOSIZE"]/*'/>
public partial struct NMRBAUTOSIZE
{
    /// <include file='NMRBAUTOSIZE.xml' path='doc/member[@name="NMRBAUTOSIZE.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMRBAUTOSIZE.xml' path='doc/member[@name="NMRBAUTOSIZE.fChanged"]/*'/>
    public BOOL fChanged;
    /// <include file='NMRBAUTOSIZE.xml' path='doc/member[@name="NMRBAUTOSIZE.rcTarget"]/*'/>
    public RECT rcTarget;
    /// <include file='NMRBAUTOSIZE.xml' path='doc/member[@name="NMRBAUTOSIZE.rcActual"]/*'/>
    public RECT rcActual;
}