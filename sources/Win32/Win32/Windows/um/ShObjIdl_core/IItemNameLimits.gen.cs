// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1DF0D7F1-B267-4D28-8B10-12E23202A5C4")]
[NativeTypeName("struct IItemNameLimits : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IItemNameLimits : IItemNameLimits.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IItemNameLimits));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IItemNameLimits, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IItemNameLimits, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IItemNameLimits, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetValidCharacters(
        [NativeTypeName("LPWSTR *")] ushort** ppwszValidChars,
        [NativeTypeName("LPWSTR *")] ushort** ppwszInvalidChars
    )
    {
        return ((delegate* unmanaged<IItemNameLimits, ushort**, ushort**, int>)((*lpVtbl)[3]))(
            this,
            ppwszValidChars,
            ppwszInvalidChars
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMaxLength([NativeTypeName("LPCWSTR")] ushort* pszName, int* piMaxNameLen)
    {
        return ((delegate* unmanaged<IItemNameLimits, ushort*, int*, int>)((*lpVtbl)[4]))(
            this,
            pszName,
            piMaxNameLen
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetValidCharacters(
            [NativeTypeName("LPWSTR *")] ushort** ppwszValidChars,
            [NativeTypeName("LPWSTR *")] ushort** ppwszInvalidChars
        );

        [VtblIndex(4)]
        HRESULT GetMaxLength([NativeTypeName("LPCWSTR")] ushort* pszName, int* piMaxNameLen);
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

        [NativeTypeName("HRESULT (LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, ushort**, int> GetValidCharacters;

        [NativeTypeName("HRESULT (LPCWSTR, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, int> GetMaxLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "IItemNameLimits"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IItemNameLimits(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IItemNameLimits"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IItemNameLimits(Silk.NET.Windows.IUnknown value)
    {
        return new IItemNameLimits(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IItemNameLimits"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IItemNameLimits"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IItemNameLimits value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
