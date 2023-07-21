// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IOleContainer.xml' path='doc/member[@name="IOleContainer"]/*' />
[Guid("0000011B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleContainer : IParseDisplayName")]
[NativeInheritance("IParseDisplayName")]
public unsafe partial struct IOleContainer : IOleContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleContainer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleContainer*, Guid*, void**, int>)(lpVtbl[0]))((IOleContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleContainer*, uint>)(lpVtbl[1]))((IOleContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleContainer*, uint>)(lpVtbl[2]))((IOleContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IParseDisplayName.ParseDisplayName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ParseDisplayName(IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, IMoniker** ppmkOut)
    {
        return ((delegate* unmanaged<IOleContainer*, IBindCtx*, ushort*, uint*, IMoniker**, int>)(lpVtbl[3]))((IOleContainer*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
    }

    /// <include file='IOleContainer.xml' path='doc/member[@name="IOleContainer.EnumObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects([NativeTypeName("DWORD")] uint grfFlags, IEnumUnknown** ppenum)
    {
        return ((delegate* unmanaged<IOleContainer*, uint, IEnumUnknown**, int>)(lpVtbl[4]))((IOleContainer*)Unsafe.AsPointer(ref this), grfFlags, ppenum);
    }

    /// <include file='IOleContainer.xml' path='doc/member[@name="IOleContainer.LockContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LockContainer(BOOL fLock)
    {
        return ((delegate* unmanaged<IOleContainer*, BOOL, int>)(lpVtbl[5]))((IOleContainer*)Unsafe.AsPointer(ref this), fLock);
    }

    public interface Interface : IParseDisplayName.Interface
    {
        [VtblIndex(4)]
        HRESULT EnumObjects([NativeTypeName("DWORD")] uint grfFlags, IEnumUnknown** ppenum);

        [VtblIndex(5)]
        HRESULT LockContainer(BOOL fLock);
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

        [NativeTypeName("HRESULT (IBindCtx *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, ushort*, uint*, IMoniker**, int> ParseDisplayName;

        [NativeTypeName("HRESULT (DWORD, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumUnknown**, int> EnumObjects;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> LockContainer;
    }
}
