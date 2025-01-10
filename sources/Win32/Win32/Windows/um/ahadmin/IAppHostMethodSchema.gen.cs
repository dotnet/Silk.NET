// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2D9915FB-9D42-4328-B782-1B46819FAB9E")]
[NativeTypeName("struct IAppHostMethodSchema : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMethodSchema : IAppHostMethodSchema.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostMethodSchema));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostMethodSchema, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostMethodSchema, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostMethodSchema, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IAppHostMethodSchema, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_InputSchema(IAppHostElementSchema* ppInputSchema)
    {
        return (
            (delegate* unmanaged<IAppHostMethodSchema, IAppHostElementSchema*, int>)((*lpVtbl)[4])
        )(this, ppInputSchema);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_OutputSchema(IAppHostElementSchema* ppOutputSchema)
    {
        return (
            (delegate* unmanaged<IAppHostMethodSchema, IAppHostElementSchema*, int>)((*lpVtbl)[5])
        )(this, ppOutputSchema);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IAppHostMethodSchema, ushort*, VARIANT*, int>)((*lpVtbl)[6]))(
            this,
            bstrMetadataType,
            pValue
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(4)]
        HRESULT get_InputSchema(IAppHostElementSchema* ppInputSchema);

        [VtblIndex(5)]
        HRESULT get_OutputSchema(IAppHostElementSchema* ppOutputSchema);

        [VtblIndex(6)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElementSchema*, int> get_InputSchema;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElementSchema*, int> get_OutputSchema;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostMethodSchema"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostMethodSchema(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostMethodSchema"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostMethodSchema(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostMethodSchema(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostMethodSchema"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostMethodSchema"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostMethodSchema value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
