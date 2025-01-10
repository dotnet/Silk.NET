// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("7D0F462F-4064-4862-BC7F-933E5058C10F")]
[NativeTypeName("struct IDxDiagContainer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxDiagContainer : IDxDiagContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxDiagContainer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxDiagContainer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxDiagContainer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxDiagContainer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNumberOfChildContainers([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IDxDiagContainer, uint*, int>)((*lpVtbl)[3]))(this, pdwCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumChildContainerNames(
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* pwszContainer,
        [NativeTypeName("DWORD")] uint cchContainer
    )
    {
        return ((delegate* unmanaged<IDxDiagContainer, uint, ushort*, uint, int>)((*lpVtbl)[4]))(
            this,
            dwIndex,
            pwszContainer,
            cchContainer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetChildContainer(
        [NativeTypeName("LPCWSTR")] ushort* pwszContainer,
        IDxDiagContainer* ppInstance
    )
    {
        return (
            (delegate* unmanaged<IDxDiagContainer, ushort*, IDxDiagContainer*, int>)((*lpVtbl)[5])
        )(this, pwszContainer, ppInstance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetNumberOfProps([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IDxDiagContainer, uint*, int>)((*lpVtbl)[6]))(this, pdwCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumPropNames(
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* pwszPropName,
        [NativeTypeName("DWORD")] uint cchPropName
    )
    {
        return ((delegate* unmanaged<IDxDiagContainer, uint, ushort*, uint, int>)((*lpVtbl)[7]))(
            this,
            dwIndex,
            pwszPropName,
            cchPropName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProp([NativeTypeName("LPCWSTR")] ushort* pwszPropName, VARIANT* pvarProp)
    {
        return ((delegate* unmanaged<IDxDiagContainer, ushort*, VARIANT*, int>)((*lpVtbl)[8]))(
            this,
            pwszPropName,
            pvarProp
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNumberOfChildContainers([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(4)]
        HRESULT EnumChildContainerNames(
            [NativeTypeName("DWORD")] uint dwIndex,
            [NativeTypeName("LPWSTR")] ushort* pwszContainer,
            [NativeTypeName("DWORD")] uint cchContainer
        );

        [VtblIndex(5)]
        HRESULT GetChildContainer(
            [NativeTypeName("LPCWSTR")] ushort* pwszContainer,
            IDxDiagContainer* ppInstance
        );

        [VtblIndex(6)]
        HRESULT GetNumberOfProps([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(7)]
        HRESULT EnumPropNames(
            [NativeTypeName("DWORD")] uint dwIndex,
            [NativeTypeName("LPWSTR")] ushort* pwszPropName,
            [NativeTypeName("DWORD")] uint cchPropName
        );

        [VtblIndex(8)]
        HRESULT GetProp([NativeTypeName("LPCWSTR")] ushort* pwszPropName, VARIANT* pvarProp);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNumberOfChildContainers;

        [NativeTypeName(
            "HRESULT (DWORD, LPWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> EnumChildContainerNames;

        [NativeTypeName(
            "HRESULT (LPCWSTR, IDxDiagContainer **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, IDxDiagContainer*, int> GetChildContainer;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNumberOfProps;

        [NativeTypeName(
            "HRESULT (DWORD, LPWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> EnumPropNames;

        [NativeTypeName(
            "HRESULT (LPCWSTR, VARIANT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetProp;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxDiagContainer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxDiagContainer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxDiagContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxDiagContainer(Silk.NET.Windows.IUnknown value)
    {
        return new IDxDiagContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxDiagContainer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxDiagContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxDiagContainer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
