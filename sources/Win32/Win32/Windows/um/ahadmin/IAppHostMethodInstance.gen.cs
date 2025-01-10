// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B80F3C42-60E0-4AE0-9007-F52852D3DBED")]
[NativeTypeName("struct IAppHostMethodInstance : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMethodInstance : IAppHostMethodInstance.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostMethodInstance));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostMethodInstance, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostMethodInstance, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostMethodInstance, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Input(IAppHostElement* ppInputElement)
    {
        return ((delegate* unmanaged<IAppHostMethodInstance, IAppHostElement*, int>)((*lpVtbl)[3]))(
            this,
            ppInputElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Output(IAppHostElement* ppOutputElement)
    {
        return ((delegate* unmanaged<IAppHostMethodInstance, IAppHostElement*, int>)((*lpVtbl)[4]))(
            this,
            ppOutputElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Execute()
    {
        return ((delegate* unmanaged<IAppHostMethodInstance, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return (
            (delegate* unmanaged<IAppHostMethodInstance, ushort*, VARIANT*, int>)((*lpVtbl)[6])
        )(this, bstrMetadataType, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged<IAppHostMethodInstance, ushort*, VARIANT, int>)((*lpVtbl)[7]))(
            this,
            bstrMetadataType,
            value
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Input(IAppHostElement* ppInputElement);

        [VtblIndex(4)]
        HRESULT get_Output(IAppHostElement* ppOutputElement);

        [VtblIndex(5)]
        HRESULT Execute();

        [VtblIndex(6)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(7)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value);
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

        [NativeTypeName("HRESULT (IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElement*, int> get_Input;

        [NativeTypeName("HRESULT (IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElement*, int> get_Output;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Execute;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> SetMetadata;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostMethodInstance"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostMethodInstance(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostMethodInstance"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostMethodInstance(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostMethodInstance(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostMethodInstance"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostMethodInstance"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostMethodInstance value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
