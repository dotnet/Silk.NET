// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("88E220F3-33E8-4534-AFAC-B4A98ECCF9AE")]
[NativeTypeName("struct IAppHostPropertyExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPropertyExtension
    : IAppHostPropertyExtension.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPropertyExtension));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostPropertyExtension, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostPropertyExtension, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostPropertyExtension, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProvideGetProperty(IAppHostElement pElement, IAppHostProperty pProperty)
    {
        return (
            (delegate* unmanaged<
                IAppHostPropertyExtension,
                IAppHostElement,
                IAppHostProperty,
                int>)((*lpVtbl)[3])
        )(this, pElement, pProperty);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ProvideGetProperty(IAppHostElement pElement, IAppHostProperty pProperty);
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

        [NativeTypeName("HRESULT (IAppHostElement *, IAppHostProperty *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAppHostElement,
            IAppHostProperty,
            int> ProvideGetProperty;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostPropertyExtension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostPropertyExtension(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostPropertyExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostPropertyExtension(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostPropertyExtension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostPropertyExtension"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostPropertyExtension"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostPropertyExtension value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
