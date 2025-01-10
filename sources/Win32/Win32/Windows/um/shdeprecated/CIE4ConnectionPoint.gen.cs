// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000000-0000-0000-0000-000000000000")]
[NativeTypeName("struct CIE4ConnectionPoint : IConnectionPoint")]
[NativeInheritance("IConnectionPoint")]
public unsafe partial struct CIE4ConnectionPoint : CIE4ConnectionPoint.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CIE4ConnectionPoint));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<CIE4ConnectionPoint, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetConnectionInterface([NativeTypeName("IID *")] Guid* pIID)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint, Guid*, int>)((*lpVtbl)[3]))(this, pIID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetConnectionPointContainer(IConnectionPointContainer* ppCPC)
    {
        return (
            (delegate* unmanaged<CIE4ConnectionPoint, IConnectionPointContainer*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ppCPC);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Advise(IUnknown pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint, IUnknown, uint*, int>)((*lpVtbl)[5]))(
            this,
            pUnkSink,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint, uint, int>)((*lpVtbl)[6]))(
            this,
            dwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumConnections(IEnumConnections* ppEnum)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint, IEnumConnections*, int>)((*lpVtbl)[7]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DoInvokeIE4(
        BOOL* pf,
        void** ppv,
        [NativeTypeName("DISPID")] int dispid,
        DISPPARAMS* pdispparams
    )
    {
        return (
            (delegate* unmanaged<CIE4ConnectionPoint, BOOL*, void**, int, DISPPARAMS*, int>)(
                (*lpVtbl)[8]
            )
        )(this, pf, ppv, dispid, pdispparams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DoInvokePIDLIE4(
        [NativeTypeName("DISPID")] int dispid,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        BOOL fCanCancel
    )
    {
        return (
            (delegate* unmanaged<CIE4ConnectionPoint, int, ITEMIDLIST*, BOOL, int>)((*lpVtbl)[9])
        )(this, dispid, pidl, fCanCancel);
    }

    public interface Interface : IConnectionPoint.Interface
    {
        [VtblIndex(8)]
        HRESULT DoInvokeIE4(
            BOOL* pf,
            void** ppv,
            [NativeTypeName("DISPID")] int dispid,
            DISPPARAMS* pdispparams
        );

        [VtblIndex(9)]
        HRESULT DoInvokePIDLIE4(
            [NativeTypeName("DISPID")] int dispid,
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
            BOOL fCanCancel
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

        [NativeTypeName("HRESULT (IID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetConnectionInterface;

        [NativeTypeName("HRESULT (IConnectionPointContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IConnectionPointContainer*,
            int> GetConnectionPointContainer;

        [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (IEnumConnections **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumConnections*, int> EnumConnections;

        [NativeTypeName("HRESULT (BOOL *, void **, DISPID, DISPPARAMS *)")]
        public delegate* unmanaged<TSelf*, BOOL*, void**, int, DISPPARAMS*, int> DoInvokeIE4;

        [NativeTypeName("HRESULT (DISPID, LPCITEMIDLIST, BOOL)")]
        public delegate* unmanaged<TSelf*, int, ITEMIDLIST*, BOOL, int> DoInvokePIDLIE4;
    }

    /// <summary>Initializes a new instance of the <see cref = "CIE4ConnectionPoint"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public CIE4ConnectionPoint(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IConnectionPoint"/> to <see cref = "CIE4ConnectionPoint"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IConnectionPoint"/> instance to be converted </param>
    public static explicit operator CIE4ConnectionPoint(Silk.NET.Windows.IConnectionPoint value)
    {
        return new CIE4ConnectionPoint(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "CIE4ConnectionPoint"/> to <see cref = "Silk.NET.Windows.IConnectionPoint"/>.</summary>
    /// <param name = "value">The <see cref = "CIE4ConnectionPoint"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IConnectionPoint(CIE4ConnectionPoint value)
    {
        return new Silk.NET.Windows.IConnectionPoint(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "CIE4ConnectionPoint"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator CIE4ConnectionPoint(Silk.NET.Windows.IUnknown value)
    {
        return new CIE4ConnectionPoint(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "CIE4ConnectionPoint"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "CIE4ConnectionPoint"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(CIE4ConnectionPoint value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
