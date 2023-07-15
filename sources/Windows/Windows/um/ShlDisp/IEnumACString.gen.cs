// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumACString.xml' path='doc/member[@name="IEnumACString"]/*'/>
[Guid("8E74C210-CF9D-4EAF-A403-7356428F0A5A")]
[NativeTypeName("struct IEnumACString : IEnumString")]
[NativeInheritance("IEnumString")]
public unsafe partial struct IEnumACString : IEnumACString.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumACString));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumACString*, Guid*, void**, int> )(lpVtbl[0]))((IEnumACString*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumACString*, uint> )(lpVtbl[1]))((IEnumACString*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumACString*, uint> )(lpVtbl[2]))((IEnumACString*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IEnumString.Next"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLESTR *")] ushort** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumACString*, uint, ushort**, uint*, int> )(lpVtbl[3]))((IEnumACString*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <inheritdoc cref = "IEnumString.Skip"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumACString*, uint, int> )(lpVtbl[4]))((IEnumACString*)Unsafe.AsPointer(ref this), celt);
    }

    /// <inheritdoc cref = "IEnumString.Reset"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumACString*, int> )(lpVtbl[5]))((IEnumACString*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IEnumString.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumString** ppenum)
    {
        return ((delegate* unmanaged<IEnumACString*, IEnumString**, int> )(lpVtbl[6]))((IEnumACString*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IEnumACString.xml' path='doc/member[@name="IEnumACString.NextItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT NextItem([NativeTypeName("LPWSTR")] ushort* pszUrl, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pulSortIndex)
    {
        return ((delegate* unmanaged<IEnumACString*, ushort*, uint, uint*, int> )(lpVtbl[7]))((IEnumACString*)Unsafe.AsPointer(ref this), pszUrl, cchMax, pulSortIndex);
    }

    /// <include file='IEnumACString.xml' path='doc/member[@name="IEnumACString.SetEnumOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetEnumOptions([NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IEnumACString*, uint, int> )(lpVtbl[8]))((IEnumACString*)Unsafe.AsPointer(ref this), dwOptions);
    }

    /// <include file='IEnumACString.xml' path='doc/member[@name="IEnumACString.GetEnumOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetEnumOptions([NativeTypeName("DWORD *")] uint* pdwOptions)
    {
        return ((delegate* unmanaged<IEnumACString*, uint*, int> )(lpVtbl[9]))((IEnumACString*)Unsafe.AsPointer(ref this), pdwOptions);
    }

    public interface Interface : IEnumString.Interface
    {
        [VtblIndex(7)]
        HRESULT NextItem([NativeTypeName("LPWSTR")] ushort* pszUrl, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pulSortIndex);
        [VtblIndex(8)]
        HRESULT SetEnumOptions([NativeTypeName("DWORD")] uint dwOptions);
        [VtblIndex(9)]
        HRESULT GetEnumOptions([NativeTypeName("DWORD *")] uint* pdwOptions);
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
        [NativeTypeName("HRESULT (ULONG, LPOLESTR *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumString**, int> Clone;
        [NativeTypeName("HRESULT (LPWSTR, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> NextItem;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetEnumOptions;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetEnumOptions;
    }
}