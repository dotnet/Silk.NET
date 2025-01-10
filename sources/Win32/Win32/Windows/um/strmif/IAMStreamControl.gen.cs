// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("36B73881-C2C8-11CF-8B46-00805F6CEF60")]
[NativeTypeName("struct IAMStreamControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMStreamControl : IAMStreamControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMStreamControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMStreamControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMStreamControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMStreamControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartAt(
        [NativeTypeName("const REFERENCE_TIME *")] long* ptStart,
        [NativeTypeName("DWORD")] uint dwCookie
    )
    {
        return ((delegate* unmanaged<IAMStreamControl, long*, uint, int>)((*lpVtbl)[3]))(
            this,
            ptStart,
            dwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT StopAt(
        [NativeTypeName("const REFERENCE_TIME *")] long* ptStop,
        BOOL bSendExtra,
        [NativeTypeName("DWORD")] uint dwCookie
    )
    {
        return ((delegate* unmanaged<IAMStreamControl, long*, BOOL, uint, int>)((*lpVtbl)[4]))(
            this,
            ptStop,
            bSendExtra,
            dwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetInfo(AM_STREAM_INFO* pInfo)
    {
        return ((delegate* unmanaged<IAMStreamControl, AM_STREAM_INFO*, int>)((*lpVtbl)[5]))(
            this,
            pInfo
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT StartAt(
            [NativeTypeName("const REFERENCE_TIME *")] long* ptStart,
            [NativeTypeName("DWORD")] uint dwCookie
        );

        [VtblIndex(4)]
        HRESULT StopAt(
            [NativeTypeName("const REFERENCE_TIME *")] long* ptStop,
            BOOL bSendExtra,
            [NativeTypeName("DWORD")] uint dwCookie
        );

        [VtblIndex(5)]
        HRESULT GetInfo(AM_STREAM_INFO* pInfo);
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

        [NativeTypeName("HRESULT (const REFERENCE_TIME *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, uint, int> StartAt;

        [NativeTypeName("HRESULT (const REFERENCE_TIME *, BOOL, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, BOOL, uint, int> StopAt;

        [NativeTypeName("HRESULT (AM_STREAM_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_STREAM_INFO*, int> GetInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMStreamControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMStreamControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMStreamControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMStreamControl(Silk.NET.Windows.IUnknown value)
    {
        return new IAMStreamControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMStreamControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMStreamControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMStreamControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
