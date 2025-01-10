// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("28724C91-DF35-4856-9F76-D6A26413F3DF")]
[NativeTypeName("struct IAudioAmbisonicsControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioAmbisonicsControl
    : IAudioAmbisonicsControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioAmbisonicsControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioAmbisonicsControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData(
        [NativeTypeName("const AMBISONICS_PARAMS *")] AMBISONICS_PARAMS* pAmbisonicsParams,
        [NativeTypeName("UINT32")] uint cbAmbisonicsParams
    )
    {
        return (
            (delegate* unmanaged<IAudioAmbisonicsControl, AMBISONICS_PARAMS*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pAmbisonicsParams, cbAmbisonicsParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetHeadTracking(BOOL bEnableHeadTracking)
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl, BOOL, int>)((*lpVtbl)[4]))(
            this,
            bEnableHeadTracking
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetHeadTracking(BOOL* pbEnableHeadTracking)
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl, BOOL*, int>)((*lpVtbl)[5]))(
            this,
            pbEnableHeadTracking
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRotation(float X, float Y, float Z, float W)
    {
        return (
            (delegate* unmanaged<IAudioAmbisonicsControl, float, float, float, float, int>)(
                (*lpVtbl)[6]
            )
        )(this, X, Y, Z, W);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetData(
            [NativeTypeName("const AMBISONICS_PARAMS *")] AMBISONICS_PARAMS* pAmbisonicsParams,
            [NativeTypeName("UINT32")] uint cbAmbisonicsParams
        );

        [VtblIndex(4)]
        HRESULT SetHeadTracking(BOOL bEnableHeadTracking);

        [VtblIndex(5)]
        HRESULT GetHeadTracking(BOOL* pbEnableHeadTracking);

        [VtblIndex(6)]
        HRESULT SetRotation(float X, float Y, float Z, float W);
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

        [NativeTypeName("HRESULT (const AMBISONICS_PARAMS *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMBISONICS_PARAMS*, uint, int> SetData;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetHeadTracking;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHeadTracking;

        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, int> SetRotation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioAmbisonicsControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioAmbisonicsControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioAmbisonicsControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioAmbisonicsControl(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioAmbisonicsControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioAmbisonicsControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioAmbisonicsControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioAmbisonicsControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
