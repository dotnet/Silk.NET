// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9F3A1C85-8555-49BA-935F-BE5B5B29D178")]
[NativeTypeName("struct IVMRImagePresenterConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRImagePresenterConfig
    : IVMRImagePresenterConfig.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRImagePresenterConfig));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRImagePresenterConfig, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVMRImagePresenterConfig, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRImagePresenterConfig, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
    {
        return ((delegate* unmanaged<IVMRImagePresenterConfig, uint, int>)((*lpVtbl)[3]))(
            this,
            dwRenderFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRenderingPrefs([NativeTypeName("DWORD *")] uint* dwRenderFlags)
    {
        return ((delegate* unmanaged<IVMRImagePresenterConfig, uint*, int>)((*lpVtbl)[4]))(
            this,
            dwRenderFlags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags);

        [VtblIndex(4)]
        HRESULT GetRenderingPrefs([NativeTypeName("DWORD *")] uint* dwRenderFlags);
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetRenderingPrefs;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetRenderingPrefs;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVMRImagePresenterConfig"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVMRImagePresenterConfig(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVMRImagePresenterConfig"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVMRImagePresenterConfig(Silk.NET.Windows.IUnknown value)
    {
        return new IVMRImagePresenterConfig(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRImagePresenterConfig"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRImagePresenterConfig"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVMRImagePresenterConfig value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
