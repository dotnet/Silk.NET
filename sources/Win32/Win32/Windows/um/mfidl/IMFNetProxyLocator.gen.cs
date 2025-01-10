// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E9CD0383-A268-4BB4-82DE-658D53574D41")]
[NativeTypeName("struct IMFNetProxyLocator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFNetProxyLocator : IMFNetProxyLocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetProxyLocator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetProxyLocator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFNetProxyLocator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetProxyLocator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindFirstProxy(
        [NativeTypeName("LPCWSTR")] ushort* pszHost,
        [NativeTypeName("LPCWSTR")] ushort* pszUrl,
        BOOL fReserved
    )
    {
        return (
            (delegate* unmanaged<IMFNetProxyLocator, ushort*, ushort*, BOOL, int>)((*lpVtbl)[3])
        )(this, pszHost, pszUrl, fReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FindNextProxy()
    {
        return ((delegate* unmanaged<IMFNetProxyLocator, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterProxyResult(HRESULT hrOp)
    {
        return ((delegate* unmanaged<IMFNetProxyLocator, HRESULT, int>)((*lpVtbl)[5]))(this, hrOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentProxy(
        [NativeTypeName("LPWSTR")] ushort* pszStr,
        [NativeTypeName("DWORD *")] uint* pcchStr
    )
    {
        return ((delegate* unmanaged<IMFNetProxyLocator, ushort*, uint*, int>)((*lpVtbl)[6]))(
            this,
            pszStr,
            pcchStr
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Clone(IMFNetProxyLocator* ppProxyLocator)
    {
        return ((delegate* unmanaged<IMFNetProxyLocator, IMFNetProxyLocator*, int>)((*lpVtbl)[7]))(
            this,
            ppProxyLocator
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindFirstProxy(
            [NativeTypeName("LPCWSTR")] ushort* pszHost,
            [NativeTypeName("LPCWSTR")] ushort* pszUrl,
            BOOL fReserved
        );

        [VtblIndex(4)]
        HRESULT FindNextProxy();

        [VtblIndex(5)]
        HRESULT RegisterProxyResult(HRESULT hrOp);

        [VtblIndex(6)]
        HRESULT GetCurrentProxy(
            [NativeTypeName("LPWSTR")] ushort* pszStr,
            [NativeTypeName("DWORD *")] uint* pcchStr
        );

        [VtblIndex(7)]
        HRESULT Clone(IMFNetProxyLocator* ppProxyLocator);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, BOOL, int> FindFirstProxy;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FindNextProxy;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> RegisterProxyResult;

        [NativeTypeName("HRESULT (LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetCurrentProxy;

        [NativeTypeName("HRESULT (IMFNetProxyLocator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFNetProxyLocator*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFNetProxyLocator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFNetProxyLocator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFNetProxyLocator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFNetProxyLocator(Silk.NET.Windows.IUnknown value)
    {
        return new IMFNetProxyLocator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFNetProxyLocator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFNetProxyLocator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFNetProxyLocator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
