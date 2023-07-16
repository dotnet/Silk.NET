// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IProvideMultipleClassInfo.xml' path='doc/member[@name="IProvideMultipleClassInfo"]/*'/>
[Guid("A7ABA9C1-8983-11CF-8F20-00805F2CD064")]
[NativeTypeName("struct IProvideMultipleClassInfo : IProvideClassInfo2")]
[NativeInheritance("IProvideClassInfo2")]
public unsafe partial struct IProvideMultipleClassInfo : IProvideMultipleClassInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProvideMultipleClassInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo*, Guid*, void**, int> )(lpVtbl[0]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint> )(lpVtbl[1]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint> )(lpVtbl[2]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IProvideClassInfo.GetClassInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassInfo(ITypeInfo** ppTI)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo*, ITypeInfo**, int> )(lpVtbl[3]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), ppTI);
    }

    /// <inheritdoc cref = "IProvideClassInfo2.GetGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, Guid* pGUID)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint, Guid*, int> )(lpVtbl[4]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), dwGuidKind, pGUID);
    }

    /// <include file='IProvideMultipleClassInfo.xml' path='doc/member[@name="IProvideMultipleClassInfo.GetMultiTypeInfoCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint*, int> )(lpVtbl[5]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), pcti);
    }

    /// <include file='IProvideMultipleClassInfo.xml' path='doc/member[@name="IProvideMultipleClassInfo.GetInfoOfIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetInfoOfIndex([NativeTypeName("ULONG")] uint iti, [NativeTypeName("DWORD")] uint dwFlags, ITypeInfo** pptiCoClass, [NativeTypeName("DWORD *")] uint* pdwTIFlags, [NativeTypeName("ULONG *")] uint* pcdispidReserved, [NativeTypeName("IID *")] Guid* piidPrimary, [NativeTypeName("IID *")] Guid* piidSource)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int> )(lpVtbl[6]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
    }

    public interface Interface : IProvideClassInfo2.Interface
    {
        [VtblIndex(5)]
        HRESULT GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti);
        [VtblIndex(6)]
        HRESULT GetInfoOfIndex([NativeTypeName("ULONG")] uint iti, [NativeTypeName("DWORD")] uint dwFlags, ITypeInfo** pptiCoClass, [NativeTypeName("DWORD *")] uint* pdwTIFlags, [NativeTypeName("ULONG *")] uint* pcdispidReserved, [NativeTypeName("IID *")] Guid* piidPrimary, [NativeTypeName("IID *")] Guid* piidSource);
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
        [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeInfo**, int> GetClassInfo;
        [NativeTypeName("HRESULT (DWORD, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> GetGUID;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMultiTypeInfoCount;
        [NativeTypeName("HRESULT (ULONG, DWORD, ITypeInfo **, DWORD *, ULONG *, IID *, IID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int> GetInfoOfIndex;
    }
}