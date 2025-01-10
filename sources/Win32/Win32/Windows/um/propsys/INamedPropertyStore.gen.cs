// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("71604B0F-97B0-4764-8577-2F13E98A1422")]
[NativeTypeName("struct INamedPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INamedPropertyStore : INamedPropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INamedPropertyStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INamedPropertyStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INamedPropertyStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INamedPropertyStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNamedValue([NativeTypeName("LPCWSTR")] ushort* pszName, PROPVARIANT* ppropvar)
    {
        return (
            (delegate* unmanaged<INamedPropertyStore, ushort*, PROPVARIANT*, int>)((*lpVtbl)[3])
        )(this, pszName, ppropvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNamedValue(
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
    )
    {
        return (
            (delegate* unmanaged<INamedPropertyStore, ushort*, PROPVARIANT*, int>)((*lpVtbl)[4])
        )(this, pszName, propvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNameCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<INamedPropertyStore, uint*, int>)((*lpVtbl)[5]))(
            this,
            pdwCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetNameAt(
        [NativeTypeName("DWORD")] uint iProp,
        [NativeTypeName("BSTR *")] ushort** pbstrName
    )
    {
        return ((delegate* unmanaged<INamedPropertyStore, uint, ushort**, int>)((*lpVtbl)[6]))(
            this,
            iProp,
            pbstrName
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNamedValue([NativeTypeName("LPCWSTR")] ushort* pszName, PROPVARIANT* ppropvar);

        [VtblIndex(4)]
        HRESULT SetNamedValue(
            [NativeTypeName("LPCWSTR")] ushort* pszName,
            [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
        );

        [VtblIndex(5)]
        HRESULT GetNameCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(6)]
        HRESULT GetNameAt(
            [NativeTypeName("DWORD")] uint iProp,
            [NativeTypeName("BSTR *")] ushort** pbstrName
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

        [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, PROPVARIANT*, int> GetNamedValue;

        [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, PROPVARIANT*, int> SetNamedValue;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNameCount;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetNameAt;
    }

    /// <summary>Initializes a new instance of the <see cref = "INamedPropertyStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INamedPropertyStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INamedPropertyStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INamedPropertyStore(Silk.NET.Windows.IUnknown value)
    {
        return new INamedPropertyStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INamedPropertyStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INamedPropertyStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INamedPropertyStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
