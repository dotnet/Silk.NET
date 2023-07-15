// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMPGHOTITEM.xml' path='doc/member[@name="NMPGHOTITEM"]/*'/>
public partial struct NMPGHOTITEM
{
    /// <include file='NMPGHOTITEM.xml' path='doc/member[@name="NMPGHOTITEM.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMPGHOTITEM.xml' path='doc/member[@name="NMPGHOTITEM.idOld"]/*'/>
    public int idOld;
    /// <include file='NMPGHOTITEM.xml' path='doc/member[@name="NMPGHOTITEM.idNew"]/*'/>
    public int idNew;
    /// <include file='NMPGHOTITEM.xml' path='doc/member[@name="NMPGHOTITEM.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}