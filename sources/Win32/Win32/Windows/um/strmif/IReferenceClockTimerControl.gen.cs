// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EBEC459C-2ECA-4D42-A8AF-30DF557614B8")]
[NativeTypeName("struct IReferenceClockTimerControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IReferenceClockTimerControl
    : IReferenceClockTimerControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReferenceClockTimerControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IReferenceClockTimerControl, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDefaultTimerResolution(
        [NativeTypeName("REFERENCE_TIME")] long timerResolution
    )
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl, long, int>)((*lpVtbl)[3]))(
            this,
            timerResolution
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDefaultTimerResolution(
        [NativeTypeName("REFERENCE_TIME *")] long* pTimerResolution
    )
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl, long*, int>)((*lpVtbl)[4]))(
            this,
            pTimerResolution
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDefaultTimerResolution([NativeTypeName("REFERENCE_TIME")] long timerResolution);

        [VtblIndex(4)]
        HRESULT GetDefaultTimerResolution(
            [NativeTypeName("REFERENCE_TIME *")] long* pTimerResolution
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

        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> SetDefaultTimerResolution;

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetDefaultTimerResolution;
    }

    /// <summary>Initializes a new instance of the <see cref = "IReferenceClockTimerControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IReferenceClockTimerControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IReferenceClockTimerControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IReferenceClockTimerControl(Silk.NET.Windows.IUnknown value)
    {
        return new IReferenceClockTimerControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IReferenceClockTimerControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IReferenceClockTimerControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IReferenceClockTimerControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
