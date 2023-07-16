// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;
/// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP"]/*'/>
public unsafe partial struct BASEBROWSERDATAXP
{
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._hwnd"]/*'/>
    public HWND _hwnd;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._ptl"]/*'/>
    public ITravelLog* _ptl;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._phlf"]/*'/>
    public IHlinkFrame* _phlf;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pautoWB2"]/*'/>
    public IWebBrowser2* _pautoWB2;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pautoEDS"]/*'/>
    public IExpDispSupportXP* _pautoEDS;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pautoSS"]/*'/>
    public IShellService* _pautoSS;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._eSecureLockIcon"]/*'/>
    public int _eSecureLockIcon;
    public uint _bitfield;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._fCreatingViewWindow"]/*'/>
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

    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._uActivateState"]/*'/>
    public uint _uActivateState;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pidlViewState"]/*'/>
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* _pidlViewState;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pctView"]/*'/>
    public IOleCommandTarget* _pctView;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pidlCur"]/*'/>
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* _pidlCur;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._psv"]/*'/>
    public IShellView* _psv;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._psf"]/*'/>
    public IShellFolder* _psf;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._hwndView"]/*'/>
    public HWND _hwndView;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pszTitleCur"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* _pszTitleCur;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pidlPending"]/*'/>
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* _pidlPending;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._psvPending"]/*'/>
    public IShellView* _psvPending;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._psfPending"]/*'/>
    public IShellFolder* _psfPending;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._hwndViewPending"]/*'/>
    public HWND _hwndViewPending;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._pszTitlePending"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* _pszTitlePending;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._fIsViewMSHTML"]/*'/>
    public BOOL _fIsViewMSHTML;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._fPrivacyImpacted"]/*'/>
    public BOOL _fPrivacyImpacted;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._clsidView"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid _clsidView;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._clsidViewPending"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid _clsidViewPending;
    /// <include file='BASEBROWSERDATAXP.xml' path='doc/member[@name="BASEBROWSERDATAXP._hwndFrame"]/*'/>
    public HWND _hwndFrame;
}