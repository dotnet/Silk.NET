// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1E673275-0257-40AA-AF20-7C608D4A0428")]
[NativeTypeName("struct IVMRMixerBitmap : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRMixerBitmap : IVMRMixerBitmap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRMixerBitmap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRMixerBitmap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVMRMixerBitmap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRMixerBitmap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAlphaBitmap(
        [NativeTypeName("const VMRALPHABITMAP *")] VMRALPHABITMAP* pBmpParms
    )
    {
        return ((delegate* unmanaged<IVMRMixerBitmap, VMRALPHABITMAP*, int>)((*lpVtbl)[3]))(
            this,
            pBmpParms
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateAlphaBitmapParameters(
        [NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms
    )
    {
        return ((delegate* unmanaged<IVMRMixerBitmap, VMRALPHABITMAP*, int>)((*lpVtbl)[4]))(
            this,
            pBmpParms
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAlphaBitmapParameters(
        [NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms
    )
    {
        return ((delegate* unmanaged<IVMRMixerBitmap, VMRALPHABITMAP*, int>)((*lpVtbl)[5]))(
            this,
            pBmpParms
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAlphaBitmap(
            [NativeTypeName("const VMRALPHABITMAP *")] VMRALPHABITMAP* pBmpParms
        );

        [VtblIndex(4)]
        HRESULT UpdateAlphaBitmapParameters(
            [NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms
        );

        [VtblIndex(5)]
        HRESULT GetAlphaBitmapParameters(
            [NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms
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

        [NativeTypeName("HRESULT (const VMRALPHABITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRALPHABITMAP*, int> SetAlphaBitmap;

        [NativeTypeName("HRESULT (PVMRALPHABITMAP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRALPHABITMAP*, int> UpdateAlphaBitmapParameters;

        [NativeTypeName("HRESULT (PVMRALPHABITMAP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRALPHABITMAP*, int> GetAlphaBitmapParameters;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVMRMixerBitmap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVMRMixerBitmap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVMRMixerBitmap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVMRMixerBitmap(Silk.NET.Windows.IUnknown value)
    {
        return new IVMRMixerBitmap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRMixerBitmap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRMixerBitmap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVMRMixerBitmap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
