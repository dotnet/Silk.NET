// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A7FE6EDA-1932-4281-B881-87B31B8BC52C")]
[NativeTypeName("struct IShellUIHelper2 : IShellUIHelper")]
[NativeInheritance("IShellUIHelper")]
public unsafe partial struct IShellUIHelper2 : IShellUIHelper2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellUIHelper2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellUIHelper2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellUIHelper2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellUIHelper2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellUIHelper2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IShellUIHelper2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IShellUIHelper2, Guid*, ushort**, uint, uint, int*, int>)(
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
                IShellUIHelper2,
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
        return ((delegate* unmanaged<IShellUIHelper2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResetSafeMode()
    {
        return ((delegate* unmanaged<IShellUIHelper2, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RefreshOfflineDesktop()
    {
        return ((delegate* unmanaged<IShellUIHelper2, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title)
    {
        return ((delegate* unmanaged<IShellUIHelper2, ushort*, VARIANT*, int>)((*lpVtbl)[10]))(
            this,
            URL,
            Title
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddChannel([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper2, ushort*, int>)((*lpVtbl)[11]))(this, URL);
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
                IShellUIHelper2,
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
        return ((delegate* unmanaged<IShellUIHelper2, ushort*, short*, int>)((*lpVtbl)[13]))(
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
            (delegate* unmanaged<IShellUIHelper2, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[14])
        )(this, URL, strQuery, varTargetFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ImportExportFavorites(
        [NativeTypeName("VARIANT_BOOL")] short fImport,
        [NativeTypeName("BSTR")] ushort* strImpExpPath
    )
    {
        return ((delegate* unmanaged<IShellUIHelper2, short, ushort*, int>)((*lpVtbl)[15]))(
            this,
            fImport,
            strImpExpPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AutoCompleteSaveForm(VARIANT* Form)
    {
        return ((delegate* unmanaged<IShellUIHelper2, VARIANT*, int>)((*lpVtbl)[16]))(this, Form);
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
            (delegate* unmanaged<IShellUIHelper2, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[17])
        )(this, strSearch, strFailureUrl, pvarTargetFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AutoCompleteAttach(VARIANT* Reserved)
    {
        return ((delegate* unmanaged<IShellUIHelper2, VARIANT*, int>)((*lpVtbl)[18]))(
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
            (delegate* unmanaged<IShellUIHelper2, ushort*, VARIANT*, VARIANT*, int>)((*lpVtbl)[19])
        )(this, bstrName, pvarIn, pvarOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddSearchProvider([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper2, ushort*, int>)((*lpVtbl)[20]))(this, URL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RunOnceShown()
    {
        return ((delegate* unmanaged<IShellUIHelper2, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SkipRunOnce()
    {
        return ((delegate* unmanaged<IShellUIHelper2, int>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CustomizeSettings(
        [NativeTypeName("VARIANT_BOOL")] short fSQM,
        [NativeTypeName("VARIANT_BOOL")] short fPhishing,
        [NativeTypeName("BSTR")] ushort* bstrLocale
    )
    {
        return ((delegate* unmanaged<IShellUIHelper2, short, short, ushort*, int>)((*lpVtbl)[23]))(
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
        return ((delegate* unmanaged<IShellUIHelper2, short*, int>)((*lpVtbl)[24]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged<IShellUIHelper2, short*, int>)((*lpVtbl)[25]))(
            this,
            pfEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT BrandImageUri([NativeTypeName("BSTR *")] ushort** pbstrUri)
    {
        return ((delegate* unmanaged<IShellUIHelper2, ushort**, int>)((*lpVtbl)[26]))(
            this,
            pbstrUri
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SkipTabsWelcome()
    {
        return ((delegate* unmanaged<IShellUIHelper2, int>)((*lpVtbl)[27]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DiagnoseConnection()
    {
        return ((delegate* unmanaged<IShellUIHelper2, int>)((*lpVtbl)[28]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet)
    {
        return ((delegate* unmanaged<IShellUIHelper2, short, int>)((*lpVtbl)[29]))(this, fSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT IsSearchProviderInstalled(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("DWORD *")] uint* pdwResult
    )
    {
        return ((delegate* unmanaged<IShellUIHelper2, ushort*, uint*, int>)((*lpVtbl)[30]))(
            this,
            URL,
            pdwResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated)
    {
        return ((delegate* unmanaged<IShellUIHelper2, short*, int>)((*lpVtbl)[31]))(
            this,
            pfMigrated
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT DefaultSearchProvider([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IShellUIHelper2, ushort**, int>)((*lpVtbl)[32]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete)
    {
        return ((delegate* unmanaged<IShellUIHelper2, short, int>)((*lpVtbl)[33]))(this, fComplete);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown)
    {
        return ((delegate* unmanaged<IShellUIHelper2, short*, int>)((*lpVtbl)[34]))(this, pfShown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SearchGuideUrl([NativeTypeName("BSTR *")] ushort** pbstrUrl)
    {
        return ((delegate* unmanaged<IShellUIHelper2, ushort**, int>)((*lpVtbl)[35]))(
            this,
            pbstrUrl
        );
    }

    public interface Interface : IShellUIHelper.Interface
    {
        [VtblIndex(20)]
        HRESULT AddSearchProvider([NativeTypeName("BSTR")] ushort* URL);

        [VtblIndex(21)]
        HRESULT RunOnceShown();

        [VtblIndex(22)]
        HRESULT SkipRunOnce();

        [VtblIndex(23)]
        HRESULT CustomizeSettings(
            [NativeTypeName("VARIANT_BOOL")] short fSQM,
            [NativeTypeName("VARIANT_BOOL")] short fPhishing,
            [NativeTypeName("BSTR")] ushort* bstrLocale
        );

        [VtblIndex(24)]
        HRESULT SqmEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled);

        [VtblIndex(25)]
        HRESULT PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled);

        [VtblIndex(26)]
        HRESULT BrandImageUri([NativeTypeName("BSTR *")] ushort** pbstrUri);

        [VtblIndex(27)]
        HRESULT SkipTabsWelcome();

        [VtblIndex(28)]
        HRESULT DiagnoseConnection();

        [VtblIndex(29)]
        HRESULT CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet);

        [VtblIndex(30)]
        HRESULT IsSearchProviderInstalled(
            [NativeTypeName("BSTR")] ushort* URL,
            [NativeTypeName("DWORD *")] uint* pdwResult
        );

        [VtblIndex(31)]
        HRESULT IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated);

        [VtblIndex(32)]
        HRESULT DefaultSearchProvider([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(33)]
        HRESULT RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete);

        [VtblIndex(34)]
        HRESULT RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown);

        [VtblIndex(35)]
        HRESULT SearchGuideUrl([NativeTypeName("BSTR *")] ushort** pbstrUrl);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellUIHelper2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellUIHelper2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellUIHelper"/> to <see cref = "IShellUIHelper2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellUIHelper"/> instance to be converted </param>
    public static explicit operator IShellUIHelper2(Silk.NET.Windows.IShellUIHelper value)
    {
        return new IShellUIHelper2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper2"/> to <see cref = "Silk.NET.Windows.IShellUIHelper"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellUIHelper(IShellUIHelper2 value)
    {
        return new Silk.NET.Windows.IShellUIHelper(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IShellUIHelper2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IShellUIHelper2(Silk.NET.Windows.IDispatch value)
    {
        return new IShellUIHelper2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IShellUIHelper2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellUIHelper2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellUIHelper2(Silk.NET.Windows.IUnknown value)
    {
        return new IShellUIHelper2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellUIHelper2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
