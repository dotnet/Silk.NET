// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("31739D04-3471-4CF4-9A7C-57A44AE71956")]
[NativeTypeName("struct IWbemUnsecuredApartment : IUnsecuredApartment")]
[NativeInheritance("IUnsecuredApartment")]
public unsafe partial struct IWbemUnsecuredApartment
    : IWbemUnsecuredApartment.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemUnsecuredApartment));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemUnsecuredApartment, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemUnsecuredApartment, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemUnsecuredApartment, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateObjectStub(IUnknown pObject, IUnknown* ppStub)
    {
        return (
            (delegate* unmanaged<IWbemUnsecuredApartment, IUnknown, IUnknown*, int>)((*lpVtbl)[3])
        )(this, pObject, ppStub);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateSinkStub(
        IWbemObjectSink pSink,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* wszReserved,
        IWbemObjectSink* ppStub
    )
    {
        return (
            (delegate* unmanaged<
                IWbemUnsecuredApartment,
                IWbemObjectSink,
                uint,
                ushort*,
                IWbemObjectSink*,
                int>)((*lpVtbl)[4])
        )(this, pSink, dwFlags, wszReserved, ppStub);
    }

    public interface Interface : IUnsecuredApartment.Interface
    {
        [VtblIndex(4)]
        HRESULT CreateSinkStub(
            IWbemObjectSink pSink,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LPCWSTR")] ushort* wszReserved,
            IWbemObjectSink* ppStub
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

        [NativeTypeName("HRESULT (IUnknown *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, IUnknown*, int> CreateObjectStub;

        [NativeTypeName(
            "HRESULT (IWbemObjectSink *, DWORD, LPCWSTR, IWbemObjectSink **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWbemObjectSink,
            uint,
            ushort*,
            IWbemObjectSink*,
            int> CreateSinkStub;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemUnsecuredApartment"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemUnsecuredApartment(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnsecuredApartment"/> to <see cref = "IWbemUnsecuredApartment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnsecuredApartment"/> instance to be converted </param>
    public static explicit operator IWbemUnsecuredApartment(
        Silk.NET.Windows.IUnsecuredApartment value
    )
    {
        return new IWbemUnsecuredApartment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemUnsecuredApartment"/> to <see cref = "Silk.NET.Windows.IUnsecuredApartment"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemUnsecuredApartment"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnsecuredApartment(
        IWbemUnsecuredApartment value
    )
    {
        return new Silk.NET.Windows.IUnsecuredApartment(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemUnsecuredApartment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemUnsecuredApartment(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemUnsecuredApartment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemUnsecuredApartment"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemUnsecuredApartment"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemUnsecuredApartment value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
