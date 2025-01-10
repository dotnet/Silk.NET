// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C56156C6-EA5B-48A5-9DF8-FBE035D0929E")]
[NativeTypeName("struct IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory")]
[NativeInheritance("IMFMediaEngineClassFactory")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaEngineClassFactoryEx
    : IMFMediaEngineClassFactoryEx.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineClassFactoryEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFMediaEngineClassFactoryEx, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance(
        [NativeTypeName("DWORD")] uint dwFlags,
        IMFAttributes pAttr,
        IMFMediaEngine* ppPlayer
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaEngineClassFactoryEx,
                uint,
                IMFAttributes,
                IMFMediaEngine*,
                int>)((*lpVtbl)[3])
        )(this, dwFlags, pAttr, ppPlayer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateTimeRange(IMFMediaTimeRange* ppTimeRange)
    {
        return (
            (delegate* unmanaged<IMFMediaEngineClassFactoryEx, IMFMediaTimeRange*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ppTimeRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateError(IMFMediaError* ppError)
    {
        return (
            (delegate* unmanaged<IMFMediaEngineClassFactoryEx, IMFMediaError*, int>)((*lpVtbl)[5])
        )(this, ppError);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateMediaSourceExtension(
        [NativeTypeName("DWORD")] uint dwFlags,
        IMFAttributes pAttr,
        IMFMediaSourceExtension* ppMSE
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaEngineClassFactoryEx,
                uint,
                IMFAttributes,
                IMFMediaSourceExtension*,
                int>)((*lpVtbl)[6])
        )(this, dwFlags, pAttr, ppMSE);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMediaKeys(
        [NativeTypeName("BSTR")] ushort* keySystem,
        [NativeTypeName("BSTR")] ushort* cdmStorePath,
        IMFMediaKeys* ppKeys
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaEngineClassFactoryEx,
                ushort*,
                ushort*,
                IMFMediaKeys*,
                int>)((*lpVtbl)[7])
        )(this, keySystem, cdmStorePath, ppKeys);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsTypeSupported(
        [NativeTypeName("BSTR")] ushort* type,
        [NativeTypeName("BSTR")] ushort* keySystem,
        BOOL* isSupported
    )
    {
        return (
            (delegate* unmanaged<IMFMediaEngineClassFactoryEx, ushort*, ushort*, BOOL*, int>)(
                (*lpVtbl)[8]
            )
        )(this, type, keySystem, isSupported);
    }

    public interface Interface : IMFMediaEngineClassFactory.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateMediaSourceExtension(
            [NativeTypeName("DWORD")] uint dwFlags,
            IMFAttributes pAttr,
            IMFMediaSourceExtension* ppMSE
        );

        [VtblIndex(7)]
        HRESULT CreateMediaKeys(
            [NativeTypeName("BSTR")] ushort* keySystem,
            [NativeTypeName("BSTR")] ushort* cdmStorePath,
            IMFMediaKeys* ppKeys
        );

        [VtblIndex(8)]
        HRESULT IsTypeSupported(
            [NativeTypeName("BSTR")] ushort* type,
            [NativeTypeName("BSTR")] ushort* keySystem,
            BOOL* isSupported
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
            "HRESULT (DWORD, IMFAttributes *, IMFMediaEngine **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IMFAttributes,
            IMFMediaEngine*,
            int> CreateInstance;

        [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaTimeRange*, int> CreateTimeRange;

        [NativeTypeName("HRESULT (IMFMediaError **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaError*, int> CreateError;

        [NativeTypeName(
            "HRESULT (DWORD, IMFAttributes *, IMFMediaSourceExtension **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IMFAttributes,
            IMFMediaSourceExtension*,
            int> CreateMediaSourceExtension;

        [NativeTypeName("HRESULT (BSTR, BSTR, IMFMediaKeys **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IMFMediaKeys*, int> CreateMediaKeys;

        [NativeTypeName("HRESULT (BSTR, BSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, BOOL*, int> IsTypeSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaEngineClassFactoryEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaEngineClassFactoryEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaEngineClassFactory"/> to <see cref = "IMFMediaEngineClassFactoryEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaEngineClassFactory"/> instance to be converted </param>
    public static explicit operator IMFMediaEngineClassFactoryEx(
        Silk.NET.Windows.IMFMediaEngineClassFactory value
    )
    {
        return new IMFMediaEngineClassFactoryEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaEngineClassFactoryEx"/> to <see cref = "Silk.NET.Windows.IMFMediaEngineClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaEngineClassFactoryEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaEngineClassFactory(
        IMFMediaEngineClassFactoryEx value
    )
    {
        return new Silk.NET.Windows.IMFMediaEngineClassFactory(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaEngineClassFactoryEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaEngineClassFactoryEx(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaEngineClassFactoryEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaEngineClassFactoryEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaEngineClassFactoryEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaEngineClassFactoryEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
