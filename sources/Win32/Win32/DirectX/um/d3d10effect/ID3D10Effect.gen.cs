// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("51B0CA8B-EC0B-4519-870D-8EE1CB5017C7")]
[NativeTypeName("struct ID3D10Effect : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10Effect : ID3D10Effect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Effect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10Effect, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D10Effect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10Effect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL IsValid()
    {
        return ((delegate* unmanaged<ID3D10Effect, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL IsPool()
    {
        return ((delegate* unmanaged<ID3D10Effect, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDevice(ID3D10Device* ppDevice)
    {
        return ((delegate* unmanaged<ID3D10Effect, ID3D10Device*, int>)((*lpVtbl)[5]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDesc(D3D10_EFFECT_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10Effect, D3D10_EFFECT_DESC*, int>)((*lpVtbl)[6]))(
            this,
            pDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public ID3D10EffectConstantBuffer* GetConstantBufferByIndex(uint Index)
    {
        return (
            (delegate* unmanaged<ID3D10Effect, uint, ID3D10EffectConstantBuffer*>)((*lpVtbl)[7])
        )(this, Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public ID3D10EffectConstantBuffer* GetConstantBufferByName(
        [NativeTypeName("LPCSTR")] sbyte* Name
    )
    {
        return (
            (delegate* unmanaged<ID3D10Effect, sbyte*, ID3D10EffectConstantBuffer*>)((*lpVtbl)[8])
        )(this, Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public ID3D10EffectVariable* GetVariableByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10Effect, uint, ID3D10EffectVariable*>)((*lpVtbl)[9]))(
            this,
            Index
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public ID3D10EffectVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10Effect, sbyte*, ID3D10EffectVariable*>)((*lpVtbl)[10]))(
            this,
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public ID3D10EffectVariable* GetVariableBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic)
    {
        return ((delegate* unmanaged<ID3D10Effect, sbyte*, ID3D10EffectVariable*>)((*lpVtbl)[11]))(
            this,
            Semantic
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public ID3D10EffectTechnique* GetTechniqueByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10Effect, uint, ID3D10EffectTechnique*>)((*lpVtbl)[12]))(
            this,
            Index
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public ID3D10EffectTechnique* GetTechniqueByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10Effect, sbyte*, ID3D10EffectTechnique*>)((*lpVtbl)[13]))(
            this,
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Optimize()
    {
        return ((delegate* unmanaged<ID3D10Effect, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL IsOptimized()
    {
        return ((delegate* unmanaged<ID3D10Effect, int>)((*lpVtbl)[15]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL IsValid();

        [VtblIndex(4)]
        BOOL IsPool();

        [VtblIndex(5)]
        HRESULT GetDevice(ID3D10Device* ppDevice);

        [VtblIndex(6)]
        HRESULT GetDesc(D3D10_EFFECT_DESC* pDesc);

        [VtblIndex(7)]
        ID3D10EffectConstantBuffer* GetConstantBufferByIndex(uint Index);

        [VtblIndex(8)]
        ID3D10EffectConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(9)]
        ID3D10EffectVariable* GetVariableByIndex(uint Index);

        [VtblIndex(10)]
        ID3D10EffectVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(11)]
        ID3D10EffectVariable* GetVariableBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic);

        [VtblIndex(12)]
        ID3D10EffectTechnique* GetTechniqueByIndex(uint Index);

        [VtblIndex(13)]
        ID3D10EffectTechnique* GetTechniqueByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(14)]
        HRESULT Optimize();

        [VtblIndex(15)]
        BOOL IsOptimized();
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

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsValid;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsPool;

        [NativeTypeName(
            "HRESULT (ID3D10Device **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID3D10Device*, int> GetDevice;

        [NativeTypeName(
            "HRESULT (D3D10_EFFECT_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D10_EFFECT_DESC*, int> GetDesc;

        [NativeTypeName(
            "ID3D10EffectConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID3D10EffectConstantBuffer*> GetConstantBufferByIndex;

        [NativeTypeName(
            "ID3D10EffectConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            ID3D10EffectConstantBuffer*> GetConstantBufferByName;

        [NativeTypeName(
            "ID3D10EffectVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectVariable*> GetVariableByIndex;

        [NativeTypeName(
            "ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetVariableByName;

        [NativeTypeName(
            "ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetVariableBySemantic;

        [NativeTypeName(
            "ID3D10EffectTechnique *(UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectTechnique*> GetTechniqueByIndex;

        [NativeTypeName(
            "ID3D10EffectTechnique *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectTechnique*> GetTechniqueByName;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Optimize;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsOptimized;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D10Effect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D10Effect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D10Effect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D10Effect(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D10Effect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D10Effect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D10Effect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D10Effect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
