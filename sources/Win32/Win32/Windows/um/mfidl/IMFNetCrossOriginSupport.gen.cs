// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BC2B7D44-A72D-49D5-8376-1480DEE58B22")]
[NativeTypeName("struct IMFNetCrossOriginSupport : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFNetCrossOriginSupport
    : IMFNetCrossOriginSupport.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetCrossOriginSupport));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetCrossOriginSupport, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFNetCrossOriginSupport, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetCrossOriginSupport, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCrossOriginPolicy(MF_CROSS_ORIGIN_POLICY* pPolicy)
    {
        return (
            (delegate* unmanaged<IMFNetCrossOriginSupport, MF_CROSS_ORIGIN_POLICY*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pPolicy);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSourceOrigin([NativeTypeName("LPWSTR *")] ushort** wszSourceOrigin)
    {
        return ((delegate* unmanaged<IMFNetCrossOriginSupport, ushort**, int>)((*lpVtbl)[4]))(
            this,
            wszSourceOrigin
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsSameOrigin([NativeTypeName("LPCWSTR")] ushort* wszURL, BOOL* pfIsSameOrigin)
    {
        return ((delegate* unmanaged<IMFNetCrossOriginSupport, ushort*, BOOL*, int>)((*lpVtbl)[5]))(
            this,
            wszURL,
            pfIsSameOrigin
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCrossOriginPolicy(MF_CROSS_ORIGIN_POLICY* pPolicy);

        [VtblIndex(4)]
        HRESULT GetSourceOrigin([NativeTypeName("LPWSTR *")] ushort** wszSourceOrigin);

        [VtblIndex(5)]
        HRESULT IsSameOrigin([NativeTypeName("LPCWSTR")] ushort* wszURL, BOOL* pfIsSameOrigin);
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

        [NativeTypeName("HRESULT (MF_CROSS_ORIGIN_POLICY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_CROSS_ORIGIN_POLICY*, int> GetCrossOriginPolicy;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSourceOrigin;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> IsSameOrigin;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFNetCrossOriginSupport"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFNetCrossOriginSupport(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFNetCrossOriginSupport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFNetCrossOriginSupport(Silk.NET.Windows.IUnknown value)
    {
        return new IMFNetCrossOriginSupport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFNetCrossOriginSupport"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFNetCrossOriginSupport"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFNetCrossOriginSupport value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
