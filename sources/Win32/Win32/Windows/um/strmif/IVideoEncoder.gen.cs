// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("02997C3B-8E1B-460E-9270-545E0DE9563E")]
[NativeTypeName("struct IVideoEncoder : IEncoderAPI")]
[NativeInheritance("IEncoderAPI")]
public unsafe partial struct IVideoEncoder : IVideoEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoEncoder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoEncoder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVideoEncoder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoEncoder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsSupported([NativeTypeName("const GUID *")] Guid* Api)
    {
        return ((delegate* unmanaged<IVideoEncoder, Guid*, int>)((*lpVtbl)[3]))(this, Api);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsAvailable([NativeTypeName("const GUID *")] Guid* Api)
    {
        return ((delegate* unmanaged<IVideoEncoder, Guid*, int>)((*lpVtbl)[4]))(this, Api);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetParameterRange(
        [NativeTypeName("const GUID *")] Guid* Api,
        VARIANT* ValueMin,
        VARIANT* ValueMax,
        VARIANT* SteppingDelta
    )
    {
        return (
            (delegate* unmanaged<IVideoEncoder, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(
                (*lpVtbl)[5]
            )
        )(this, Api, ValueMin, ValueMax, SteppingDelta);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParameterValues(
        [NativeTypeName("const GUID *")] Guid* Api,
        VARIANT** Values,
        [NativeTypeName("ULONG *")] uint* ValuesCount
    )
    {
        return ((delegate* unmanaged<IVideoEncoder, Guid*, VARIANT**, uint*, int>)((*lpVtbl)[6]))(
            this,
            Api,
            Values,
            ValuesCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
    {
        return ((delegate* unmanaged<IVideoEncoder, Guid*, VARIANT*, int>)((*lpVtbl)[7]))(
            this,
            Api,
            Value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
    {
        return ((delegate* unmanaged<IVideoEncoder, Guid*, VARIANT*, int>)((*lpVtbl)[8]))(
            this,
            Api,
            Value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
    {
        return ((delegate* unmanaged<IVideoEncoder, Guid*, VARIANT*, int>)((*lpVtbl)[9]))(
            this,
            Api,
            Value
        );
    }

    public interface Interface : IEncoderAPI.Interface { }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> IsSupported;

        [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> IsAvailable;

        [NativeTypeName(
            "HRESULT (const GUID *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            VARIANT*,
            VARIANT*,
            VARIANT*,
            int> GetParameterRange;

        [NativeTypeName("HRESULT (const GUID *, VARIANT **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT**, uint*, int> GetParameterValues;

        [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> GetDefaultValue;

        [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> GetValue;

        [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> SetValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoEncoder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoEncoder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IEncoderAPI"/> to <see cref = "IVideoEncoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IEncoderAPI"/> instance to be converted </param>
    public static explicit operator IVideoEncoder(Silk.NET.Windows.IEncoderAPI value)
    {
        return new IVideoEncoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoEncoder"/> to <see cref = "Silk.NET.Windows.IEncoderAPI"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoEncoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IEncoderAPI(IVideoEncoder value)
    {
        return new Silk.NET.Windows.IEncoderAPI(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoEncoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoEncoder(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoEncoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoEncoder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoEncoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoEncoder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
