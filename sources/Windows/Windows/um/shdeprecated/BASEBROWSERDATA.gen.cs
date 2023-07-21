// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;

/// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA"]/*' />
public unsafe partial struct BASEBROWSERDATA
{
    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._hwnd"]/*' />
    public HWND _hwnd;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._ptl"]/*' />
    public ITravelLog* _ptl;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._phlf"]/*' />
    public IHlinkFrame* _phlf;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pautoWB2"]/*' />
    public IWebBrowser2* _pautoWB2;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pautoEDS"]/*' />
    public IExpDispSupport* _pautoEDS;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pautoSS"]/*' />
    public IShellService* _pautoSS;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._eSecureLockIcon"]/*' />
    public int _eSecureLockIcon;

    public uint _bitfield;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._fCreatingViewWindow"]/*' />
    [NativeTypeName("uint : 1")]
    public uint _fCreatingViewWindow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
        }
    }

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._uActivateState"]/*' />
    public uint _uActivateState;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pidlViewState"]/*' />
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* _pidlViewState;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pctView"]/*' />
    public IOleCommandTarget* _pctView;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pidlCur"]/*' />
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* _pidlCur;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._psv"]/*' />
    public IShellView* _psv;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._psf"]/*' />
    public IShellFolder* _psf;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._hwndView"]/*' />
    public HWND _hwndView;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pszTitleCur"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* _pszTitleCur;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pidlPending"]/*' />
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* _pidlPending;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._psvPending"]/*' />
    public IShellView* _psvPending;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._psfPending"]/*' />
    public IShellFolder* _psfPending;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._hwndViewPending"]/*' />
    public HWND _hwndViewPending;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._pszTitlePending"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* _pszTitlePending;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._fIsViewMSHTML"]/*' />
    public BOOL _fIsViewMSHTML;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._fPrivacyImpacted"]/*' />
    public BOOL _fPrivacyImpacted;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._clsidView"]/*' />
    [NativeTypeName("CLSID")]
    public Guid _clsidView;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._clsidViewPending"]/*' />
    [NativeTypeName("CLSID")]
    public Guid _clsidViewPending;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._hwndFrame"]/*' />
    public HWND _hwndFrame;

    /// <include file='BASEBROWSERDATA.xml' path='doc/member[@name="BASEBROWSERDATA._lPhishingFilterStatus"]/*' />
    [NativeTypeName("LONG")]
    public int _lPhishingFilterStatus;
}
