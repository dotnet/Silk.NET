// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9D7-BAFA-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IHttpSecurity : IWindowForBindingUI")]
[NativeInheritance("IWindowForBindingUI")]
public unsafe partial struct IHttpSecurity : IHttpSecurity.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpSecurity));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpSecurity, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpSecurity, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpSecurity, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd)
    {
        return ((delegate* unmanaged<IHttpSecurity, Guid*, HWND*, int>)((*lpVtbl)[3]))(
            this,
            rguidReason,
            phwnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnSecurityProblem([NativeTypeName("DWORD")] uint dwProblem)
    {
        return ((delegate* unmanaged<IHttpSecurity, uint, int>)((*lpVtbl)[4]))(this, dwProblem);
    }

    public interface Interface : IWindowForBindingUI.Interface
    {
        [VtblIndex(4)]
        HRESULT OnSecurityProblem([NativeTypeName("DWORD")] uint dwProblem);
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

        [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnSecurityProblem;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpSecurity"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpSecurity(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWindowForBindingUI"/> to <see cref = "IHttpSecurity"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWindowForBindingUI"/> instance to be converted </param>
    public static explicit operator IHttpSecurity(Silk.NET.Windows.IWindowForBindingUI value)
    {
        return new IHttpSecurity(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpSecurity"/> to <see cref = "Silk.NET.Windows.IWindowForBindingUI"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpSecurity"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWindowForBindingUI(IHttpSecurity value)
    {
        return new Silk.NET.Windows.IWindowForBindingUI(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpSecurity"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpSecurity(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpSecurity(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpSecurity"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpSecurity"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpSecurity value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
