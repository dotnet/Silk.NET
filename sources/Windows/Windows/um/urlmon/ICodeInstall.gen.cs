// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ICodeInstall.xml' path='doc/member[@name="ICodeInstall"]/*'/>
[Guid("79EAC9D1-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct ICodeInstall : IWindowForBindingUI")]
[NativeInheritance("IWindowForBindingUI")]
public unsafe partial struct ICodeInstall : ICodeInstall.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICodeInstall));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICodeInstall*, Guid*, void**, int> )(lpVtbl[0]))((ICodeInstall*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICodeInstall*, uint> )(lpVtbl[1]))((ICodeInstall*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICodeInstall*, uint> )(lpVtbl[2]))((ICodeInstall*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWindowForBindingUI.GetWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd)
    {
        return ((delegate* unmanaged<ICodeInstall*, Guid*, HWND*, int> )(lpVtbl[3]))((ICodeInstall*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
    }

    /// <include file='ICodeInstall.xml' path='doc/member[@name="ICodeInstall.OnCodeInstallProblem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnCodeInstallProblem([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szDestination, [NativeTypeName("LPCWSTR")] ushort* szSource, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ICodeInstall*, uint, ushort*, ushort*, uint, int> )(lpVtbl[4]))((ICodeInstall*)Unsafe.AsPointer(ref this), ulStatusCode, szDestination, szSource, dwReserved);
    }

    public interface Interface : IWindowForBindingUI.Interface
    {
        [VtblIndex(4)]
        HRESULT OnCodeInstallProblem([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szDestination, [NativeTypeName("LPCWSTR")] ushort* szSource, [NativeTypeName("DWORD")] uint dwReserved);
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
}