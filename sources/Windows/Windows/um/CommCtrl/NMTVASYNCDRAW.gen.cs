// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTVASYNCDRAW.xml' path='doc/member[@name="NMTVASYNCDRAW"]/*' />
public unsafe partial struct NMTVASYNCDRAW
{
    /// <include file='NMTVASYNCDRAW.xml' path='doc/member[@name="NMTVASYNCDRAW.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTVASYNCDRAW.xml' path='doc/member[@name="NMTVASYNCDRAW.pimldp"]/*' />
    public IMAGELISTDRAWPARAMS* pimldp;

    /// <include file='NMTVASYNCDRAW.xml' path='doc/member[@name="NMTVASYNCDRAW.hr"]/*' />
    public HRESULT hr;

    /// <include file='NMTVASYNCDRAW.xml' path='doc/member[@name="NMTVASYNCDRAW.hItem"]/*' />
    public HTREEITEM hItem;

    /// <include file='NMTVASYNCDRAW.xml' path='doc/member[@name="NMTVASYNCDRAW.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='NMTVASYNCDRAW.xml' path='doc/member[@name="NMTVASYNCDRAW.dwRetFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRetFlags;

    /// <include file='NMTVASYNCDRAW.xml' path='doc/member[@name="NMTVASYNCDRAW.iRetImageIndex"]/*' />
    public int iRetImageIndex;
}
