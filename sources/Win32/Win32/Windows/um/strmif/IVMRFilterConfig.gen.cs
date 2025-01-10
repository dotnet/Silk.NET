// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9E5530C5-7034-48B4-BB46-0B8A6EFC8E36")]
[NativeTypeName("struct IVMRFilterConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRFilterConfig : IVMRFilterConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRFilterConfig));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRFilterConfig, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVMRFilterConfig, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRFilterConfig, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetImageCompositor(IVMRImageCompositor lpVMRImgCompositor)
    {
        return ((delegate* unmanaged<IVMRFilterConfig, IVMRImageCompositor, int>)((*lpVtbl)[3]))(
            this,
            lpVMRImgCompositor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNumberOfStreams([NativeTypeName("DWORD")] uint dwMaxStreams)
    {
        return ((delegate* unmanaged<IVMRFilterConfig, uint, int>)((*lpVtbl)[4]))(
            this,
            dwMaxStreams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwMaxStreams)
    {
        return ((delegate* unmanaged<IVMRFilterConfig, uint*, int>)((*lpVtbl)[5]))(
            this,
            pdwMaxStreams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
    {
        return ((delegate* unmanaged<IVMRFilterConfig, uint, int>)((*lpVtbl)[6]))(
            this,
            dwRenderFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetRenderingPrefs([NativeTypeName("DWORD *")] uint* pdwRenderFlags)
    {
        return ((delegate* unmanaged<IVMRFilterConfig, uint*, int>)((*lpVtbl)[7]))(
            this,
            pdwRenderFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRenderingMode([NativeTypeName("DWORD")] uint Mode)
    {
        return ((delegate* unmanaged<IVMRFilterConfig, uint, int>)((*lpVtbl)[8]))(this, Mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetRenderingMode([NativeTypeName("DWORD *")] uint* pMode)
    {
        return ((delegate* unmanaged<IVMRFilterConfig, uint*, int>)((*lpVtbl)[9]))(this, pMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetImageCompositor(IVMRImageCompositor lpVMRImgCompositor);

        [VtblIndex(4)]
        HRESULT SetNumberOfStreams([NativeTypeName("DWORD")] uint dwMaxStreams);

        [VtblIndex(5)]
        HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwMaxStreams);

        [VtblIndex(6)]
        HRESULT SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags);

        [VtblIndex(7)]
        HRESULT GetRenderingPrefs([NativeTypeName("DWORD *")] uint* pdwRenderFlags);

        [VtblIndex(8)]
        HRESULT SetRenderingMode([NativeTypeName("DWORD")] uint Mode);

        [VtblIndex(9)]
        HRESULT GetRenderingMode([NativeTypeName("DWORD *")] uint* pMode);
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

        [NativeTypeName("HRESULT (IVMRImageCompositor *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IVMRImageCompositor, int> SetImageCompositor;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetNumberOfStreams;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNumberOfStreams;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetRenderingPrefs;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetRenderingPrefs;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetRenderingMode;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetRenderingMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVMRFilterConfig"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVMRFilterConfig(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVMRFilterConfig"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVMRFilterConfig(Silk.NET.Windows.IUnknown value)
    {
        return new IVMRFilterConfig(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRFilterConfig"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRFilterConfig"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVMRFilterConfig value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
