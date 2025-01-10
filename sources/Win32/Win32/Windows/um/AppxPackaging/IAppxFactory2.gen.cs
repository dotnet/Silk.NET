// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F1346DF2-C282-4E22-B918-743A929A8D55")]
[NativeTypeName("struct IAppxFactory2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxFactory2 : IAppxFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxFactory2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxFactory2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxFactory2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxFactory2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateContentGroupMapReader(
        IStream inputStream,
        IAppxContentGroupMapReader* contentGroupMapReader
    )
    {
        return (
            (delegate* unmanaged<IAppxFactory2, IStream, IAppxContentGroupMapReader*, int>)(
                (*lpVtbl)[3]
            )
        )(this, inputStream, contentGroupMapReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateSourceContentGroupMapReader(
        IStream inputStream,
        IAppxSourceContentGroupMapReader* reader
    )
    {
        return (
            (delegate* unmanaged<IAppxFactory2, IStream, IAppxSourceContentGroupMapReader*, int>)(
                (*lpVtbl)[4]
            )
        )(this, inputStream, reader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateContentGroupMapWriter(
        IStream stream,
        IAppxContentGroupMapWriter* contentGroupMapWriter
    )
    {
        return (
            (delegate* unmanaged<IAppxFactory2, IStream, IAppxContentGroupMapWriter*, int>)(
                (*lpVtbl)[5]
            )
        )(this, stream, contentGroupMapWriter);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateContentGroupMapReader(
            IStream inputStream,
            IAppxContentGroupMapReader* contentGroupMapReader
        );

        [VtblIndex(4)]
        HRESULT CreateSourceContentGroupMapReader(
            IStream inputStream,
            IAppxSourceContentGroupMapReader* reader
        );

        [VtblIndex(5)]
        HRESULT CreateContentGroupMapWriter(
            IStream stream,
            IAppxContentGroupMapWriter* contentGroupMapWriter
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

        [NativeTypeName(
            "HRESULT (IStream *, IAppxContentGroupMapReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IAppxContentGroupMapReader*,
            int> CreateContentGroupMapReader;

        [NativeTypeName(
            "HRESULT (IStream *, IAppxSourceContentGroupMapReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IAppxSourceContentGroupMapReader*,
            int> CreateSourceContentGroupMapReader;

        [NativeTypeName(
            "HRESULT (IStream *, IAppxContentGroupMapWriter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IAppxContentGroupMapWriter*,
            int> CreateContentGroupMapWriter;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxFactory2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxFactory2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxFactory2(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxFactory2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxFactory2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxFactory2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxFactory2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
