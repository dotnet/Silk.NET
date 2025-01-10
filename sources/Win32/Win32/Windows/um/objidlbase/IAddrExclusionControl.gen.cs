// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000148-0000-0000-C000-000000000046")]
[NativeTypeName("struct IAddrExclusionControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAddrExclusionControl : IAddrExclusionControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAddrExclusionControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAddrExclusionControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAddrExclusionControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAddrExclusionControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentAddrExclusionList(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppEnumerator
    )
    {
        return ((delegate* unmanaged<IAddrExclusionControl, Guid*, void**, int>)((*lpVtbl)[3]))(
            this,
            riid,
            ppEnumerator
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateAddrExclusionList(IUnknown pEnumerator)
    {
        return ((delegate* unmanaged<IAddrExclusionControl, IUnknown, int>)((*lpVtbl)[4]))(
            this,
            pEnumerator
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrentAddrExclusionList(
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppEnumerator
        );

        [VtblIndex(4)]
        HRESULT UpdateAddrExclusionList(IUnknown pEnumerator);
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

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetCurrentAddrExclusionList;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> UpdateAddrExclusionList;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAddrExclusionControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAddrExclusionControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAddrExclusionControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAddrExclusionControl(Silk.NET.Windows.IUnknown value)
    {
        return new IAddrExclusionControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAddrExclusionControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAddrExclusionControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAddrExclusionControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
