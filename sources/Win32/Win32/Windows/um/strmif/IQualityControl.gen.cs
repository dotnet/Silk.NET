// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868A5-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IQualityControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQualityControl : IQualityControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQualityControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQualityControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IQualityControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQualityControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Notify(IBaseFilter pSelf, Quality q)
    {
        return ((delegate* unmanaged<IQualityControl, IBaseFilter, Quality, int>)((*lpVtbl)[3]))(
            this,
            pSelf,
            q
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSink(IQualityControl piqc)
    {
        return ((delegate* unmanaged<IQualityControl, IQualityControl, int>)((*lpVtbl)[4]))(
            this,
            piqc
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Notify(IBaseFilter pSelf, Quality q);

        [VtblIndex(4)]
        HRESULT SetSink(IQualityControl piqc);
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

        [NativeTypeName("HRESULT (IBaseFilter *, Quality) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, Quality, int> Notify;

        [NativeTypeName("HRESULT (IQualityControl *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IQualityControl, int> SetSink;
    }

    /// <summary>Initializes a new instance of the <see cref = "IQualityControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IQualityControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IQualityControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IQualityControl(Silk.NET.Windows.IUnknown value)
    {
        return new IQualityControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQualityControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IQualityControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IQualityControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
