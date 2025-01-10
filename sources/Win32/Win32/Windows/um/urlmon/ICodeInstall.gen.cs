// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9D1-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct ICodeInstall : IWindowForBindingUI")]
[NativeInheritance("IWindowForBindingUI")]
public unsafe partial struct ICodeInstall : ICodeInstall.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICodeInstall));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICodeInstall, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICodeInstall, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICodeInstall, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd)
    {
        return ((delegate* unmanaged<ICodeInstall, Guid*, HWND*, int>)((*lpVtbl)[3]))(
            this,
            rguidReason,
            phwnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnCodeInstallProblem(
        [NativeTypeName("ULONG")] uint ulStatusCode,
        [NativeTypeName("LPCWSTR")] ushort* szDestination,
        [NativeTypeName("LPCWSTR")] ushort* szSource,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<ICodeInstall, uint, ushort*, ushort*, uint, int>)((*lpVtbl)[4])
        )(this, ulStatusCode, szDestination, szSource, dwReserved);
    }

    public interface Interface : IWindowForBindingUI.Interface
    {
        [VtblIndex(4)]
        HRESULT OnCodeInstallProblem(
            [NativeTypeName("ULONG")] uint ulStatusCode,
            [NativeTypeName("LPCWSTR")] ushort* szDestination,
            [NativeTypeName("LPCWSTR")] ushort* szSource,
            [NativeTypeName("DWORD")] uint dwReserved
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

        [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (ULONG, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, uint, int> OnCodeInstallProblem;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICodeInstall"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICodeInstall(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWindowForBindingUI"/> to <see cref = "ICodeInstall"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWindowForBindingUI"/> instance to be converted </param>
    public static explicit operator ICodeInstall(Silk.NET.Windows.IWindowForBindingUI value)
    {
        return new ICodeInstall(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICodeInstall"/> to <see cref = "Silk.NET.Windows.IWindowForBindingUI"/>.</summary>
    /// <param name = "value">The <see cref = "ICodeInstall"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWindowForBindingUI(ICodeInstall value)
    {
        return new Silk.NET.Windows.IWindowForBindingUI(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICodeInstall"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICodeInstall(Silk.NET.Windows.IUnknown value)
    {
        return new ICodeInstall(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICodeInstall"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICodeInstall"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICodeInstall value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
