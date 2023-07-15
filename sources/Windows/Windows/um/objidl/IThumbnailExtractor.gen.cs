// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IThumbnailExtractor.xml' path='doc/member[@name="IThumbnailExtractor"]/*'/>
[Guid("969DC708-5C76-11D1-8D86-0000F804B057")]
[NativeTypeName("struct IThumbnailExtractor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IThumbnailExtractor : IThumbnailExtractor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IThumbnailExtractor));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailExtractor*, Guid*, void**, int> )(lpVtbl[0]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IThumbnailExtractor*, uint> )(lpVtbl[1]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailExtractor*, uint> )(lpVtbl[2]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IThumbnailExtractor.xml' path='doc/member[@name="IThumbnailExtractor.ExtractThumbnail"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ExtractThumbnail(IStorage* pStg, [NativeTypeName("ULONG")] uint ulLength, [NativeTypeName("ULONG")] uint ulHeight, [NativeTypeName("ULONG *")] uint* pulOutputLength, [NativeTypeName("ULONG *")] uint* pulOutputHeight, HBITMAP* phOutputBitmap)
    {
        return ((delegate* unmanaged<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, HBITMAP*, int> )(lpVtbl[3]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this), pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
    }

    /// <include file='IThumbnailExtractor.xml' path='doc/member[@name="IThumbnailExtractor.OnFileUpdated"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnFileUpdated(IStorage* pStg)
    {
        return ((delegate* unmanaged<IThumbnailExtractor*, IStorage*, int> )(lpVtbl[4]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this), pStg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ExtractThumbnail(IStorage* pStg, [NativeTypeName("ULONG")] uint ulLength, [NativeTypeName("ULONG")] uint ulHeight, [NativeTypeName("ULONG *")] uint* pulOutputLength, [NativeTypeName("ULONG *")] uint* pulOutputHeight, HBITMAP* phOutputBitmap);
        [VtblIndex(4)]
        HRESULT OnFileUpdated(IStorage* pStg);
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
        [NativeTypeName("HRESULT (IStorage *, ULONG, ULONG, ULONG *, ULONG *, HBITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorage*, uint, uint, uint*, uint*, HBITMAP*, int> ExtractThumbnail;
        [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorage*, int> OnFileUpdated;
    }
}