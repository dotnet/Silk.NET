// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000112-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleObject : IOleObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetClientSite(IOleClientSite pClientSite)
    {
        return ((delegate* unmanaged<IOleObject, IOleClientSite, int>)((*lpVtbl)[3]))(
            this,
            pClientSite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetClientSite(IOleClientSite* ppClientSite)
    {
        return ((delegate* unmanaged<IOleObject, IOleClientSite*, int>)((*lpVtbl)[4]))(
            this,
            ppClientSite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetHostNames(
        [NativeTypeName("LPCOLESTR")] ushort* szContainerApp,
        [NativeTypeName("LPCOLESTR")] ushort* szContainerObj
    )
    {
        return ((delegate* unmanaged<IOleObject, ushort*, ushort*, int>)((*lpVtbl)[5]))(
            this,
            szContainerApp,
            szContainerObj
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Close([NativeTypeName("DWORD")] uint dwSaveOption)
    {
        return ((delegate* unmanaged<IOleObject, uint, int>)((*lpVtbl)[6]))(this, dwSaveOption);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMoniker([NativeTypeName("DWORD")] uint dwWhichMoniker, IMoniker pmk)
    {
        return ((delegate* unmanaged<IOleObject, uint, IMoniker, int>)((*lpVtbl)[7]))(
            this,
            dwWhichMoniker,
            pmk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMoniker(
        [NativeTypeName("DWORD")] uint dwAssign,
        [NativeTypeName("DWORD")] uint dwWhichMoniker,
        IMoniker* ppmk
    )
    {
        return ((delegate* unmanaged<IOleObject, uint, uint, IMoniker*, int>)((*lpVtbl)[8]))(
            this,
            dwAssign,
            dwWhichMoniker,
            ppmk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InitFromData(
        IDataObject pDataObject,
        BOOL fCreation,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return ((delegate* unmanaged<IOleObject, IDataObject, BOOL, uint, int>)((*lpVtbl)[9]))(
            this,
            pDataObject,
            fCreation,
            dwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetClipboardData(
        [NativeTypeName("DWORD")] uint dwReserved,
        IDataObject* ppDataObject
    )
    {
        return ((delegate* unmanaged<IOleObject, uint, IDataObject*, int>)((*lpVtbl)[10]))(
            this,
            dwReserved,
            ppDataObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DoVerb(
        [NativeTypeName("LONG")] int iVerb,
        [NativeTypeName("LPMSG")] MSG* lpmsg,
        IOleClientSite pActiveSite,
        [NativeTypeName("LONG")] int lindex,
        HWND hwndParent,
        [NativeTypeName("LPCRECT")] RECT* lprcPosRect
    )
    {
        return (
            (delegate* unmanaged<IOleObject, int, MSG*, IOleClientSite, int, HWND, RECT*, int>)(
                (*lpVtbl)[11]
            )
        )(this, iVerb, lpmsg, pActiveSite, lindex, hwndParent, lprcPosRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumVerbs(IEnumOLEVERB* ppEnumOleVerb)
    {
        return ((delegate* unmanaged<IOleObject, IEnumOLEVERB*, int>)((*lpVtbl)[12]))(
            this,
            ppEnumOleVerb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Update()
    {
        return ((delegate* unmanaged<IOleObject, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsUpToDate()
    {
        return ((delegate* unmanaged<IOleObject, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetUserClassID([NativeTypeName("CLSID *")] Guid* pClsid)
    {
        return ((delegate* unmanaged<IOleObject, Guid*, int>)((*lpVtbl)[15]))(this, pClsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetUserType(
        [NativeTypeName("DWORD")] uint dwFormOfType,
        [NativeTypeName("LPOLESTR *")] ushort** pszUserType
    )
    {
        return ((delegate* unmanaged<IOleObject, uint, ushort**, int>)((*lpVtbl)[16]))(
            this,
            dwFormOfType,
            pszUserType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetExtent(
        [NativeTypeName("DWORD")] uint dwDrawAspect,
        [NativeTypeName("SIZEL *")] SIZE* psizel
    )
    {
        return ((delegate* unmanaged<IOleObject, uint, SIZE*, int>)((*lpVtbl)[17]))(
            this,
            dwDrawAspect,
            psizel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetExtent(
        [NativeTypeName("DWORD")] uint dwDrawAspect,
        [NativeTypeName("SIZEL *")] SIZE* psizel
    )
    {
        return ((delegate* unmanaged<IOleObject, uint, SIZE*, int>)((*lpVtbl)[18]))(
            this,
            dwDrawAspect,
            psizel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Advise(IAdviseSink pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
    {
        return ((delegate* unmanaged<IOleObject, IAdviseSink, uint*, int>)((*lpVtbl)[19]))(
            this,
            pAdvSink,
            pdwConnection
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection)
    {
        return ((delegate* unmanaged<IOleObject, uint, int>)((*lpVtbl)[20]))(this, dwConnection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT EnumAdvise(IEnumSTATDATA* ppenumAdvise)
    {
        return ((delegate* unmanaged<IOleObject, IEnumSTATDATA*, int>)((*lpVtbl)[21]))(
            this,
            ppenumAdvise
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetMiscStatus(
        [NativeTypeName("DWORD")] uint dwAspect,
        [NativeTypeName("DWORD *")] uint* pdwStatus
    )
    {
        return ((delegate* unmanaged<IOleObject, uint, uint*, int>)((*lpVtbl)[22]))(
            this,
            dwAspect,
            pdwStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetColorScheme(LOGPALETTE* pLogpal)
    {
        return ((delegate* unmanaged<IOleObject, LOGPALETTE*, int>)((*lpVtbl)[23]))(this, pLogpal);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetClientSite(IOleClientSite pClientSite);

        [VtblIndex(4)]
        HRESULT GetClientSite(IOleClientSite* ppClientSite);

        [VtblIndex(5)]
        HRESULT SetHostNames(
            [NativeTypeName("LPCOLESTR")] ushort* szContainerApp,
            [NativeTypeName("LPCOLESTR")] ushort* szContainerObj
        );

        [VtblIndex(6)]
        HRESULT Close([NativeTypeName("DWORD")] uint dwSaveOption);

        [VtblIndex(7)]
        HRESULT SetMoniker([NativeTypeName("DWORD")] uint dwWhichMoniker, IMoniker pmk);

        [VtblIndex(8)]
        HRESULT GetMoniker(
            [NativeTypeName("DWORD")] uint dwAssign,
            [NativeTypeName("DWORD")] uint dwWhichMoniker,
            IMoniker* ppmk
        );

        [VtblIndex(9)]
        HRESULT InitFromData(
            IDataObject pDataObject,
            BOOL fCreation,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(10)]
        HRESULT GetClipboardData(
            [NativeTypeName("DWORD")] uint dwReserved,
            IDataObject* ppDataObject
        );

        [VtblIndex(11)]
        HRESULT DoVerb(
            [NativeTypeName("LONG")] int iVerb,
            [NativeTypeName("LPMSG")] MSG* lpmsg,
            IOleClientSite pActiveSite,
            [NativeTypeName("LONG")] int lindex,
            HWND hwndParent,
            [NativeTypeName("LPCRECT")] RECT* lprcPosRect
        );

        [VtblIndex(12)]
        HRESULT EnumVerbs(IEnumOLEVERB* ppEnumOleVerb);

        [VtblIndex(13)]
        HRESULT Update();

        [VtblIndex(14)]
        HRESULT IsUpToDate();

        [VtblIndex(15)]
        HRESULT GetUserClassID([NativeTypeName("CLSID *")] Guid* pClsid);

        [VtblIndex(16)]
        HRESULT GetUserType(
            [NativeTypeName("DWORD")] uint dwFormOfType,
            [NativeTypeName("LPOLESTR *")] ushort** pszUserType
        );

        [VtblIndex(17)]
        HRESULT SetExtent(
            [NativeTypeName("DWORD")] uint dwDrawAspect,
            [NativeTypeName("SIZEL *")] SIZE* psizel
        );

        [VtblIndex(18)]
        HRESULT GetExtent(
            [NativeTypeName("DWORD")] uint dwDrawAspect,
            [NativeTypeName("SIZEL *")] SIZE* psizel
        );

        [VtblIndex(19)]
        HRESULT Advise(IAdviseSink pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection);

        [VtblIndex(20)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection);

        [VtblIndex(21)]
        HRESULT EnumAdvise(IEnumSTATDATA* ppenumAdvise);

        [VtblIndex(22)]
        HRESULT GetMiscStatus(
            [NativeTypeName("DWORD")] uint dwAspect,
            [NativeTypeName("DWORD *")] uint* pdwStatus
        );

        [VtblIndex(23)]
        HRESULT SetColorScheme(LOGPALETTE* pLogpal);
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

        [NativeTypeName("HRESULT (IOleClientSite *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleClientSite, int> SetClientSite;

        [NativeTypeName("HRESULT (IOleClientSite **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleClientSite*, int> GetClientSite;

        [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetHostNames;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Close;

        [NativeTypeName("HRESULT (DWORD, IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMoniker, int> SetMoniker;

        [NativeTypeName("HRESULT (DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMoniker*, int> GetMoniker;

        [NativeTypeName("HRESULT (IDataObject *, BOOL, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject, BOOL, uint, int> InitFromData;

        [NativeTypeName("HRESULT (DWORD, IDataObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDataObject*, int> GetClipboardData;

        [NativeTypeName(
            "HRESULT (LONG, LPMSG, IOleClientSite *, LONG, HWND, LPCRECT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, MSG*, IOleClientSite, int, HWND, RECT*, int> DoVerb;

        [NativeTypeName("HRESULT (IEnumOLEVERB **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumOLEVERB*, int> EnumVerbs;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsUpToDate;

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetUserClassID;

        [NativeTypeName("HRESULT (DWORD, LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetUserType;

        [NativeTypeName("HRESULT (DWORD, SIZEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SIZE*, int> SetExtent;

        [NativeTypeName("HRESULT (DWORD, SIZEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SIZE*, int> GetExtent;

        [NativeTypeName("HRESULT (IAdviseSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAdviseSink, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATDATA*, int> EnumAdvise;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetMiscStatus;

        [NativeTypeName("HRESULT (LOGPALETTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LOGPALETTE*, int> SetColorScheme;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleObject(Silk.NET.Windows.IUnknown value)
    {
        return new IOleObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
