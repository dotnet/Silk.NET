// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DCD285FE-0BE0-43BD-99C9-AAAEC513C555")]
[NativeTypeName("struct IDocWrap : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDocWrap : IDocWrap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDocWrap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDocWrap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDocWrap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDocWrap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown punk)
    {
        return ((delegate* unmanaged<IDocWrap, Guid*, IUnknown, int>)((*lpVtbl)[3]))(
            this,
            riid,
            punk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetWrappedDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown* ppunk)
    {
        return ((delegate* unmanaged<IDocWrap, Guid*, IUnknown*, int>)((*lpVtbl)[4]))(
            this,
            riid,
            ppunk
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown punk);

        [VtblIndex(4)]
        HRESULT GetWrappedDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown* ppunk);
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

        [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetDoc;

        [NativeTypeName("HRESULT (const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> GetWrappedDoc;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDocWrap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDocWrap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDocWrap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDocWrap(Silk.NET.Windows.IUnknown value)
    {
        return new IDocWrap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDocWrap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDocWrap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDocWrap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
