// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C3457783-A846-47CE-9520-CEA6F66E7447")]
[NativeTypeName("struct ID3D10ShaderReflection1 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10ShaderReflection1
    : ID3D10ShaderReflection1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10ShaderReflection1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D10ShaderReflection1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDesc(D3D10_SHADER_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<ID3D10ShaderReflection1, D3D10_SHADER_DESC*, int>)((*lpVtbl)[3])
        )(this, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index)
    {
        return (
            (delegate* unmanaged<
                ID3D10ShaderReflection1,
                uint,
                ID3D10ShaderReflectionConstantBuffer*>)((*lpVtbl)[4])
        )(this, Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByName(
        [NativeTypeName("LPCSTR")] sbyte* Name
    )
    {
        return (
            (delegate* unmanaged<
                ID3D10ShaderReflection1,
                sbyte*,
                ID3D10ShaderReflectionConstantBuffer*>)((*lpVtbl)[5])
        )(this, Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D10_SHADER_INPUT_BIND_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<
                ID3D10ShaderReflection1,
                uint,
                D3D10_SHADER_INPUT_BIND_DESC*,
                int>)((*lpVtbl)[6])
        )(this, ResourceIndex, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<
                ID3D10ShaderReflection1,
                uint,
                D3D10_SIGNATURE_PARAMETER_DESC*,
                int>)((*lpVtbl)[7])
        )(this, ParameterIndex, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputParameterDesc(
        uint ParameterIndex,
        D3D10_SIGNATURE_PARAMETER_DESC* pDesc
    )
    {
        return (
            (delegate* unmanaged<
                ID3D10ShaderReflection1,
                uint,
                D3D10_SIGNATURE_PARAMETER_DESC*,
                int>)((*lpVtbl)[8])
        )(this, ParameterIndex, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public ID3D10ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return (
            (delegate* unmanaged<ID3D10ShaderReflection1, sbyte*, ID3D10ShaderReflectionVariable*>)(
                (*lpVtbl)[9]
            )
        )(this, Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetResourceBindingDescByName(
        [NativeTypeName("LPCSTR")] sbyte* Name,
        D3D10_SHADER_INPUT_BIND_DESC* pDesc
    )
    {
        return (
            (delegate* unmanaged<
                ID3D10ShaderReflection1,
                sbyte*,
                D3D10_SHADER_INPUT_BIND_DESC*,
                int>)((*lpVtbl)[10])
        )(this, Name, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMovInstructionCount(uint* pCount)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, uint*, int>)((*lpVtbl)[11]))(
            this,
            pCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMovcInstructionCount(uint* pCount)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, uint*, int>)((*lpVtbl)[12]))(
            this,
            pCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetConversionInstructionCount(uint* pCount)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, uint*, int>)((*lpVtbl)[13]))(
            this,
            pCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetBitwiseInstructionCount(uint* pCount)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, uint*, int>)((*lpVtbl)[14]))(
            this,
            pCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetGSInputPrimitive([NativeTypeName("D3D10_PRIMITIVE *")] D3D_PRIMITIVE* pPrim)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, D3D_PRIMITIVE*, int>)((*lpVtbl)[15]))(
            this,
            pPrim
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsLevel9Shader(BOOL* pbLevel9Shader)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, BOOL*, int>)((*lpVtbl)[16]))(
            this,
            pbLevel9Shader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsSampleFrequencyShader(BOOL* pbSampleFrequency)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection1, BOOL*, int>)((*lpVtbl)[17]))(
            this,
            pbSampleFrequency
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDesc(D3D10_SHADER_DESC* pDesc);

        [VtblIndex(4)]
        ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index);

        [VtblIndex(5)]
        ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByName(
            [NativeTypeName("LPCSTR")] sbyte* Name
        );

        [VtblIndex(6)]
        HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D10_SHADER_INPUT_BIND_DESC* pDesc);

        [VtblIndex(7)]
        HRESULT GetInputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc);

        [VtblIndex(8)]
        HRESULT GetOutputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc);

        [VtblIndex(9)]
        ID3D10ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(10)]
        HRESULT GetResourceBindingDescByName(
            [NativeTypeName("LPCSTR")] sbyte* Name,
            D3D10_SHADER_INPUT_BIND_DESC* pDesc
        );

        [VtblIndex(11)]
        HRESULT GetMovInstructionCount(uint* pCount);

        [VtblIndex(12)]
        HRESULT GetMovcInstructionCount(uint* pCount);

        [VtblIndex(13)]
        HRESULT GetConversionInstructionCount(uint* pCount);

        [VtblIndex(14)]
        HRESULT GetBitwiseInstructionCount(uint* pCount);

        [VtblIndex(15)]
        HRESULT GetGSInputPrimitive([NativeTypeName("D3D10_PRIMITIVE *")] D3D_PRIMITIVE* pPrim);

        [VtblIndex(16)]
        HRESULT IsLevel9Shader(BOOL* pbLevel9Shader);

        [VtblIndex(17)]
        HRESULT IsSampleFrequencyShader(BOOL* pbSampleFrequency);
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
            "HRESULT (D3D10_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D10_SHADER_DESC*, int> GetDesc;

        [NativeTypeName(
            "ID3D10ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID3D10ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;

        [NativeTypeName(
            "ID3D10ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            ID3D10ShaderReflectionConstantBuffer*> GetConstantBufferByName;

        [NativeTypeName(
            "HRESULT (UINT, D3D10_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D10_SHADER_INPUT_BIND_DESC*,
            int> GetResourceBindingDesc;

        [NativeTypeName(
            "HRESULT (UINT, D3D10_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D10_SIGNATURE_PARAMETER_DESC*,
            int> GetInputParameterDesc;

        [NativeTypeName(
            "HRESULT (UINT, D3D10_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D10_SIGNATURE_PARAMETER_DESC*,
            int> GetOutputParameterDesc;

        [NativeTypeName(
            "ID3D10ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            ID3D10ShaderReflectionVariable*> GetVariableByName;

        [NativeTypeName(
            "HRESULT (LPCSTR, D3D10_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            D3D10_SHADER_INPUT_BIND_DESC*,
            int> GetResourceBindingDescByName;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMovInstructionCount;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMovcInstructionCount;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetConversionInstructionCount;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetBitwiseInstructionCount;

        [NativeTypeName(
            "HRESULT (D3D10_PRIMITIVE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D_PRIMITIVE*, int> GetGSInputPrimitive;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsLevel9Shader;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsSampleFrequencyShader;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D10ShaderReflection1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D10ShaderReflection1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D10ShaderReflection1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D10ShaderReflection1(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D10ShaderReflection1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D10ShaderReflection1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D10ShaderReflection1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D10ShaderReflection1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
