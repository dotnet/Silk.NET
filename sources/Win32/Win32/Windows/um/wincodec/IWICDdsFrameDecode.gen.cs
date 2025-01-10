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

[Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
[NativeTypeName("struct IWICDdsFrameDecode : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IWICDdsFrameDecode : IWICDdsFrameDecode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsFrameDecode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICDdsFrameDecode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSizeInBlocks(uint* pWidthInBlocks, uint* pHeightInBlocks)
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode, uint*, uint*, int>)((*lpVtbl)[3]))(
            this,
            pWidthInBlocks,
            pHeightInBlocks
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFormatInfo(WICDdsFormatInfo* pFormatInfo)
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode, WICDdsFormatInfo*, int>)((*lpVtbl)[4]))(
            this,
            pFormatInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CopyBlocks(
        [NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks,
        uint cbStride,
        uint cbBufferSize,
        byte* pbBuffer
    )
    {
        return (
            (delegate* unmanaged<IWICDdsFrameDecode, WICRect*, uint, uint, byte*, int>)(
                (*lpVtbl)[5]
            )
        )(this, prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSizeInBlocks(uint* pWidthInBlocks, uint* pHeightInBlocks);

        [VtblIndex(4)]
        HRESULT GetFormatInfo(WICDdsFormatInfo* pFormatInfo);

        [VtblIndex(5)]
        HRESULT CopyBlocks(
            [NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks,
            uint cbStride,
            uint cbBufferSize,
            byte* pbBuffer
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

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetSizeInBlocks;

        [NativeTypeName("HRESULT (WICDdsFormatInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICDdsFormatInfo*, int> GetFormatInfo;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRect*, uint, uint, byte*, int> CopyBlocks;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICDdsFrameDecode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICDdsFrameDecode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICDdsFrameDecode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICDdsFrameDecode(Silk.NET.Windows.IUnknown value)
    {
        return new IWICDdsFrameDecode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICDdsFrameDecode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICDdsFrameDecode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICDdsFrameDecode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
