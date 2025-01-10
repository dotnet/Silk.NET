// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E9707E05-6D55-4636-B185-3DE21210BD75")]
[NativeTypeName("struct IMFMediaKeySession2 : IMFMediaKeySession")]
[NativeInheritance("IMFMediaKeySession")]
public unsafe partial struct IMFMediaKeySession2 : IMFMediaKeySession2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaKeySession2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaKeySession2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetError(ushort* code, [NativeTypeName("DWORD *")] uint* systemCode)
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, ushort*, uint*, int>)((*lpVtbl)[3]))(
            this,
            code,
            systemCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, ushort**, int>)((*lpVtbl)[4]))(
            this,
            keySystem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_SessionId([NativeTypeName("BSTR *")] ushort** sessionId)
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, ushort**, int>)((*lpVtbl)[5]))(
            this,
            sessionId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Update(
        [NativeTypeName("const BYTE *")] byte* key,
        [NativeTypeName("DWORD")] uint cb
    )
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, byte*, uint, int>)((*lpVtbl)[6]))(
            this,
            key,
            cb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyStatuses(MFMediaKeyStatus** pKeyStatusesArray, uint* puSize)
    {
        return (
            (delegate* unmanaged<IMFMediaKeySession2, MFMediaKeyStatus**, uint*, int>)((*lpVtbl)[8])
        )(this, pKeyStatusesArray, puSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Load([NativeTypeName("BSTR")] ushort* bstrSessionId, BOOL* pfLoaded)
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, ushort*, BOOL*, int>)((*lpVtbl)[9]))(
            this,
            bstrSessionId,
            pfLoaded
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GenerateRequest(
        [NativeTypeName("BSTR")] ushort* initDataType,
        [NativeTypeName("const BYTE *")] byte* pbInitData,
        [NativeTypeName("DWORD")] uint cb
    )
    {
        return (
            (delegate* unmanaged<IMFMediaKeySession2, ushort*, byte*, uint, int>)((*lpVtbl)[10])
        )(this, initDataType, pbInitData, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Expiration(double* dblExpiration)
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, double*, int>)((*lpVtbl)[11]))(
            this,
            dblExpiration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Remove()
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaKeySession2, int>)((*lpVtbl)[13]))(this);
    }

    public interface Interface : IMFMediaKeySession.Interface
    {
        [VtblIndex(8)]
        HRESULT get_KeyStatuses(MFMediaKeyStatus** pKeyStatusesArray, uint* puSize);

        [VtblIndex(9)]
        HRESULT Load([NativeTypeName("BSTR")] ushort* bstrSessionId, BOOL* pfLoaded);

        [VtblIndex(10)]
        HRESULT GenerateRequest(
            [NativeTypeName("BSTR")] ushort* initDataType,
            [NativeTypeName("const BYTE *")] byte* pbInitData,
            [NativeTypeName("DWORD")] uint cb
        );

        [VtblIndex(11)]
        HRESULT get_Expiration(double* dblExpiration);

        [VtblIndex(12)]
        HRESULT Remove();

        [VtblIndex(13)]
        HRESULT Shutdown();
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

        [NativeTypeName("HRESULT (USHORT *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetError;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_KeySystem;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_SessionId;

        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;

        [NativeTypeName("HRESULT (MFMediaKeyStatus **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFMediaKeyStatus**, uint*, int> get_KeyStatuses;

        [NativeTypeName("HRESULT (BSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> Load;

        [NativeTypeName("HRESULT (BSTR, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, uint, int> GenerateRequest;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Expiration;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaKeySession2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaKeySession2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaKeySession"/> to <see cref = "IMFMediaKeySession2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaKeySession"/> instance to be converted </param>
    public static explicit operator IMFMediaKeySession2(Silk.NET.Windows.IMFMediaKeySession value)
    {
        return new IMFMediaKeySession2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeySession2"/> to <see cref = "Silk.NET.Windows.IMFMediaKeySession"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeySession2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaKeySession(IMFMediaKeySession2 value)
    {
        return new Silk.NET.Windows.IMFMediaKeySession(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaKeySession2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaKeySession2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaKeySession2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeySession2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeySession2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaKeySession2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
