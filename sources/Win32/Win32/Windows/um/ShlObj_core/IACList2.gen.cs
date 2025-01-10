// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("470141A0-5186-11D2-BBB6-0060977B464C")]
[NativeTypeName("struct IACList2 : IACList")]
[NativeInheritance("IACList")]
public unsafe partial struct IACList2 : IACList2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IACList2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IACList2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IACList2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IACList2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Expand([NativeTypeName("PCWSTR")] ushort* pszExpand)
    {
        return ((delegate* unmanaged<IACList2, ushort*, int>)((*lpVtbl)[3]))(this, pszExpand);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOptions([NativeTypeName("DWORD")] uint dwFlag)
    {
        return ((delegate* unmanaged<IACList2, uint, int>)((*lpVtbl)[4]))(this, dwFlag);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag)
    {
        return ((delegate* unmanaged<IACList2, uint*, int>)((*lpVtbl)[5]))(this, pdwFlag);
    }

    public interface Interface : IACList.Interface
    {
        [VtblIndex(4)]
        HRESULT SetOptions([NativeTypeName("DWORD")] uint dwFlag);

        [VtblIndex(5)]
        HRESULT GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag);
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

        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Expand;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOptions;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOptions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IACList2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IACList2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IACList"/> to <see cref = "IACList2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IACList"/> instance to be converted </param>
    public static explicit operator IACList2(Silk.NET.Windows.IACList value)
    {
        return new IACList2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IACList2"/> to <see cref = "Silk.NET.Windows.IACList"/>.</summary>
    /// <param name = "value">The <see cref = "IACList2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IACList(IACList2 value)
    {
        return new Silk.NET.Windows.IACList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IACList2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IACList2(Silk.NET.Windows.IUnknown value)
    {
        return new IACList2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IACList2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IACList2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IACList2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
