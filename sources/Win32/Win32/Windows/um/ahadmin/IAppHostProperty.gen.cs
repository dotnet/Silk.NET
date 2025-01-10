// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("ED35F7A1-5024-4E7B-A44D-07DDAF4B524D")]
[NativeTypeName("struct IAppHostProperty : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostProperty : IAppHostProperty.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostProperty));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostProperty, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostProperty, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostProperty, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IAppHostProperty, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Value(VARIANT* pVariant)
    {
        return ((delegate* unmanaged<IAppHostProperty, VARIANT*, int>)((*lpVtbl)[4]))(
            this,
            pVariant
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_Value(VARIANT value)
    {
        return ((delegate* unmanaged<IAppHostProperty, VARIANT, int>)((*lpVtbl)[5]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IAppHostProperty, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StringValue([NativeTypeName("BSTR *")] ushort** pbstrValue)
    {
        return ((delegate* unmanaged<IAppHostProperty, ushort**, int>)((*lpVtbl)[7]))(
            this,
            pbstrValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Exception(IAppHostPropertyException* ppException)
    {
        return (
            (delegate* unmanaged<IAppHostProperty, IAppHostPropertyException*, int>)((*lpVtbl)[8])
        )(this, ppException);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IAppHostProperty, ushort*, VARIANT*, int>)((*lpVtbl)[9]))(
            this,
            bstrMetadataType,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged<IAppHostProperty, ushort*, VARIANT, int>)((*lpVtbl)[10]))(
            this,
            bstrMetadataType,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Schema(IAppHostPropertySchema* ppSchema)
    {
        return (
            (delegate* unmanaged<IAppHostProperty, IAppHostPropertySchema*, int>)((*lpVtbl)[11])
        )(this, ppSchema);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Value(VARIANT* pVariant);

        [VtblIndex(5)]
        HRESULT put_Value(VARIANT value);

        [VtblIndex(6)]
        HRESULT Clear();

        [VtblIndex(7)]
        HRESULT get_StringValue([NativeTypeName("BSTR *")] ushort** pbstrValue);

        [VtblIndex(8)]
        HRESULT get_Exception(IAppHostPropertyException* ppException);

        [VtblIndex(9)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(10)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value);

        [VtblIndex(11)]
        HRESULT get_Schema(IAppHostPropertySchema* ppSchema);
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

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_Value;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_Value;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_StringValue;

        [NativeTypeName("HRESULT (IAppHostPropertyException **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostPropertyException*, int> get_Exception;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> SetMetadata;

        [NativeTypeName("HRESULT (IAppHostPropertySchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostPropertySchema*, int> get_Schema;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostProperty"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostProperty(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostProperty"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostProperty(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostProperty(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostProperty"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostProperty"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostProperty value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
