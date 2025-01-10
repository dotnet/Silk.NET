// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9CB-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IExtensionServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExtensionServices : IExtensionServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExtensionServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExtensionServices, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExtensionServices, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExtensionServices, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAdditionalHeaders([NativeTypeName("LPCWSTR")] ushort* pwzAdditionalHeaders)
    {
        return ((delegate* unmanaged<IExtensionServices, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pwzAdditionalHeaders
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAuthenticateData(
        HWND phwnd,
        [NativeTypeName("LPCWSTR")] ushort* pwzUsername,
        [NativeTypeName("LPCWSTR")] ushort* pwzPassword
    )
    {
        return (
            (delegate* unmanaged<IExtensionServices, HWND, ushort*, ushort*, int>)((*lpVtbl)[4])
        )(this, phwnd, pwzUsername, pwzPassword);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAdditionalHeaders([NativeTypeName("LPCWSTR")] ushort* pwzAdditionalHeaders);

        [VtblIndex(4)]
        HRESULT SetAuthenticateData(
            HWND phwnd,
            [NativeTypeName("LPCWSTR")] ushort* pwzUsername,
            [NativeTypeName("LPCWSTR")] ushort* pwzPassword
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetAdditionalHeaders;

        [NativeTypeName("HRESULT (HWND, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ushort*, ushort*, int> SetAuthenticateData;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExtensionServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExtensionServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExtensionServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExtensionServices(Silk.NET.Windows.IUnknown value)
    {
        return new IExtensionServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExtensionServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExtensionServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExtensionServices value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
