// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BB08F7A9-607A-4384-8623-056892B64371")]
[NativeTypeName("struct ITfCompartment : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCompartment : ITfCompartment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCompartment));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCompartment, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfCompartment, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCompartment, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetValue(
        [NativeTypeName("TfClientId")] uint tid,
        [NativeTypeName("const VARIANT *")] VARIANT* pvarValue
    )
    {
        return ((delegate* unmanaged<ITfCompartment, uint, VARIANT*, int>)((*lpVtbl)[3]))(
            this,
            tid,
            pvarValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetValue(VARIANT* pvarValue)
    {
        return ((delegate* unmanaged<ITfCompartment, VARIANT*, int>)((*lpVtbl)[4]))(
            this,
            pvarValue
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetValue(
            [NativeTypeName("TfClientId")] uint tid,
            [NativeTypeName("const VARIANT *")] VARIANT* pvarValue
        );

        [VtblIndex(4)]
        HRESULT GetValue(VARIANT* pvarValue);
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

        [NativeTypeName("HRESULT (TfClientId, const VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, VARIANT*, int> SetValue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> GetValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfCompartment"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfCompartment(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfCompartment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfCompartment(Silk.NET.Windows.IUnknown value)
    {
        return new ITfCompartment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfCompartment"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfCompartment"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfCompartment value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
