// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IFileSystemImageResult2.xml' path='doc/member[@name="IFileSystemImageResult2"]/*'/>
[Guid("B507CA29-2204-11DD-966A-001AA01BBC58")]
[NativeTypeName("struct IFileSystemImageResult2 : IFileSystemImageResult")]
[NativeInheritance("IFileSystemImageResult")]
public unsafe partial struct IFileSystemImageResult2 : IFileSystemImageResult2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSystemImageResult2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, Guid*, void**, int> )(lpVtbl[0]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, uint> )(lpVtbl[1]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, uint> )(lpVtbl[2]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, uint*, int> )(lpVtbl[3]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IFileSystemImageResult.get_ImageStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ImageStream(IStream** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, IStream**, int> )(lpVtbl[7]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImageResult.get_ProgressItems"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProgressItems(IProgressItems** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, IProgressItems**, int> )(lpVtbl[8]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImageResult.get_TotalBlocks"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TotalBlocks([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, int*, int> )(lpVtbl[9]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImageResult.get_BlockSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BlockSize([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, int*, int> )(lpVtbl[10]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImageResult.get_DiscId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DiscId([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, ushort**, int> )(lpVtbl[11]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IFileSystemImageResult2.xml' path='doc/member[@name="IFileSystemImageResult2.get_ModifiedBlocks"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ModifiedBlocks(IBlockRangeList** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImageResult2*, IBlockRangeList**, int> )(lpVtbl[12]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
    }

    public interface Interface : IFileSystemImageResult.Interface
    {
        [VtblIndex(12)]
        HRESULT get_ModifiedBlocks(IBlockRangeList** pVal);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream**, int> get_ImageStream;
        [NativeTypeName("HRESULT (IProgressItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IProgressItems**, int> get_ProgressItems;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TotalBlocks;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BlockSize;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_DiscId;
        [NativeTypeName("HRESULT (IBlockRangeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBlockRangeList**, int> get_ModifiedBlocks;
    }
}