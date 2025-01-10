// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
[NativeTypeName("struct IWICDdsEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IWICDdsEncoder : IWICDdsEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsEncoder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICDdsEncoder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICDdsEncoder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICDdsEncoder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetParameters(WICDdsParameters* pParameters)
    {
        return ((delegate* unmanaged<IWICDdsEncoder, WICDdsParameters*, int>)((*lpVtbl)[3]))(
            this,
            pParameters
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetParameters(WICDdsParameters* pParameters)
    {
        return ((delegate* unmanaged<IWICDdsEncoder, WICDdsParameters*, int>)((*lpVtbl)[4]))(
            this,
            pParameters
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateNewFrame(
        IWICBitmapFrameEncode* ppIFrameEncode,
        uint* pArrayIndex,
        uint* pMipLevel,
        uint* pSliceIndex
    )
    {
        return (
            (delegate* unmanaged<IWICDdsEncoder, IWICBitmapFrameEncode*, uint*, uint*, uint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetParameters(WICDdsParameters* pParameters);

        [VtblIndex(4)]
        HRESULT GetParameters(WICDdsParameters* pParameters);

        [VtblIndex(5)]
        HRESULT CreateNewFrame(
            IWICBitmapFrameEncode* ppIFrameEncode,
            uint* pArrayIndex,
            uint* pMipLevel,
            uint* pSliceIndex
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

        [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICDdsParameters*, int> SetParameters;

        [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICDdsParameters*, int> GetParameters;

        [NativeTypeName(
            "HRESULT (IWICBitmapFrameEncode **, UINT *, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmapFrameEncode*,
            uint*,
            uint*,
            uint*,
            int> CreateNewFrame;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICDdsEncoder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICDdsEncoder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICDdsEncoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICDdsEncoder(Silk.NET.Windows.IUnknown value)
    {
        return new IWICDdsEncoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICDdsEncoder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICDdsEncoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICDdsEncoder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
