// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AA80E7F0-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfKeystrokeMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfKeystrokeMgr : ITfKeystrokeMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfKeystrokeMgr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfKeystrokeMgr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseKeyEventSink(
        [NativeTypeName("TfClientId")] uint tid,
        ITfKeyEventSink pSink,
        BOOL fForeground
    )
    {
        return (
            (delegate* unmanaged<ITfKeystrokeMgr, uint, ITfKeyEventSink, BOOL, int>)((*lpVtbl)[3])
        )(this, tid, pSink, fForeground);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseKeyEventSink([NativeTypeName("TfClientId")] uint tid)
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, uint, int>)((*lpVtbl)[4]))(this, tid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetForeground([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, Guid*, int>)((*lpVtbl)[5]))(this, pclsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TestKeyDown(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, WPARAM, LPARAM, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            wParam,
            lParam,
            pfEaten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TestKeyUp(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, WPARAM, LPARAM, BOOL*, int>)((*lpVtbl)[7]))(
            this,
            wParam,
            lParam,
            pfEaten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT KeyDown(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, WPARAM, LPARAM, BOOL*, int>)((*lpVtbl)[8]))(
            this,
            wParam,
            lParam,
            pfEaten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT KeyUp(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, WPARAM, LPARAM, BOOL*, int>)((*lpVtbl)[9]))(
            this,
            wParam,
            lParam,
            pfEaten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPreservedKey(
        ITfContext pic,
        [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey,
        Guid* pguid
    )
    {
        return (
            (delegate* unmanaged<ITfKeystrokeMgr, ITfContext, TF_PRESERVEDKEY*, Guid*, int>)(
                (*lpVtbl)[10]
            )
        )(this, pic, pprekey, pguid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsPreservedKey(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey,
        BOOL* pfRegistered
    )
    {
        return (
            (delegate* unmanaged<ITfKeystrokeMgr, Guid*, TF_PRESERVEDKEY*, BOOL*, int>)(
                (*lpVtbl)[11]
            )
        )(this, rguid, pprekey, pfRegistered);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PreserveKey(
        [NativeTypeName("TfClientId")] uint tid,
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* prekey,
        [NativeTypeName("const WCHAR *")] ushort* pchDesc,
        [NativeTypeName("ULONG")] uint cchDesc
    )
    {
        return (
            (delegate* unmanaged<
                ITfKeystrokeMgr,
                uint,
                Guid*,
                TF_PRESERVEDKEY*,
                ushort*,
                uint,
                int>)((*lpVtbl)[12])
        )(this, tid, rguid, prekey, pchDesc, cchDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UnpreserveKey(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey
    )
    {
        return (
            (delegate* unmanaged<ITfKeystrokeMgr, Guid*, TF_PRESERVEDKEY*, int>)((*lpVtbl)[13])
        )(this, rguid, pprekey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetPreservedKeyDescription(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("const WCHAR *")] ushort* pchDesc,
        [NativeTypeName("ULONG")] uint cchDesc
    )
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, Guid*, ushort*, uint, int>)((*lpVtbl)[14]))(
            this,
            rguid,
            pchDesc,
            cchDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPreservedKeyDescription(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("BSTR *")] ushort** pbstrDesc
    )
    {
        return ((delegate* unmanaged<ITfKeystrokeMgr, Guid*, ushort**, int>)((*lpVtbl)[15]))(
            this,
            rguid,
            pbstrDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SimulatePreservedKey(
        ITfContext pic,
        [NativeTypeName("const GUID &")] Guid* rguid,
        BOOL* pfEaten
    )
    {
        return (
            (delegate* unmanaged<ITfKeystrokeMgr, ITfContext, Guid*, BOOL*, int>)((*lpVtbl)[16])
        )(this, pic, rguid, pfEaten);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseKeyEventSink(
            [NativeTypeName("TfClientId")] uint tid,
            ITfKeyEventSink pSink,
            BOOL fForeground
        );

        [VtblIndex(4)]
        HRESULT UnadviseKeyEventSink([NativeTypeName("TfClientId")] uint tid);

        [VtblIndex(5)]
        HRESULT GetForeground([NativeTypeName("CLSID *")] Guid* pclsid);

        [VtblIndex(6)]
        HRESULT TestKeyDown(WPARAM wParam, LPARAM lParam, BOOL* pfEaten);

        [VtblIndex(7)]
        HRESULT TestKeyUp(WPARAM wParam, LPARAM lParam, BOOL* pfEaten);

        [VtblIndex(8)]
        HRESULT KeyDown(WPARAM wParam, LPARAM lParam, BOOL* pfEaten);

        [VtblIndex(9)]
        HRESULT KeyUp(WPARAM wParam, LPARAM lParam, BOOL* pfEaten);

        [VtblIndex(10)]
        HRESULT GetPreservedKey(
            ITfContext pic,
            [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey,
            Guid* pguid
        );

        [VtblIndex(11)]
        HRESULT IsPreservedKey(
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey,
            BOOL* pfRegistered
        );

        [VtblIndex(12)]
        HRESULT PreserveKey(
            [NativeTypeName("TfClientId")] uint tid,
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* prekey,
            [NativeTypeName("const WCHAR *")] ushort* pchDesc,
            [NativeTypeName("ULONG")] uint cchDesc
        );

        [VtblIndex(13)]
        HRESULT UnpreserveKey(
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey
        );

        [VtblIndex(14)]
        HRESULT SetPreservedKeyDescription(
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("const WCHAR *")] ushort* pchDesc,
            [NativeTypeName("ULONG")] uint cchDesc
        );

        [VtblIndex(15)]
        HRESULT GetPreservedKeyDescription(
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("BSTR *")] ushort** pbstrDesc
        );

        [VtblIndex(16)]
        HRESULT SimulatePreservedKey(
            ITfContext pic,
            [NativeTypeName("const GUID &")] Guid* rguid,
            BOOL* pfEaten
        );
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

        [NativeTypeName("HRESULT (TfClientId, ITfKeyEventSink *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfKeyEventSink, BOOL, int> AdviseKeyEventSink;

        [NativeTypeName("HRESULT (TfClientId) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnadviseKeyEventSink;

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetForeground;

        [NativeTypeName("HRESULT (WPARAM, LPARAM, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WPARAM, LPARAM, BOOL*, int> TestKeyDown;

        [NativeTypeName("HRESULT (WPARAM, LPARAM, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WPARAM, LPARAM, BOOL*, int> TestKeyUp;

        [NativeTypeName("HRESULT (WPARAM, LPARAM, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WPARAM, LPARAM, BOOL*, int> KeyDown;

        [NativeTypeName("HRESULT (WPARAM, LPARAM, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WPARAM, LPARAM, BOOL*, int> KeyUp;

        [NativeTypeName(
            "HRESULT (ITfContext *, const TF_PRESERVEDKEY *, GUID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITfContext,
            TF_PRESERVEDKEY*,
            Guid*,
            int> GetPreservedKey;

        [NativeTypeName(
            "HRESULT (const GUID &, const TF_PRESERVEDKEY *, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, TF_PRESERVEDKEY*, BOOL*, int> IsPreservedKey;

        [NativeTypeName(
            "HRESULT (TfClientId, const GUID &, const TF_PRESERVEDKEY *, const WCHAR *, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Guid*,
            TF_PRESERVEDKEY*,
            ushort*,
            uint,
            int> PreserveKey;

        [NativeTypeName("HRESULT (const GUID &, const TF_PRESERVEDKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, TF_PRESERVEDKEY*, int> UnpreserveKey;

        [NativeTypeName("HRESULT (const GUID &, const WCHAR *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, uint, int> SetPreservedKeyDescription;

        [NativeTypeName("HRESULT (const GUID &, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, int> GetPreservedKeyDescription;

        [NativeTypeName("HRESULT (ITfContext *, const GUID &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext, Guid*, BOOL*, int> SimulatePreservedKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfKeystrokeMgr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfKeystrokeMgr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfKeystrokeMgr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfKeystrokeMgr(Silk.NET.Windows.IUnknown value)
    {
        return new ITfKeystrokeMgr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfKeystrokeMgr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfKeystrokeMgr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfKeystrokeMgr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
