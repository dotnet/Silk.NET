// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D3C4EF59-49CE-4381-9071-D5BCD044C770")]
[NativeTypeName("struct IMFContentEnabler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFContentEnabler : IMFContentEnabler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentEnabler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFContentEnabler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFContentEnabler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentEnabler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEnableType(Guid* pType)
    {
        return ((delegate* unmanaged<IMFContentEnabler, Guid*, int>)((*lpVtbl)[3]))(this, pType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEnableURL(
        [NativeTypeName("LPWSTR *")] ushort** ppwszURL,
        [NativeTypeName("DWORD *")] uint* pcchURL,
        MF_URL_TRUST_STATUS* pTrustStatus
    )
    {
        return (
            (delegate* unmanaged<IMFContentEnabler, ushort**, uint*, MF_URL_TRUST_STATUS*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ppwszURL, pcchURL, pTrustStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEnableData(byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData)
    {
        return ((delegate* unmanaged<IMFContentEnabler, byte**, uint*, int>)((*lpVtbl)[5]))(
            this,
            ppbData,
            pcbData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsAutomaticSupported(BOOL* pfAutomatic)
    {
        return ((delegate* unmanaged<IMFContentEnabler, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pfAutomatic
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AutomaticEnable()
    {
        return ((delegate* unmanaged<IMFContentEnabler, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MonitorEnable()
    {
        return ((delegate* unmanaged<IMFContentEnabler, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Cancel()
    {
        return ((delegate* unmanaged<IMFContentEnabler, int>)((*lpVtbl)[9]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEnableType(Guid* pType);

        [VtblIndex(4)]
        HRESULT GetEnableURL(
            [NativeTypeName("LPWSTR *")] ushort** ppwszURL,
            [NativeTypeName("DWORD *")] uint* pcchURL,
            MF_URL_TRUST_STATUS* pTrustStatus
        );

        [VtblIndex(5)]
        HRESULT GetEnableData(byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData);

        [VtblIndex(6)]
        HRESULT IsAutomaticSupported(BOOL* pfAutomatic);

        [VtblIndex(7)]
        HRESULT AutomaticEnable();

        [VtblIndex(8)]
        HRESULT MonitorEnable();

        [VtblIndex(9)]
        HRESULT Cancel();
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetEnableType;

        [NativeTypeName(
            "HRESULT (LPWSTR *, DWORD *, MF_URL_TRUST_STATUS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort**, uint*, MF_URL_TRUST_STATUS*, int> GetEnableURL;

        [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetEnableData;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsAutomaticSupported;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> AutomaticEnable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MonitorEnable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Cancel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFContentEnabler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFContentEnabler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFContentEnabler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFContentEnabler(Silk.NET.Windows.IUnknown value)
    {
        return new IMFContentEnabler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFContentEnabler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFContentEnabler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFContentEnabler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
