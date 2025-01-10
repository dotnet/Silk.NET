// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E93DCF6C-4B07-4E1E-8123-AA16ED6EADF5")]
[NativeTypeName("struct IMFMediaTypeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaTypeHandler : IMFMediaTypeHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaTypeHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaTypeHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsMediaTypeSupported(IMFMediaType pMediaType, IMFMediaType* ppMediaType)
    {
        return (
            (delegate* unmanaged<IMFMediaTypeHandler, IMFMediaType, IMFMediaType*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pMediaType, ppMediaType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwTypeCount)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwTypeCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMediaTypeByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFMediaType* ppType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler, uint, IMFMediaType*, int>)((*lpVtbl)[5]))(
            this,
            dwIndex,
            ppType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCurrentMediaType(IMFMediaType pMediaType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler, IMFMediaType, int>)((*lpVtbl)[6]))(
            this,
            pMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentMediaType(IMFMediaType* ppMediaType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler, IMFMediaType*, int>)((*lpVtbl)[7]))(
            this,
            ppMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMajorType(Guid* pguidMajorType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler, Guid*, int>)((*lpVtbl)[8]))(
            this,
            pguidMajorType
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsMediaTypeSupported(IMFMediaType pMediaType, IMFMediaType* ppMediaType);

        [VtblIndex(4)]
        HRESULT GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwTypeCount);

        [VtblIndex(5)]
        HRESULT GetMediaTypeByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFMediaType* ppType);

        [VtblIndex(6)]
        HRESULT SetCurrentMediaType(IMFMediaType pMediaType);

        [VtblIndex(7)]
        HRESULT GetCurrentMediaType(IMFMediaType* ppMediaType);

        [VtblIndex(8)]
        HRESULT GetMajorType(Guid* pguidMajorType);
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

        [NativeTypeName("HRESULT (IMFMediaType *, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaType, IMFMediaType*, int> IsMediaTypeSupported;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMediaTypeCount;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, int> GetMediaTypeByIndex;

        [NativeTypeName("HRESULT (IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaType, int> SetCurrentMediaType;

        [NativeTypeName("HRESULT (IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaType*, int> GetCurrentMediaType;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetMajorType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaTypeHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaTypeHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaTypeHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaTypeHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaTypeHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaTypeHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaTypeHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaTypeHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
