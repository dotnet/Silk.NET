// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F04061AC-1659-4A3F-A954-775AA57FC083")]
[NativeTypeName("struct IAssocHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAssocHandler : IAssocHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAssocHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAssocHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAssocHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAssocHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppsz)
    {
        return ((delegate* unmanaged<IAssocHandler, ushort**, int>)((*lpVtbl)[3]))(this, ppsz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUIName([NativeTypeName("LPWSTR *")] ushort** ppsz)
    {
        return ((delegate* unmanaged<IAssocHandler, ushort**, int>)((*lpVtbl)[4]))(this, ppsz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIconLocation([NativeTypeName("LPWSTR *")] ushort** ppszPath, int* pIndex)
    {
        return ((delegate* unmanaged<IAssocHandler, ushort**, int*, int>)((*lpVtbl)[5]))(
            this,
            ppszPath,
            pIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsRecommended()
    {
        return ((delegate* unmanaged<IAssocHandler, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MakeDefault([NativeTypeName("LPCWSTR")] ushort* pszDescription)
    {
        return ((delegate* unmanaged<IAssocHandler, ushort*, int>)((*lpVtbl)[7]))(
            this,
            pszDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Invoke(IDataObject pdo)
    {
        return ((delegate* unmanaged<IAssocHandler, IDataObject, int>)((*lpVtbl)[8]))(this, pdo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateInvoker(IDataObject pdo, IAssocHandlerInvoker* ppInvoker)
    {
        return (
            (delegate* unmanaged<IAssocHandler, IDataObject, IAssocHandlerInvoker*, int>)(
                (*lpVtbl)[9]
            )
        )(this, pdo, ppInvoker);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppsz);

        [VtblIndex(4)]
        HRESULT GetUIName([NativeTypeName("LPWSTR *")] ushort** ppsz);

        [VtblIndex(5)]
        HRESULT GetIconLocation([NativeTypeName("LPWSTR *")] ushort** ppszPath, int* pIndex);

        [VtblIndex(6)]
        HRESULT IsRecommended();

        [VtblIndex(7)]
        HRESULT MakeDefault([NativeTypeName("LPCWSTR")] ushort* pszDescription);

        [VtblIndex(8)]
        HRESULT Invoke(IDataObject pdo);

        [VtblIndex(9)]
        HRESULT CreateInvoker(IDataObject pdo, IAssocHandlerInvoker* ppInvoker);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetUIName;

        [NativeTypeName("HRESULT (LPWSTR *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int*, int> GetIconLocation;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsRecommended;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> MakeDefault;

        [NativeTypeName("HRESULT (IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject, int> Invoke;

        [NativeTypeName(
            "HRESULT (IDataObject *, IAssocHandlerInvoker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataObject, IAssocHandlerInvoker*, int> CreateInvoker;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAssocHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAssocHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAssocHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAssocHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IAssocHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAssocHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAssocHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAssocHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
