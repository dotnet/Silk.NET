// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("88DDCD21-03C3-4275-91ED-55EE3929328F")]
[NativeTypeName("struct IMFRateControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRateControl : IMFRateControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRateControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRateControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFRateControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRateControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetRate(BOOL fThin, float flRate)
    {
        return ((delegate* unmanaged<IMFRateControl, BOOL, float, int>)((*lpVtbl)[3]))(
            this,
            fThin,
            flRate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRate(BOOL* pfThin, float* pflRate)
    {
        return ((delegate* unmanaged<IMFRateControl, BOOL*, float*, int>)((*lpVtbl)[4]))(
            this,
            pfThin,
            pflRate
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetRate(BOOL fThin, float flRate);

        [VtblIndex(4)]
        HRESULT GetRate(BOOL* pfThin, float* pflRate);
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

        [NativeTypeName("HRESULT (BOOL, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, float, int> SetRate;

        [NativeTypeName("HRESULT (BOOL *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, float*, int> GetRate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFRateControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFRateControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFRateControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFRateControl(Silk.NET.Windows.IUnknown value)
    {
        return new IMFRateControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFRateControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFRateControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFRateControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
