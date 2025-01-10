// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3787614F-65F7-4003-B673-EAD8293A0E60")]
[NativeTypeName("struct IMFMediaEngineClassFactory3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineClassFactory3
    : IMFMediaEngineClassFactory3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineClassFactory3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFMediaEngineClassFactory3, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMediaKeySystemAccess(
        [NativeTypeName("BSTR")] ushort* keySystem,
        IPropertyStore* ppSupportedConfigurationsArray,
        uint uSize,
        IMFMediaKeySystemAccess* ppKeyAccess
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaEngineClassFactory3,
                ushort*,
                IPropertyStore*,
                uint,
                IMFMediaKeySystemAccess*,
                int>)((*lpVtbl)[3])
        )(this, keySystem, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateMediaKeySystemAccess(
            [NativeTypeName("BSTR")] ushort* keySystem,
            IPropertyStore* ppSupportedConfigurationsArray,
            uint uSize,
            IMFMediaKeySystemAccess* ppKeyAccess
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

        [NativeTypeName(
            "HRESULT (BSTR, IPropertyStore **, UINT, IMFMediaKeySystemAccess **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IPropertyStore*,
            uint,
            IMFMediaKeySystemAccess*,
            int> CreateMediaKeySystemAccess;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaEngineClassFactory3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaEngineClassFactory3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaEngineClassFactory3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaEngineClassFactory3(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaEngineClassFactory3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaEngineClassFactory3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaEngineClassFactory3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaEngineClassFactory3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
