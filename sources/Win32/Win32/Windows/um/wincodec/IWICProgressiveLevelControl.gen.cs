// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
[NativeTypeName("struct IWICProgressiveLevelControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICProgressiveLevelControl
    : IWICProgressiveLevelControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICProgressiveLevelControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWICProgressiveLevelControl, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLevelCount(uint* pcLevels)
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcLevels
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentLevel(uint* pnLevel)
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl, uint*, int>)((*lpVtbl)[4]))(
            this,
            pnLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetCurrentLevel(uint nLevel)
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl, uint, int>)((*lpVtbl)[5]))(
            this,
            nLevel
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetLevelCount(uint* pcLevels);

        [VtblIndex(4)]
        HRESULT GetCurrentLevel(uint* pnLevel);

        [VtblIndex(5)]
        HRESULT SetCurrentLevel(uint nLevel);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetLevelCount;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentLevel;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentLevel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICProgressiveLevelControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICProgressiveLevelControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICProgressiveLevelControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICProgressiveLevelControl(Silk.NET.Windows.IUnknown value)
    {
        return new IWICProgressiveLevelControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICProgressiveLevelControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICProgressiveLevelControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICProgressiveLevelControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
