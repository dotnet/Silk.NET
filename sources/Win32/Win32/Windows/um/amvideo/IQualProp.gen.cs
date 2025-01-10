// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1BD0ECB0-F8E2-11CE-AAC6-0020AF0B99A3")]
[NativeTypeName("struct IQualProp : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQualProp : IQualProp.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQualProp));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQualProp, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IQualProp, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQualProp, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_FramesDroppedInRenderer(int* pcFrames)
    {
        return ((delegate* unmanaged<IQualProp, int*, int>)((*lpVtbl)[3]))(this, pcFrames);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_FramesDrawn(int* pcFramesDrawn)
    {
        return ((delegate* unmanaged<IQualProp, int*, int>)((*lpVtbl)[4]))(this, pcFramesDrawn);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_AvgFrameRate(int* piAvgFrameRate)
    {
        return ((delegate* unmanaged<IQualProp, int*, int>)((*lpVtbl)[5]))(this, piAvgFrameRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Jitter(int* iJitter)
    {
        return ((delegate* unmanaged<IQualProp, int*, int>)((*lpVtbl)[6]))(this, iJitter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AvgSyncOffset(int* piAvg)
    {
        return ((delegate* unmanaged<IQualProp, int*, int>)((*lpVtbl)[7]))(this, piAvg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DevSyncOffset(int* piDev)
    {
        return ((delegate* unmanaged<IQualProp, int*, int>)((*lpVtbl)[8]))(this, piDev);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_FramesDroppedInRenderer(int* pcFrames);

        [VtblIndex(4)]
        HRESULT get_FramesDrawn(int* pcFramesDrawn);

        [VtblIndex(5)]
        HRESULT get_AvgFrameRate(int* piAvgFrameRate);

        [VtblIndex(6)]
        HRESULT get_Jitter(int* iJitter);

        [VtblIndex(7)]
        HRESULT get_AvgSyncOffset(int* piAvg);

        [VtblIndex(8)]
        HRESULT get_DevSyncOffset(int* piDev);
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

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FramesDroppedInRenderer;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FramesDrawn;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AvgFrameRate;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Jitter;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AvgSyncOffset;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DevSyncOffset;
    }

    /// <summary>Initializes a new instance of the <see cref = "IQualProp"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IQualProp(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IQualProp"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IQualProp(Silk.NET.Windows.IUnknown value)
    {
        return new IQualProp(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQualProp"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IQualProp"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IQualProp value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
