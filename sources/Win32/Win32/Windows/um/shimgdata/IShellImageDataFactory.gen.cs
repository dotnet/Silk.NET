// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9BE8ED5C-EDAB-4D75-90F3-BD5BDBB21C82")]
[NativeTypeName("struct IShellImageDataFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellImageDataFactory : IShellImageDataFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellImageDataFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellImageDataFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellImageDataFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellImageDataFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateIShellImageData(IShellImageData* ppshimg)
    {
        return ((delegate* unmanaged<IShellImageDataFactory, IShellImageData*, int>)((*lpVtbl)[3]))(
            this,
            ppshimg
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateImageFromFile(
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        IShellImageData* ppshimg
    )
    {
        return (
            (delegate* unmanaged<IShellImageDataFactory, ushort*, IShellImageData*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pszPath, ppshimg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateImageFromStream(IStream pStream, IShellImageData* ppshimg)
    {
        return (
            (delegate* unmanaged<IShellImageDataFactory, IStream, IShellImageData*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pStream, ppshimg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDataFormatFromPath(
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        Guid* pDataFormat
    )
    {
        return ((delegate* unmanaged<IShellImageDataFactory, ushort*, Guid*, int>)((*lpVtbl)[6]))(
            this,
            pszPath,
            pDataFormat
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateIShellImageData(IShellImageData* ppshimg);

        [VtblIndex(4)]
        HRESULT CreateImageFromFile(
            [NativeTypeName("LPCWSTR")] ushort* pszPath,
            IShellImageData* ppshimg
        );

        [VtblIndex(5)]
        HRESULT CreateImageFromStream(IStream pStream, IShellImageData* ppshimg);

        [VtblIndex(6)]
        HRESULT GetDataFormatFromPath(
            [NativeTypeName("LPCWSTR")] ushort* pszPath,
            Guid* pDataFormat
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

        [NativeTypeName("HRESULT (IShellImageData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellImageData*, int> CreateIShellImageData;

        [NativeTypeName("HRESULT (LPCWSTR, IShellImageData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IShellImageData*, int> CreateImageFromFile;

        [NativeTypeName("HRESULT (IStream *, IShellImageData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, IShellImageData*, int> CreateImageFromStream;

        [NativeTypeName("HRESULT (LPCWSTR, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, int> GetDataFormatFromPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellImageDataFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellImageDataFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellImageDataFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellImageDataFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IShellImageDataFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellImageDataFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellImageDataFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellImageDataFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
