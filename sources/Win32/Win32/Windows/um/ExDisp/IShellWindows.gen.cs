// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
[NativeTypeName("struct IShellWindows : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IShellWindows : IShellWindows.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellWindows));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellWindows, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellWindows, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellWindows, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellWindows, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IShellWindows, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IShellWindows, Guid*, ushort**, uint, uint, int*, int>)(
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
                IShellWindows,
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
    public HRESULT get_Count([NativeTypeName("long *")] int* Count)
    {
        return ((delegate* unmanaged<IShellWindows, int*, int>)((*lpVtbl)[7]))(this, Count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Item(VARIANT index, IDispatch* Folder)
    {
        return ((delegate* unmanaged<IShellWindows, VARIANT, IDispatch*, int>)((*lpVtbl)[8]))(
            this,
            index,
            Folder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT _NewEnum(IUnknown* ppunk)
    {
        return ((delegate* unmanaged<IShellWindows, IUnknown*, int>)((*lpVtbl)[9]))(this, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Register(
        IDispatch pid,
        [NativeTypeName("long")] int hwnd,
        int swClass,
        [NativeTypeName("long *")] int* plCookie
    )
    {
        return (
            (delegate* unmanaged<IShellWindows, IDispatch, int, int, int*, int>)((*lpVtbl)[10])
        )(this, pid, hwnd, swClass, plCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RegisterPending(
        [NativeTypeName("long")] int lThreadId,
        VARIANT* pvarloc,
        VARIANT* pvarlocRoot,
        int swClass,
        [NativeTypeName("long *")] int* plCookie
    )
    {
        return (
            (delegate* unmanaged<IShellWindows, int, VARIANT*, VARIANT*, int, int*, int>)(
                (*lpVtbl)[11]
            )
        )(this, lThreadId, pvarloc, pvarlocRoot, swClass, plCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Revoke([NativeTypeName("long")] int lCookie)
    {
        return ((delegate* unmanaged<IShellWindows, int, int>)((*lpVtbl)[12]))(this, lCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OnNavigate([NativeTypeName("long")] int lCookie, VARIANT* pvarLoc)
    {
        return ((delegate* unmanaged<IShellWindows, int, VARIANT*, int>)((*lpVtbl)[13]))(
            this,
            lCookie,
            pvarLoc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OnActivated(
        [NativeTypeName("long")] int lCookie,
        [NativeTypeName("VARIANT_BOOL")] short fActive
    )
    {
        return ((delegate* unmanaged<IShellWindows, int, short, int>)((*lpVtbl)[14]))(
            this,
            lCookie,
            fActive
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT FindWindowSW(
        VARIANT* pvarLoc,
        VARIANT* pvarLocRoot,
        int swClass,
        [NativeTypeName("long *")] int* phwnd,
        int swfwOptions,
        IDispatch* ppdispOut
    )
    {
        return (
            (delegate* unmanaged<
                IShellWindows,
                VARIANT*,
                VARIANT*,
                int,
                int*,
                int,
                IDispatch*,
                int>)((*lpVtbl)[15])
        )(this, pvarLoc, pvarLocRoot, swClass, phwnd, swfwOptions, ppdispOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT OnCreated([NativeTypeName("long")] int lCookie, IUnknown punk)
    {
        return ((delegate* unmanaged<IShellWindows, int, IUnknown, int>)((*lpVtbl)[16]))(
            this,
            lCookie,
            punk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ProcessAttachDetach([NativeTypeName("VARIANT_BOOL")] short fAttach)
    {
        return ((delegate* unmanaged<IShellWindows, short, int>)((*lpVtbl)[17]))(this, fAttach);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Count([NativeTypeName("long *")] int* Count);

        [VtblIndex(8)]
        HRESULT Item(VARIANT index, IDispatch* Folder);

        [VtblIndex(9)]
        HRESULT _NewEnum(IUnknown* ppunk);

        [VtblIndex(10)]
        HRESULT Register(
            IDispatch pid,
            [NativeTypeName("long")] int hwnd,
            int swClass,
            [NativeTypeName("long *")] int* plCookie
        );

        [VtblIndex(11)]
        HRESULT RegisterPending(
            [NativeTypeName("long")] int lThreadId,
            VARIANT* pvarloc,
            VARIANT* pvarlocRoot,
            int swClass,
            [NativeTypeName("long *")] int* plCookie
        );

        [VtblIndex(12)]
        HRESULT Revoke([NativeTypeName("long")] int lCookie);

        [VtblIndex(13)]
        HRESULT OnNavigate([NativeTypeName("long")] int lCookie, VARIANT* pvarLoc);

        [VtblIndex(14)]
        HRESULT OnActivated(
            [NativeTypeName("long")] int lCookie,
            [NativeTypeName("VARIANT_BOOL")] short fActive
        );

        [VtblIndex(15)]
        HRESULT FindWindowSW(
            VARIANT* pvarLoc,
            VARIANT* pvarLocRoot,
            int swClass,
            [NativeTypeName("long *")] int* phwnd,
            int swfwOptions,
            IDispatch* ppdispOut
        );

        [VtblIndex(16)]
        HRESULT OnCreated([NativeTypeName("long")] int lCookie, IUnknown punk);

        [VtblIndex(17)]
        HRESULT ProcessAttachDetach([NativeTypeName("VARIANT_BOOL")] short fAttach);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IDispatch*, int> Item;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> _NewEnum;

        [NativeTypeName("HRESULT (IDispatch *, long, int, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int, int, int*, int> Register;

        [NativeTypeName(
            "HRESULT (long, VARIANT *, VARIANT *, int, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, VARIANT*, VARIANT*, int, int*, int> RegisterPending;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Revoke;

        [NativeTypeName("HRESULT (long, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, VARIANT*, int> OnNavigate;

        [NativeTypeName("HRESULT (long, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, short, int> OnActivated;

        [NativeTypeName(
            "HRESULT (VARIANT *, VARIANT *, int, long *, int, IDispatch **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VARIANT*,
            VARIANT*,
            int,
            int*,
            int,
            IDispatch*,
            int> FindWindowSW;

        [NativeTypeName("HRESULT (long, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IUnknown, int> OnCreated;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> ProcessAttachDetach;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellWindows"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellWindows(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IShellWindows"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IShellWindows(Silk.NET.Windows.IDispatch value)
    {
        return new IShellWindows(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellWindows"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IShellWindows"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IShellWindows value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellWindows"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellWindows(Silk.NET.Windows.IUnknown value)
    {
        return new IShellWindows(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellWindows"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellWindows"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellWindows value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
