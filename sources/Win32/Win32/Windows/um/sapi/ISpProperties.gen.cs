// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5B4FB971-B115-4DE1-AD97-E482E3BF6EE4")]
[NativeTypeName("struct ISpProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpProperties : ISpProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpProperties, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPropertyNum(
        [NativeTypeName("LPCWSTR")] ushort* pName,
        [NativeTypeName("LONG")] int lValue
    )
    {
        return ((delegate* unmanaged<ISpProperties, ushort*, int, int>)((*lpVtbl)[3]))(
            this,
            pName,
            lValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyNum(
        [NativeTypeName("LPCWSTR")] ushort* pName,
        [NativeTypeName("LONG *")] int* plValue
    )
    {
        return ((delegate* unmanaged<ISpProperties, ushort*, int*, int>)((*lpVtbl)[4]))(
            this,
            pName,
            plValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPropertyString(
        [NativeTypeName("LPCWSTR")] ushort* pName,
        [NativeTypeName("LPCWSTR")] ushort* pValue
    )
    {
        return ((delegate* unmanaged<ISpProperties, ushort*, ushort*, int>)((*lpVtbl)[5]))(
            this,
            pName,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropertyString(
        [NativeTypeName("LPCWSTR")] ushort* pName,
        [NativeTypeName("LPWSTR *")] ushort** ppCoMemValue
    )
    {
        return ((delegate* unmanaged<ISpProperties, ushort*, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pName,
            ppCoMemValue
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPropertyNum(
            [NativeTypeName("LPCWSTR")] ushort* pName,
            [NativeTypeName("LONG")] int lValue
        );

        [VtblIndex(4)]
        HRESULT GetPropertyNum(
            [NativeTypeName("LPCWSTR")] ushort* pName,
            [NativeTypeName("LONG *")] int* plValue
        );

        [VtblIndex(5)]
        HRESULT SetPropertyString(
            [NativeTypeName("LPCWSTR")] ushort* pName,
            [NativeTypeName("LPCWSTR")] ushort* pValue
        );

        [VtblIndex(6)]
        HRESULT GetPropertyString(
            [NativeTypeName("LPCWSTR")] ushort* pName,
            [NativeTypeName("LPWSTR *")] ushort** ppCoMemValue
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

        [NativeTypeName("HRESULT (LPCWSTR, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> SetPropertyNum;

        [NativeTypeName("HRESULT (LPCWSTR, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, int> GetPropertyNum;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetPropertyString;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetPropertyString;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpProperties(Silk.NET.Windows.IUnknown value)
    {
        return new ISpProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
