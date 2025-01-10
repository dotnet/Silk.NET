// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000146-0000-0000-C000-000000000046")]
[NativeTypeName("struct IGlobalInterfaceTable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGlobalInterfaceTable : IGlobalInterfaceTable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalInterfaceTable));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGlobalInterfaceTable, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterInterfaceInGlobal(
        IUnknown pUnk,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return (
            (delegate* unmanaged<IGlobalInterfaceTable, IUnknown, Guid*, uint*, int>)((*lpVtbl)[3])
        )(this, pUnk, riid, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RevokeInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable, uint, int>)((*lpVtbl)[4]))(
            this,
            dwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetInterfaceFromGlobal(
        [NativeTypeName("DWORD")] uint dwCookie,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IGlobalInterfaceTable, uint, Guid*, void**, int>)((*lpVtbl)[5])
        )(this, dwCookie, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterInterfaceInGlobal(
            IUnknown pUnk,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(4)]
        HRESULT RevokeInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(5)]
        HRESULT GetInterfaceFromGlobal(
            [NativeTypeName("DWORD")] uint dwCookie,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
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

        [NativeTypeName("HRESULT (IUnknown *, const IID &, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, Guid*, uint*, int> RegisterInterfaceInGlobal;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RevokeInterfaceFromGlobal;

        [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetInterfaceFromGlobal;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGlobalInterfaceTable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGlobalInterfaceTable(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGlobalInterfaceTable"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGlobalInterfaceTable(Silk.NET.Windows.IUnknown value)
    {
        return new IGlobalInterfaceTable(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGlobalInterfaceTable"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGlobalInterfaceTable"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGlobalInterfaceTable value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
