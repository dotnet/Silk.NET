// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6CDF73B0-7F2F-451F-BC0F-63E0F3284E54")]
[NativeTypeName("struct IShellUIHelper9 : IShellUIHelper8")]
[NativeInheritance("IShellUIHelper8")]
public unsafe partial struct IShellUIHelper9 : IShellUIHelper9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellUIHelper9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellUIHelper9, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellUIHelper9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellUIHelper9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellUIHelper9, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IShellUIHelper9, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IShellUIHelper9,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResetFirstBootMode()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResetSafeMode()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RefreshOfflineDesktop()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, VARIANT*, int>)((*lpVtbl)[10]))(
            this,
            URL,
            Title
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddChannel([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, int>)((*lpVtbl)[11]))(this, URL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddDesktopComponent(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("BSTR")] ushort* Type,
        VARIANT* Left,
        VARIANT* Top,
        VARIANT* Width,
        VARIANT* Height
    )
    {
        return (
            (delegate* unmanaged<
                IShellUIHelper9,
                ushort*,
                ushort*,
                VARIANT*,
                VARIANT*,
                VARIANT*,
                VARIANT*,
                int>)((*lpVtbl)[12])
        )(this, URL, Type, Left, Top, Width, Height);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsSubscribed(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("VARIANT_BOOL *")] short* pBool
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, short*, int>)((*lpVtbl)[13]))(
            this,
            URL,
            pBool
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT NavigateAndFind(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("BSTR")] ushort* strQuery,
        VARIANT* varTargetFrame
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[14])
        )(this, URL, strQuery, varTargetFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ImportExportFavorites(
        [NativeTypeName("VARIANT_BOOL")] short fImport,
        [NativeTypeName("BSTR")] ushort* strImpExpPath
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, ushort*, int>)((*lpVtbl)[15]))(
            this,
            fImport,
            strImpExpPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AutoCompleteSaveForm(VARIANT* Form)
    {
        return ((delegate* unmanaged<IShellUIHelper9, VARIANT*, int>)((*lpVtbl)[16]))(this, Form);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AutoScan(
        [NativeTypeName("BSTR")] ushort* strSearch,
        [NativeTypeName("BSTR")] ushort* strFailureUrl,
        VARIANT* pvarTargetFrame
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[17])
        )(this, strSearch, strFailureUrl, pvarTargetFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AutoCompleteAttach(VARIANT* Reserved)
    {
        return ((delegate* unmanaged<IShellUIHelper9, VARIANT*, int>)((*lpVtbl)[18]))(
            this,
            Reserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ShowBrowserUI(
        [NativeTypeName("BSTR")] ushort* bstrName,
        VARIANT* pvarIn,
        VARIANT* pvarOut
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, ushort*, VARIANT*, VARIANT*, int>)((*lpVtbl)[19])
        )(this, bstrName, pvarIn, pvarOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddSearchProvider([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, int>)((*lpVtbl)[20]))(this, URL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RunOnceShown()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SkipRunOnce()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CustomizeSettings(
        [NativeTypeName("VARIANT_BOOL")] short fSQM,
        [NativeTypeName("VARIANT_BOOL")] short fPhishing,
        [NativeTypeName("BSTR")] ushort* bstrLocale
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, short, ushort*, int>)((*lpVtbl)[23]))(
            this,
            fSQM,
            fPhishing,
            bstrLocale
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SqmEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[24]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[25]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT BrandImageUri([NativeTypeName("BSTR *")] ushort** pbstrUri)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort**, int>)((*lpVtbl)[26]))(
            this,
            pbstrUri
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SkipTabsWelcome()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[27]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DiagnoseConnection()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[28]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[29]))(this, fSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT IsSearchProviderInstalled(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("DWORD *")] uint* pdwResult
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, uint*, int>)((*lpVtbl)[30]))(
            this,
            URL,
            pdwResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[31]))(
            this,
            pfMigrated
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT DefaultSearchProvider([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort**, int>)((*lpVtbl)[32]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[33]))(this, fComplete);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[34]))(this, pfShown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SearchGuideUrl([NativeTypeName("BSTR *")] ushort** pbstrUrl)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort**, int>)((*lpVtbl)[35]))(
            this,
            pbstrUrl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT AddService([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, int>)((*lpVtbl)[36]))(this, URL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT IsServiceInstalled(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("BSTR")] ushort* Verb,
        [NativeTypeName("DWORD *")] uint* pdwResult
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, ushort*, ushort*, uint*, int>)((*lpVtbl)[37])
        )(this, URL, Verb, pdwResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT InPrivateFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[38]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT AddToFavoritesBar(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("BSTR")] ushort* Title,
        VARIANT* Type
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[39])
        )(this, URL, Title, Type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT BuildNewTabPage()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[40]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SetRecentlyClosedVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[41]))(this, fVisible);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT SetActivitiesVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[42]))(this, fVisible);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT ContentDiscoveryReset()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[43]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT IsSuggestedSitesEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[44]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT EnableSuggestedSites([NativeTypeName("VARIANT_BOOL")] short fEnable)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[45]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT NavigateToSuggestedSites([NativeTypeName("BSTR")] ushort* bstrRelativeUrl)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, int>)((*lpVtbl)[46]))(
            this,
            bstrRelativeUrl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT ShowTabsHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[47]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT ShowInPrivateHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[48]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT msIsSiteMode([NativeTypeName("VARIANT_BOOL *")] short* pfSiteMode)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[49]))(
            this,
            pfSiteMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT msSiteModeShowThumbBar()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[50]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT msSiteModeAddThumbBarButton(
        [NativeTypeName("BSTR")] ushort* bstrIconURL,
        [NativeTypeName("BSTR")] ushort* bstrTooltip,
        VARIANT* pvarButtonID
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[51])
        )(this, bstrIconURL, bstrTooltip, pvarButtonID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT msSiteModeUpdateThumbBarButton(
        VARIANT ButtonID,
        [NativeTypeName("VARIANT_BOOL")] short fEnabled,
        [NativeTypeName("VARIANT_BOOL")] short fVisible
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, VARIANT, short, short, int>)((*lpVtbl)[52]))(
            this,
            ButtonID,
            fEnabled,
            fVisible
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT msSiteModeSetIconOverlay(
        [NativeTypeName("BSTR")] ushort* IconUrl,
        VARIANT* pvarDescription
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, VARIANT*, int>)((*lpVtbl)[53]))(
            this,
            IconUrl,
            pvarDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT msSiteModeClearIconOverlay()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[54]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT msAddSiteMode()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[55]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT msSiteModeCreateJumpList([NativeTypeName("BSTR")] ushort* bstrHeader)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, int>)((*lpVtbl)[56]))(
            this,
            bstrHeader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT msSiteModeAddJumpListItem(
        [NativeTypeName("BSTR")] ushort* bstrName,
        [NativeTypeName("BSTR")] ushort* bstrActionUri,
        [NativeTypeName("BSTR")] ushort* bstrIconUri,
        VARIANT* pvarWindowType
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, ushort*, ushort*, ushort*, VARIANT*, int>)(
                (*lpVtbl)[57]
            )
        )(this, bstrName, bstrActionUri, bstrIconUri, pvarWindowType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT msSiteModeClearJumpList()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[58]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT msSiteModeShowJumpList()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[59]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT msSiteModeAddButtonStyle(
        VARIANT uiButtonID,
        [NativeTypeName("BSTR")] ushort* bstrIconUrl,
        [NativeTypeName("BSTR")] ushort* bstrTooltip,
        VARIANT* pvarStyleID
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, VARIANT, ushort*, ushort*, VARIANT*, int>)(
                (*lpVtbl)[60]
            )
        )(this, uiButtonID, bstrIconUrl, bstrTooltip, pvarStyleID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT msSiteModeShowButtonStyle(VARIANT uiButtonID, VARIANT uiStyleID)
    {
        return ((delegate* unmanaged<IShellUIHelper9, VARIANT, VARIANT, int>)((*lpVtbl)[61]))(
            this,
            uiButtonID,
            uiStyleID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT msSiteModeActivate()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[62]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT msIsSiteModeFirstRun(
        [NativeTypeName("VARIANT_BOOL")] short fPreserveState,
        VARIANT* puiFirstRun
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, VARIANT*, int>)((*lpVtbl)[63]))(
            this,
            fPreserveState,
            puiFirstRun
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT msAddTrackingProtectionList(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("BSTR")] ushort* bstrFilterName
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, ushort*, int>)((*lpVtbl)[64]))(
            this,
            URL,
            bstrFilterName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT msTrackingProtectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[65]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT msActiveXFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short*, int>)((*lpVtbl)[66]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT msProvisionNetworks(
        [NativeTypeName("BSTR")] ushort* bstrProvisioningXml,
        VARIANT* puiResult
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, VARIANT*, int>)((*lpVtbl)[67]))(
            this,
            bstrProvisioningXml,
            puiResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT msReportSafeUrl()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[68]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT msSiteModeRefreshBadge()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[69]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT msSiteModeClearBadge()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[70]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT msDiagnoseConnectionUILess()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[71]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT msLaunchNetworkClientHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[72]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT msChangeDefaultBrowser([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[73]))(this, fChange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT msStopPeriodicTileUpdate()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[74]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT msStartPeriodicTileUpdate(
        VARIANT pollingUris,
        VARIANT startTime,
        VARIANT uiUpdateRecurrence
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, VARIANT, VARIANT, VARIANT, int>)((*lpVtbl)[75])
        )(this, pollingUris, startTime, uiUpdateRecurrence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT msStartPeriodicTileUpdateBatch(
        VARIANT pollingUris,
        VARIANT startTime,
        VARIANT uiUpdateRecurrence
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, VARIANT, VARIANT, VARIANT, int>)((*lpVtbl)[76])
        )(this, pollingUris, startTime, uiUpdateRecurrence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT msClearTile()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[77]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT msEnableTileNotificationQueue([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[78]))(this, fChange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT msPinnedSiteState(VARIANT* pvarSiteState)
    {
        return ((delegate* unmanaged<IShellUIHelper9, VARIANT*, int>)((*lpVtbl)[79]))(
            this,
            pvarSiteState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT msEnableTileNotificationQueueForSquare150x150(
        [NativeTypeName("VARIANT_BOOL")] short fChange
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[80]))(this, fChange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT msEnableTileNotificationQueueForWide310x150(
        [NativeTypeName("VARIANT_BOOL")] short fChange
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[81]))(this, fChange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT msEnableTileNotificationQueueForSquare310x310(
        [NativeTypeName("VARIANT_BOOL")] short fChange
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, short, int>)((*lpVtbl)[82]))(this, fChange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT msScheduledTileNotification(
        [NativeTypeName("BSTR")] ushort* bstrNotificationXml,
        [NativeTypeName("BSTR")] ushort* bstrNotificationId,
        [NativeTypeName("BSTR")] ushort* bstrNotificationTag,
        VARIANT startTime,
        VARIANT expirationTime
    )
    {
        return (
            (delegate* unmanaged<
                IShellUIHelper9,
                ushort*,
                ushort*,
                ushort*,
                VARIANT,
                VARIANT,
                int>)((*lpVtbl)[83])
        )(
            this,
            bstrNotificationXml,
            bstrNotificationId,
            bstrNotificationTag,
            startTime,
            expirationTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT msRemoveScheduledTileNotification(
        [NativeTypeName("BSTR")] ushort* bstrNotificationId
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, int>)((*lpVtbl)[84]))(
            this,
            bstrNotificationId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT msStartPeriodicBadgeUpdate(
        [NativeTypeName("BSTR")] ushort* pollingUri,
        VARIANT startTime,
        VARIANT uiUpdateRecurrence
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper9, ushort*, VARIANT, VARIANT, int>)((*lpVtbl)[85])
        )(this, pollingUri, startTime, uiUpdateRecurrence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT msStopPeriodicBadgeUpdate()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[86]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT msLaunchInternetOptions()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[87]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT SetExperimentalFlag(
        [NativeTypeName("BSTR")] ushort* bstrFlagString,
        [NativeTypeName("VARIANT_BOOL")] short vfFlag
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, short, int>)((*lpVtbl)[88]))(
            this,
            bstrFlagString,
            vfFlag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT GetExperimentalFlag(
        [NativeTypeName("BSTR")] ushort* bstrFlagString,
        [NativeTypeName("VARIANT_BOOL *")] short* vfFlag
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, short*, int>)((*lpVtbl)[89]))(
            this,
            bstrFlagString,
            vfFlag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT SetExperimentalValue(
        [NativeTypeName("BSTR")] ushort* bstrValueString,
        [NativeTypeName("DWORD")] uint dwValue
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, uint, int>)((*lpVtbl)[90]))(
            this,
            bstrValueString,
            dwValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT GetExperimentalValue(
        [NativeTypeName("BSTR")] ushort* bstrValueString,
        [NativeTypeName("DWORD *")] uint* pdwValue
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, uint*, int>)((*lpVtbl)[91]))(
            this,
            bstrValueString,
            pdwValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT ResetAllExperimentalFlagsAndValues()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[92]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT GetNeedIEAutoLaunchFlag(
        [NativeTypeName("BSTR")] ushort* bstrUrl,
        [NativeTypeName("VARIANT_BOOL *")] short* flag
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, short*, int>)((*lpVtbl)[93]))(
            this,
            bstrUrl,
            flag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT SetNeedIEAutoLaunchFlag(
        [NativeTypeName("BSTR")] ushort* bstrUrl,
        [NativeTypeName("VARIANT_BOOL")] short flag
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, short, int>)((*lpVtbl)[94]))(
            this,
            bstrUrl,
            flag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT HasNeedIEAutoLaunchFlag(
        [NativeTypeName("BSTR")] ushort* bstrUrl,
        [NativeTypeName("VARIANT_BOOL *")] short* exists
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, short*, int>)((*lpVtbl)[95]))(
            this,
            bstrUrl,
            exists
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT LaunchIE(
        [NativeTypeName("BSTR")] ushort* bstrUrl,
        [NativeTypeName("VARIANT_BOOL")] short automated
    )
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, short, int>)((*lpVtbl)[96]))(
            this,
            bstrUrl,
            automated
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT GetCVListData([NativeTypeName("BSTR *")] ushort** pbstrResult)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort**, int>)((*lpVtbl)[97]))(
            this,
            pbstrResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT GetCVListLocalData([NativeTypeName("BSTR *")] ushort** pbstrResult)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort**, int>)((*lpVtbl)[98]))(
            this,
            pbstrResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT GetEMIEListData([NativeTypeName("BSTR *")] ushort** pbstrResult)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort**, int>)((*lpVtbl)[99]))(
            this,
            pbstrResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT GetEMIEListLocalData([NativeTypeName("BSTR *")] ushort** pbstrResult)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort**, int>)((*lpVtbl)[100]))(
            this,
            pbstrResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT OpenFavoritesPane()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[101]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT OpenFavoritesSettings()
    {
        return ((delegate* unmanaged<IShellUIHelper9, int>)((*lpVtbl)[102]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT LaunchInHVSI([NativeTypeName("BSTR")] ushort* bstrUrl)
    {
        return ((delegate* unmanaged<IShellUIHelper9, ushort*, int>)((*lpVtbl)[103]))(
            this,
            bstrUrl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT GetOSSku([NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged<IShellUIHelper9, uint*, int>)((*lpVtbl)[104]))(
            this,
            pdwResult
        );
    }

    public interface Interface : IShellUIHelper8.Interface
    {
        [VtblIndex(104)]
        HRESULT GetOSSku([NativeTypeName("DWORD *")] uint* pdwResult);
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

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

        [NativeTypeName(
            "HRESULT (BSTR, BSTR, VARIANT *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            VARIANT*,
            VARIANT*,
            VARIANT*,
            VARIANT*,
            int> AddDesktopComponent;

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
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            VARIANT*,
            int> msSiteModeAddThumbBarButton;

        [NativeTypeName("HRESULT (VARIANT, VARIANT_BOOL, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            VARIANT,
            short,
            short,
            int> msSiteModeUpdateThumbBarButton;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> msSiteModeSetIconOverlay;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeClearIconOverlay;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msAddSiteMode;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> msSiteModeCreateJumpList;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            VARIANT*,
            int> msSiteModeAddJumpListItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeClearJumpList;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msSiteModeShowJumpList;

        [NativeTypeName("HRESULT (VARIANT, BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            VARIANT,
            ushort*,
            ushort*,
            VARIANT*,
            int> msSiteModeAddButtonStyle;

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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msStopPeriodicTileUpdate;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            VARIANT,
            VARIANT,
            VARIANT,
            int> msStartPeriodicTileUpdate;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            VARIANT,
            VARIANT,
            VARIANT,
            int> msStartPeriodicTileUpdateBatch;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msClearTile;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> msEnableTileNotificationQueue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> msPinnedSiteState;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            short,
            int> msEnableTileNotificationQueueForSquare150x150;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> msEnableTileNotificationQueueForWide310x150;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            short,
            int> msEnableTileNotificationQueueForSquare310x310;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            VARIANT,
            VARIANT,
            int> msScheduledTileNotification;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> msRemoveScheduledTileNotification;

        [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            VARIANT,
            VARIANT,
            int> msStartPeriodicBadgeUpdate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msStopPeriodicBadgeUpdate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> msLaunchInternetOptions;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> SetExperimentalFlag;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> GetExperimentalFlag;

        [NativeTypeName("HRESULT (BSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetExperimentalValue;

        [NativeTypeName("HRESULT (BSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetExperimentalValue;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetAllExperimentalFlagsAndValues;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> GetNeedIEAutoLaunchFlag;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> SetNeedIEAutoLaunchFlag;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> HasNeedIEAutoLaunchFlag;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> LaunchIE;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCVListData;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCVListLocalData;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetEMIEListData;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetEMIEListLocalData;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OpenFavoritesPane;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OpenFavoritesSettings;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> LaunchInHVSI;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOSSku;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellUIHelper9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellUIHelper9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper8"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper8"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IShellUIHelper8 value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IShellUIHelper8"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper8(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IShellUIHelper8(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper7"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper7"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IShellUIHelper7 value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IShellUIHelper7"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper7(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IShellUIHelper7(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper6"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper6"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IShellUIHelper6 value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IShellUIHelper6"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper6(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IShellUIHelper6(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper5"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper5"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IShellUIHelper5 value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IShellUIHelper5"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper5(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IShellUIHelper5(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper4"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper4"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IShellUIHelper4 value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IShellUIHelper4"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper4(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IShellUIHelper4(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper3"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper3"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IShellUIHelper3 value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IShellUIHelper3"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper3(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IShellUIHelper3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper2"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper2"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IShellUIHelper2 value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IShellUIHelper2"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper2(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IShellUIHelper2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IShellUIHelper value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IShellUIHelper"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IShellUIHelper(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IDispatch value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellUIHelper9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellUIHelper9(Silk.NET.Windows.IUnknown value)
    {
        return new IShellUIHelper9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellUIHelper9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
