// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A2A08B09-103D-4D3F-B91C-EA455CA82EFA")]
[NativeTypeName("struct IShellUIHelper5 : IShellUIHelper4")]
[NativeInheritance("IShellUIHelper4")]
public unsafe partial struct IShellUIHelper5 : IShellUIHelper5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellUIHelper5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellUIHelper5, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellUIHelper5, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellUIHelper5, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellUIHelper5, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IShellUIHelper5, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IShellUIHelper5, Guid*, ushort**, uint, uint, int*, int>)(
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
                IShellUIHelper5,
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
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResetSafeMode()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RefreshOfflineDesktop()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, VARIANT*, int>)((*lpVtbl)[10]))(
            this,
            URL,
            Title
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddChannel([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, int>)((*lpVtbl)[11]))(this, URL);
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
                IShellUIHelper5,
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
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, short*, int>)((*lpVtbl)[13]))(
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
            (delegate* unmanaged<IShellUIHelper5, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[14])
        )(this, URL, strQuery, varTargetFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ImportExportFavorites(
        [NativeTypeName("VARIANT_BOOL")] short fImport,
        [NativeTypeName("BSTR")] ushort* strImpExpPath
    )
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, ushort*, int>)((*lpVtbl)[15]))(
            this,
            fImport,
            strImpExpPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AutoCompleteSaveForm(VARIANT* Form)
    {
        return ((delegate* unmanaged<IShellUIHelper5, VARIANT*, int>)((*lpVtbl)[16]))(this, Form);
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
            (delegate* unmanaged<IShellUIHelper5, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[17])
        )(this, strSearch, strFailureUrl, pvarTargetFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AutoCompleteAttach(VARIANT* Reserved)
    {
        return ((delegate* unmanaged<IShellUIHelper5, VARIANT*, int>)((*lpVtbl)[18]))(
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
            (delegate* unmanaged<IShellUIHelper5, ushort*, VARIANT*, VARIANT*, int>)((*lpVtbl)[19])
        )(this, bstrName, pvarIn, pvarOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddSearchProvider([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, int>)((*lpVtbl)[20]))(this, URL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RunOnceShown()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SkipRunOnce()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CustomizeSettings(
        [NativeTypeName("VARIANT_BOOL")] short fSQM,
        [NativeTypeName("VARIANT_BOOL")] short fPhishing,
        [NativeTypeName("BSTR")] ushort* bstrLocale
    )
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, short, ushort*, int>)((*lpVtbl)[23]))(
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
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[24]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[25]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT BrandImageUri([NativeTypeName("BSTR *")] ushort** pbstrUri)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort**, int>)((*lpVtbl)[26]))(
            this,
            pbstrUri
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SkipTabsWelcome()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[27]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DiagnoseConnection()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[28]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, int>)((*lpVtbl)[29]))(this, fSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT IsSearchProviderInstalled(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("DWORD *")] uint* pdwResult
    )
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, uint*, int>)((*lpVtbl)[30]))(
            this,
            URL,
            pdwResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[31]))(
            this,
            pfMigrated
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT DefaultSearchProvider([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort**, int>)((*lpVtbl)[32]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, int>)((*lpVtbl)[33]))(this, fComplete);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[34]))(this, pfShown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SearchGuideUrl([NativeTypeName("BSTR *")] ushort** pbstrUrl)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort**, int>)((*lpVtbl)[35]))(
            this,
            pbstrUrl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT AddService([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, int>)((*lpVtbl)[36]))(this, URL);
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
            (delegate* unmanaged<IShellUIHelper5, ushort*, ushort*, uint*, int>)((*lpVtbl)[37])
        )(this, URL, Verb, pdwResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT InPrivateFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[38]))(
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
            (delegate* unmanaged<IShellUIHelper5, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[39])
        )(this, URL, Title, Type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT BuildNewTabPage()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[40]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SetRecentlyClosedVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, int>)((*lpVtbl)[41]))(this, fVisible);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT SetActivitiesVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, int>)((*lpVtbl)[42]))(this, fVisible);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT ContentDiscoveryReset()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[43]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT IsSuggestedSitesEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[44]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT EnableSuggestedSites([NativeTypeName("VARIANT_BOOL")] short fEnable)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, int>)((*lpVtbl)[45]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT NavigateToSuggestedSites([NativeTypeName("BSTR")] ushort* bstrRelativeUrl)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, int>)((*lpVtbl)[46]))(
            this,
            bstrRelativeUrl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT ShowTabsHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[47]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT ShowInPrivateHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[48]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT msIsSiteMode([NativeTypeName("VARIANT_BOOL *")] short* pfSiteMode)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[49]))(
            this,
            pfSiteMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT msSiteModeShowThumbBar()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[50]))(this);
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
            (delegate* unmanaged<IShellUIHelper5, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[51])
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
        return ((delegate* unmanaged<IShellUIHelper5, VARIANT, short, short, int>)((*lpVtbl)[52]))(
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
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, VARIANT*, int>)((*lpVtbl)[53]))(
            this,
            IconUrl,
            pvarDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT msSiteModeClearIconOverlay()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[54]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT msAddSiteMode()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[55]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT msSiteModeCreateJumpList([NativeTypeName("BSTR")] ushort* bstrHeader)
    {
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, int>)((*lpVtbl)[56]))(
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
            (delegate* unmanaged<IShellUIHelper5, ushort*, ushort*, ushort*, VARIANT*, int>)(
                (*lpVtbl)[57]
            )
        )(this, bstrName, bstrActionUri, bstrIconUri, pvarWindowType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT msSiteModeClearJumpList()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[58]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT msSiteModeShowJumpList()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[59]))(this);
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
            (delegate* unmanaged<IShellUIHelper5, VARIANT, ushort*, ushort*, VARIANT*, int>)(
                (*lpVtbl)[60]
            )
        )(this, uiButtonID, bstrIconUrl, bstrTooltip, pvarStyleID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT msSiteModeShowButtonStyle(VARIANT uiButtonID, VARIANT uiStyleID)
    {
        return ((delegate* unmanaged<IShellUIHelper5, VARIANT, VARIANT, int>)((*lpVtbl)[61]))(
            this,
            uiButtonID,
            uiStyleID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT msSiteModeActivate()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[62]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT msIsSiteModeFirstRun(
        [NativeTypeName("VARIANT_BOOL")] short fPreserveState,
        VARIANT* puiFirstRun
    )
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, VARIANT*, int>)((*lpVtbl)[63]))(
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
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, ushort*, int>)((*lpVtbl)[64]))(
            this,
            URL,
            bstrFilterName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT msTrackingProtectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[65]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT msActiveXFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short*, int>)((*lpVtbl)[66]))(
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
        return ((delegate* unmanaged<IShellUIHelper5, ushort*, VARIANT*, int>)((*lpVtbl)[67]))(
            this,
            bstrProvisioningXml,
            puiResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT msReportSafeUrl()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[68]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT msSiteModeRefreshBadge()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[69]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT msSiteModeClearBadge()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[70]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT msDiagnoseConnectionUILess()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[71]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT msLaunchNetworkClientHelp()
    {
        return ((delegate* unmanaged<IShellUIHelper5, int>)((*lpVtbl)[72]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT msChangeDefaultBrowser([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged<IShellUIHelper5, short, int>)((*lpVtbl)[73]))(this, fChange);
    }

    public interface Interface : IShellUIHelper4.Interface
    {
        [VtblIndex(67)]
        HRESULT msProvisionNetworks(
            [NativeTypeName("BSTR")] ushort* bstrProvisioningXml,
            VARIANT* puiResult
        );

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
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellUIHelper5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellUIHelper5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper4"/> to <see cref = "IShellUIHelper5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper4"/> instance to be converted </param>
    public static explicit operator IShellUIHelper5(Silk.NET.Windows.IShellUIHelper4 value)
    {
        return new IShellUIHelper5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper5"/> to <see cref = "Silk.NET.Windows.IShellUIHelper4"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper4(IShellUIHelper5 value)
    {
        return new Silk.NET.Windows.IShellUIHelper4(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper3"/> to <see cref = "IShellUIHelper5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper3"/> instance to be converted </param>
    public static explicit operator IShellUIHelper5(Silk.NET.Windows.IShellUIHelper3 value)
    {
        return new IShellUIHelper5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper5"/> to <see cref = "Silk.NET.Windows.IShellUIHelper3"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper3(IShellUIHelper5 value)
    {
        return new Silk.NET.Windows.IShellUIHelper3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper2"/> to <see cref = "IShellUIHelper5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper2"/> instance to be converted </param>
    public static explicit operator IShellUIHelper5(Silk.NET.Windows.IShellUIHelper2 value)
    {
        return new IShellUIHelper5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper5"/> to <see cref = "Silk.NET.Windows.IShellUIHelper2"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper2(IShellUIHelper5 value)
    {
        return new Silk.NET.Windows.IShellUIHelper2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper"/> to <see cref = "IShellUIHelper5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper"/> instance to be converted </param>
    public static explicit operator IShellUIHelper5(Silk.NET.Windows.IShellUIHelper value)
    {
        return new IShellUIHelper5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper5"/> to <see cref = "Silk.NET.Windows.IShellUIHelper"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper(IShellUIHelper5 value)
    {
        return new Silk.NET.Windows.IShellUIHelper(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IShellUIHelper5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IShellUIHelper5(Silk.NET.Windows.IDispatch value)
    {
        return new IShellUIHelper5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper5"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IShellUIHelper5 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellUIHelper5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellUIHelper5(Silk.NET.Windows.IUnknown value)
    {
        return new IShellUIHelper5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellUIHelper5 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
