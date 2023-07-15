// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IQueryInfo.xml' path='doc/member[@name="IQueryInfo"]/*'/>
[Guid("00021500-0000-0000-C000-000000000046")]
[NativeTypeName("struct IQueryInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQueryInfo : IQueryInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQueryInfo*, Guid*, void**, int> )(lpVtbl[0]))((IQueryInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IQueryInfo*, uint> )(lpVtbl[1]))((IQueryInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQueryInfo*, uint> )(lpVtbl[2]))((IQueryInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IQueryInfo.xml' path='doc/member[@name="IQueryInfo.GetInfoTip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInfoTip([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PWSTR *")] ushort** ppwszTip)
    {
        return ((delegate* unmanaged<IQueryInfo*, uint, ushort**, int> )(lpVtbl[3]))((IQueryInfo*)Unsafe.AsPointer(ref this), dwFlags, ppwszTip);
    }

    /// <include file='IQueryInfo.xml' path='doc/member[@name="IQueryInfo.GetInfoFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetInfoFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IQueryInfo*, uint*, int> )(lpVtbl[4]))((IQueryInfo*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetInfoTip([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PWSTR *")] ushort** ppwszTip);
        [VtblIndex(4)]
        HRESULT GetInfoFlags([NativeTypeName("DWORD *")] uint* pdwFlags);
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
        [NativeTypeName("HRESULT (DWORD, PWSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetInfoTip;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetInfoFlags;
    }
}