// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305107F9-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ICanvasPixelArrayData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICanvasPixelArrayData : ICanvasPixelArrayData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICanvasPixelArrayData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICanvasPixelArrayData, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICanvasPixelArrayData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICanvasPixelArrayData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBufferPointer(
        byte** ppBuffer,
        [NativeTypeName("ULONG *")] uint* pBufferLength
    )
    {
        return ((delegate* unmanaged<ICanvasPixelArrayData, byte**, uint*, int>)((*lpVtbl)[3]))(
            this,
            ppBuffer,
            pBufferLength
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBufferPointer(byte** ppBuffer, [NativeTypeName("ULONG *")] uint* pBufferLength);
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

        [NativeTypeName("HRESULT (BYTE **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetBufferPointer;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICanvasPixelArrayData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICanvasPixelArrayData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICanvasPixelArrayData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICanvasPixelArrayData(Silk.NET.Windows.IUnknown value)
    {
        return new ICanvasPixelArrayData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICanvasPixelArrayData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICanvasPixelArrayData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICanvasPixelArrayData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
