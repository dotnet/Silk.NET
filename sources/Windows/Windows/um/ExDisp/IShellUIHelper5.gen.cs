// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IShellUIHelper5.xml' path='doc/member[@name="IShellUIHelper5"]/*'/>
[Guid("A2A08B09-103D-4D3F-B91C-EA455CA82EFA")]
[NativeTypeName("struct IShellUIHelper5 : IShellUIHelper4")]
[NativeInheritance("IShellUIHelper4")]
public unsafe partial struct IShellUIHelper5 : IShellUIHelper5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellUIHelper5));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, Guid*, void**, int> )(lpVtbl[0]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, uint> )(lpVtbl[1]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, uint> )(lpVtbl[2]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, uint*, int> )(lpVtbl[3]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IShellUIHelper.ResetFirstBootMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResetFirstBootMode()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[7]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper.ResetSafeMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResetSafeMode()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[8]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper.RefreshOfflineDesktop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RefreshOfflineDesktop()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[9]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper.AddFavorite"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, VARIANT*, int> )(lpVtbl[10]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL, Title);
    }

    /// <inheritdoc cref = "IShellUIHelper.AddChannel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddChannel([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, int> )(lpVtbl[11]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL);
    }

    /// <inheritdoc cref = "IShellUIHelper.AddDesktopComponent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddDesktopComponent([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Type, VARIANT* Left, VARIANT* Top, VARIANT* Width, VARIANT* Height)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int> )(lpVtbl[12]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL, Type, Left, Top, Width, Height);
    }

    /// <inheritdoc cref = "IShellUIHelper.IsSubscribed"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsSubscribed([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, short*, int> )(lpVtbl[13]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL, pBool);
    }

    /// <inheritdoc cref = "IShellUIHelper.NavigateAndFind"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT NavigateAndFind([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* strQuery, VARIANT* varTargetFrame)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, ushort*, VARIANT*, int> )(lpVtbl[14]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL, strQuery, varTargetFrame);
    }

    /// <inheritdoc cref = "IShellUIHelper.ImportExportFavorites"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ImportExportFavorites([NativeTypeName("VARIANT_BOOL")] short fImport, [NativeTypeName("BSTR")] ushort* strImpExpPath)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, ushort*, int> )(lpVtbl[15]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fImport, strImpExpPath);
    }

    /// <inheritdoc cref = "IShellUIHelper.AutoCompleteSaveForm"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AutoCompleteSaveForm(VARIANT* Form)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, VARIANT*, int> )(lpVtbl[16]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), Form);
    }

    /// <inheritdoc cref = "IShellUIHelper.AutoScan"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AutoScan([NativeTypeName("BSTR")] ushort* strSearch, [NativeTypeName("BSTR")] ushort* strFailureUrl, VARIANT* pvarTargetFrame)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, ushort*, VARIANT*, int> )(lpVtbl[17]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), strSearch, strFailureUrl, pvarTargetFrame);
    }

    /// <inheritdoc cref = "IShellUIHelper.AutoCompleteAttach"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AutoCompleteAttach(VARIANT* Reserved)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, VARIANT*, int> )(lpVtbl[18]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), Reserved);
    }

    /// <inheritdoc cref = "IShellUIHelper.ShowBrowserUI"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ShowBrowserUI([NativeTypeName("BSTR")] ushort* bstrName, VARIANT* pvarIn, VARIANT* pvarOut)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, VARIANT*, VARIANT*, int> )(lpVtbl[19]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), bstrName, pvarIn, pvarOut);
    }

    /// <inheritdoc cref = "IShellUIHelper2.AddSearchProvider"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddSearchProvider([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, int> )(lpVtbl[20]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL);
    }

    /// <inheritdoc cref = "IShellUIHelper2.RunOnceShown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RunOnceShown()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[21]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper2.SkipRunOnce"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SkipRunOnce()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[22]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper2.CustomizeSettings"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CustomizeSettings([NativeTypeName("VARIANT_BOOL")] short fSQM, [NativeTypeName("VARIANT_BOOL")] short fPhishing, [NativeTypeName("BSTR")] ushort* bstrLocale)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, short, ushort*, int> )(lpVtbl[23]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fSQM, fPhishing, bstrLocale);
    }

    /// <inheritdoc cref = "IShellUIHelper2.SqmEnabled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SqmEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[24]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref = "IShellUIHelper2.PhishingEnabled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[25]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref = "IShellUIHelper2.BrandImageUri"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT BrandImageUri([NativeTypeName("BSTR *")] ushort** pbstrUri)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort**, int> )(lpVtbl[26]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pbstrUri);
    }

    /// <inheritdoc cref = "IShellUIHelper2.SkipTabsWelcome"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SkipTabsWelcome()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[27]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper2.DiagnoseConnection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DiagnoseConnection()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[28]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper2.CustomizeClearType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, int> )(lpVtbl[29]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fSet);
    }

    /// <inheritdoc cref = "IShellUIHelper2.IsSearchProviderInstalled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT IsSearchProviderInstalled([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, uint*, int> )(lpVtbl[30]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL, pdwResult);
    }

    /// <inheritdoc cref = "IShellUIHelper2.IsSearchMigrated"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[31]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfMigrated);
    }

    /// <inheritdoc cref = "IShellUIHelper2.DefaultSearchProvider"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT DefaultSearchProvider([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort**, int> )(lpVtbl[32]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <inheritdoc cref = "IShellUIHelper2.RunOnceRequiredSettingsComplete"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, int> )(lpVtbl[33]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fComplete);
    }

    /// <inheritdoc cref = "IShellUIHelper2.RunOnceHasShown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[34]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfShown);
    }

    /// <inheritdoc cref = "IShellUIHelper2.SearchGuideUrl"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SearchGuideUrl([NativeTypeName("BSTR *")] ushort** pbstrUrl)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort**, int> )(lpVtbl[35]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pbstrUrl);
    }

    /// <inheritdoc cref = "IShellUIHelper3.AddService"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT AddService([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, int> )(lpVtbl[36]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL);
    }

    /// <inheritdoc cref = "IShellUIHelper3.IsServiceInstalled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT IsServiceInstalled([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Verb, [NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, ushort*, uint*, int> )(lpVtbl[37]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL, Verb, pdwResult);
    }

    /// <inheritdoc cref = "IShellUIHelper3.InPrivateFilteringEnabled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT InPrivateFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[38]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref = "IShellUIHelper3.AddToFavoritesBar"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT AddToFavoritesBar([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Title, VARIANT* Type)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, ushort*, VARIANT*, int> )(lpVtbl[39]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL, Title, Type);
    }

    /// <inheritdoc cref = "IShellUIHelper3.BuildNewTabPage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT BuildNewTabPage()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[40]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper3.SetRecentlyClosedVisible"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SetRecentlyClosedVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, int> )(lpVtbl[41]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fVisible);
    }

    /// <inheritdoc cref = "IShellUIHelper3.SetActivitiesVisible"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT SetActivitiesVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, int> )(lpVtbl[42]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fVisible);
    }

    /// <inheritdoc cref = "IShellUIHelper3.ContentDiscoveryReset"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT ContentDiscoveryReset()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[43]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper3.IsSuggestedSitesEnabled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT IsSuggestedSitesEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[44]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref = "IShellUIHelper3.EnableSuggestedSites"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT EnableSuggestedSites([NativeTypeName("VARIANT_BOOL")] short fEnable)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, int> )(lpVtbl[45]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fEnable);
    }

    /// <inheritdoc cref = "IShellUIHelper3.NavigateToSuggestedSites"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT NavigateToSuggestedSites([NativeTypeName("BSTR")] ushort* bstrRelativeUrl)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, int> )(lpVtbl[46]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), bstrRelativeUrl);
    }

    /// <inheritdoc cref = "IShellUIHelper3.ShowTabsHelp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT ShowTabsHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[47]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper3.ShowInPrivateHelp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT ShowInPrivateHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[48]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper4.msIsSiteMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT msIsSiteMode([NativeTypeName("VARIANT_BOOL *")] short* pfSiteMode)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[49]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfSiteMode);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeShowThumbBar"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT msSiteModeShowThumbBar()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[50]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeAddThumbBarButton"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT msSiteModeAddThumbBarButton([NativeTypeName("BSTR")] ushort* bstrIconURL, [NativeTypeName("BSTR")] ushort* bstrTooltip, VARIANT* pvarButtonID)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, ushort*, VARIANT*, int> )(lpVtbl[51]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), bstrIconURL, bstrTooltip, pvarButtonID);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeUpdateThumbBarButton"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT msSiteModeUpdateThumbBarButton(VARIANT ButtonID, [NativeTypeName("VARIANT_BOOL")] short fEnabled, [NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, VARIANT, short, short, int> )(lpVtbl[52]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), ButtonID, fEnabled, fVisible);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeSetIconOverlay"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT msSiteModeSetIconOverlay([NativeTypeName("BSTR")] ushort* IconUrl, VARIANT* pvarDescription)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, VARIANT*, int> )(lpVtbl[53]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), IconUrl, pvarDescription);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeClearIconOverlay"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT msSiteModeClearIconOverlay()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[54]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper4.msAddSiteMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT msAddSiteMode()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[55]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeCreateJumpList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT msSiteModeCreateJumpList([NativeTypeName("BSTR")] ushort* bstrHeader)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, int> )(lpVtbl[56]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), bstrHeader);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeAddJumpListItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT msSiteModeAddJumpListItem([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrActionUri, [NativeTypeName("BSTR")] ushort* bstrIconUri, VARIANT* pvarWindowType)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, ushort*, ushort*, VARIANT*, int> )(lpVtbl[57]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), bstrName, bstrActionUri, bstrIconUri, pvarWindowType);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeClearJumpList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT msSiteModeClearJumpList()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[58]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeShowJumpList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT msSiteModeShowJumpList()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[59]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeAddButtonStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT msSiteModeAddButtonStyle(VARIANT uiButtonID, [NativeTypeName("BSTR")] ushort* bstrIconUrl, [NativeTypeName("BSTR")] ushort* bstrTooltip, VARIANT* pvarStyleID)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, VARIANT, ushort*, ushort*, VARIANT*, int> )(lpVtbl[60]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), uiButtonID, bstrIconUrl, bstrTooltip, pvarStyleID);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeShowButtonStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT msSiteModeShowButtonStyle(VARIANT uiButtonID, VARIANT uiStyleID)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, VARIANT, VARIANT, int> )(lpVtbl[61]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), uiButtonID, uiStyleID);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msSiteModeActivate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT msSiteModeActivate()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[62]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellUIHelper4.msIsSiteModeFirstRun"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT msIsSiteModeFirstRun([NativeTypeName("VARIANT_BOOL")] short fPreserveState, VARIANT* puiFirstRun)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, VARIANT*, int> )(lpVtbl[63]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fPreserveState, puiFirstRun);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msAddTrackingProtectionList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT msAddTrackingProtectionList([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* bstrFilterName)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, ushort*, int> )(lpVtbl[64]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), URL, bstrFilterName);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msTrackingProtectionEnabled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT msTrackingProtectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[65]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref = "IShellUIHelper4.msActiveXFilteringEnabled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT msActiveXFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short*, int> )(lpVtbl[66]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <include file='IShellUIHelper5.xml' path='doc/member[@name="IShellUIHelper5.msProvisionNetworks"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT msProvisionNetworks([NativeTypeName("BSTR")] ushort* bstrProvisioningXml, VARIANT* puiResult)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, ushort*, VARIANT*, int> )(lpVtbl[67]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), bstrProvisioningXml, puiResult);
    }

    /// <include file='IShellUIHelper5.xml' path='doc/member[@name="IShellUIHelper5.msReportSafeUrl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT msReportSafeUrl()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[68]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellUIHelper5.xml' path='doc/member[@name="IShellUIHelper5.msSiteModeRefreshBadge"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT msSiteModeRefreshBadge()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[69]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellUIHelper5.xml' path='doc/member[@name="IShellUIHelper5.msSiteModeClearBadge"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT msSiteModeClearBadge()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[70]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellUIHelper5.xml' path='doc/member[@name="IShellUIHelper5.msDiagnoseConnectionUILess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT msDiagnoseConnectionUILess()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[71]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellUIHelper5.xml' path='doc/member[@name="IShellUIHelper5.msLaunchNetworkClientHelp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT msLaunchNetworkClientHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper5*, int> )(lpVtbl[72]))((IShellUIHelper5*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellUIHelper5.xml' path='doc/member[@name="IShellUIHelper5.msChangeDefaultBrowser"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT msChangeDefaultBrowser([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged<IShellUIHelper5*, short, int> )(lpVtbl[73]))((IShellUIHelper5*)Unsafe.AsPointer(ref this), fChange);
    }

    public interface Interface : IShellUIHelper4.Interface
    {
        [VtblIndex(67)]
        HRESULT msProvisionNetworks([NativeTypeName("BSTR")] ushort* bstrProvisioningXml, VARIANT* puiResult);
        [VtblIndex(68)]
        HRESULT msReportSafeUrl();
        [VtblIndex(69)]
        HRESULT msSiteModeRefreshBadge();
        [VtblIndex(70)]
        HRESULT msSiteModeClearBadge();
        [VtblIndex(71)]
        HRESULT msDiagnoseConnectionUILess();
        [VtblIndex(72)]
        HRESULT msLaunchNetworkClientHelp();
        [VtblIndex(73)]
        HRESULT msChangeDefaultBrowser([NativeTypeName("VARIANT_BOOL")] short fChange);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetFirstBootMode;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetSafeMode;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RefreshOfflineDesktop;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> AddFavorite;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddChannel;
        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int> AddDesktopComponent;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> IsSubscribed;
        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, int> NavigateAndFind;
        [NativeTypeName("HRESULT (VARIANT_BOOL, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, ushort*, int> ImportExportFavorites;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> AutoCompleteSaveForm;
        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, int> AutoScan;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> AutoCompleteAttach;
        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, VARIANT*, int> ShowBrowserUI;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddSearchProvider;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RunOnceShown;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SkipRunOnce;
        [NativeTypeName("HRESULT (VARIANT_BOOL, VARIANT_BOOL, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, short, ushort*, int> CustomizeSettings;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> SqmEnabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> PhishingEnabled;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> BrandImageUri;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SkipTabsWelcome;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DiagnoseConnection;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> CustomizeClearType;
        [NativeTypeName("HRESULT (BSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> IsSearchProviderInstalled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> IsSearchMigrated;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> DefaultSearchProvider;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> RunOnceRequiredSettingsComplete;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> RunOnceHasShown;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> SearchGuideUrl;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddService;
        [NativeTypeName("HRESULT (BSTR, BSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint*, int> IsServiceInstalled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> InPrivateFilteringEnabled;
        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, int> AddToFavoritesBar;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BuildNewTabPage;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> SetRecentlyClosedVisible;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> SetActivitiesVisible;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ContentDiscoveryReset;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> IsSuggestedSitesEnabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> EnableSuggestedSites;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> NavigateToSuggestedSites;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShowTabsHelp;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShowInPrivateHelp;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> msIsSiteMode;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeShowThumbBar;
        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, int> msSiteModeAddThumbBarButton;
        [NativeTypeName("HRESULT (VARIANT, VARIANT_BOOL, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, short, short, int> msSiteModeUpdateThumbBarButton;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> msSiteModeSetIconOverlay;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeClearIconOverlay;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msAddSiteMode;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> msSiteModeCreateJumpList;
        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, VARIANT*, int> msSiteModeAddJumpListItem;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeClearJumpList;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeShowJumpList;
        [NativeTypeName("HRESULT (VARIANT, BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, ushort*, ushort*, VARIANT*, int> msSiteModeAddButtonStyle;
        [NativeTypeName("HRESULT (VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, int> msSiteModeShowButtonStyle;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeActivate;
        [NativeTypeName("HRESULT (VARIANT_BOOL, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, VARIANT*, int> msIsSiteModeFirstRun;
        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> msAddTrackingProtectionList;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> msTrackingProtectionEnabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> msActiveXFilteringEnabled;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> msProvisionNetworks;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msReportSafeUrl;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeRefreshBadge;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeClearBadge;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msDiagnoseConnectionUILess;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msLaunchNetworkClientHelp;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> msChangeDefaultBrowser;
    }
}