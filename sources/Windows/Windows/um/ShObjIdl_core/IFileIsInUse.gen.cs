// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IFileIsInUse.xml' path='doc/member[@name="IFileIsInUse"]/*'/>
[Guid("64A1CBF0-3A1A-4461-9158-376969693950")]
[NativeTypeName("struct IFileIsInUse : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileIsInUse : IFileIsInUse.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileIsInUse));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileIsInUse*, Guid*, void**, int> )(lpVtbl[0]))((IFileIsInUse*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileIsInUse*, uint> )(lpVtbl[1]))((IFileIsInUse*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileIsInUse*, uint> )(lpVtbl[2]))((IFileIsInUse*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileIsInUse.xml' path='doc/member[@name="IFileIsInUse.GetAppName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IFileIsInUse*, ushort**, int> )(lpVtbl[3]))((IFileIsInUse*)Unsafe.AsPointer(ref this), ppszName);
    }

    /// <include file='IFileIsInUse.xml' path='doc/member[@name="IFileIsInUse.GetUsage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUsage(FILE_USAGE_TYPE* pfut)
    {
        return ((delegate* unmanaged<IFileIsInUse*, FILE_USAGE_TYPE*, int> )(lpVtbl[4]))((IFileIsInUse*)Unsafe.AsPointer(ref this), pfut);
    }

    /// <include file='IFileIsInUse.xml' path='doc/member[@name="IFileIsInUse.GetCapabilities"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapFlags)
    {
        return ((delegate* unmanaged<IFileIsInUse*, uint*, int> )(lpVtbl[5]))((IFileIsInUse*)Unsafe.AsPointer(ref this), pdwCapFlags);
    }

    /// <include file='IFileIsInUse.xml' path='doc/member[@name="IFileIsInUse.GetSwitchToHWND"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSwitchToHWND(HWND* phwnd)
    {
        return ((delegate* unmanaged<IFileIsInUse*, HWND*, int> )(lpVtbl[6]))((IFileIsInUse*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <include file='IFileIsInUse.xml' path='doc/member[@name="IFileIsInUse.CloseFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CloseFile()
    {
        return ((delegate* unmanaged<IFileIsInUse*, int> )(lpVtbl[7]))((IFileIsInUse*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAppName([NativeTypeName("LPWSTR *")] ushort** ppszName);
        [VtblIndex(4)]
        HRESULT GetUsage(FILE_USAGE_TYPE* pfut);
        [VtblIndex(5)]
        HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapFlags);
        [VtblIndex(6)]
        HRESULT GetSwitchToHWND(HWND* phwnd);
        [VtblIndex(7)]
        HRESULT CloseFile();
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAppName;
        [NativeTypeName("HRESULT (FILE_USAGE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILE_USAGE_TYPE*, int> GetUsage;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCapabilities;
        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetSwitchToHWND;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CloseFile;
    }
}