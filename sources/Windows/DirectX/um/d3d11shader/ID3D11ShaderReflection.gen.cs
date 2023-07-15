// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection"]/*'/>
[Guid("8D536CA1-0CCA-4956-A837-786963755584")]
[NativeTypeName("struct ID3D11ShaderReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11ShaderReflection : ID3D11ShaderReflection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderReflection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint> )(lpVtbl[1]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint> )(lpVtbl[2]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDesc(D3D11_SHADER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D11_SHADER_DESC*, int> )(lpVtbl[3]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetConstantBufferByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, ID3D11ShaderReflectionConstantBuffer*> )(lpVtbl[4]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetConstantBufferByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, ID3D11ShaderReflectionConstantBuffer*> )(lpVtbl[5]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetResourceBindingDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int> )(lpVtbl[6]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetInputParameterDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInputParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int> )(lpVtbl[7]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetOutputParameterDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int> )(lpVtbl[8]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetPatchConstantParameterDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPatchConstantParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int> )(lpVtbl[9]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetVariableByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, ID3D11ShaderReflectionVariable*> )(lpVtbl[10]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetResourceBindingDescByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int> )(lpVtbl[11]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetMovInstructionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public uint GetMovInstructionCount()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint> )(lpVtbl[12]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetMovcInstructionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public uint GetMovcInstructionCount()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint> )(lpVtbl[13]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetConversionInstructionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public uint GetConversionInstructionCount()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint> )(lpVtbl[14]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetBitwiseInstructionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetBitwiseInstructionCount()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint> )(lpVtbl[15]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetGSInputPrimitive"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public D3D_PRIMITIVE GetGSInputPrimitive()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D_PRIMITIVE> )(lpVtbl[16]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.IsSampleFrequencyShader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public BOOL IsSampleFrequencyShader()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, int> )(lpVtbl[17]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetNumInterfaceSlots"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public uint GetNumInterfaceSlots()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint> )(lpVtbl[18]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetMinFeatureLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D_FEATURE_LEVEL*, int> )(lpVtbl[19]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetThreadGroupSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint> )(lpVtbl[20]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
    }

    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetRequiresFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("UINT64")]
    public ulong GetRequiresFlags()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflection*, ulong> )(lpVtbl[21]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDesc(D3D11_SHADER_DESC* pDesc);
        [VtblIndex(4)]
        ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index);
        [VtblIndex(5)]
        ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(6)]
        HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D11_SHADER_INPUT_BIND_DESC* pDesc);
        [VtblIndex(7)]
        HRESULT GetInputParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc);
        [VtblIndex(8)]
        HRESULT GetOutputParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc);
        [VtblIndex(9)]
        HRESULT GetPatchConstantParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc);
        [VtblIndex(10)]
        ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(11)]
        HRESULT GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D11_SHADER_INPUT_BIND_DESC* pDesc);
        [VtblIndex(12)]
        uint GetMovInstructionCount();
        [VtblIndex(13)]
        uint GetMovcInstructionCount();
        [VtblIndex(14)]
        uint GetConversionInstructionCount();
        [VtblIndex(15)]
        uint GetBitwiseInstructionCount();
        [VtblIndex(16)]
        D3D_PRIMITIVE GetGSInputPrimitive();
        [VtblIndex(17)]
        BOOL IsSampleFrequencyShader();
        [VtblIndex(18)]
        uint GetNumInterfaceSlots();
        [VtblIndex(19)]
        HRESULT GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel);
        [VtblIndex(20)]
        uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ);
        [VtblIndex(21)]
        [return: NativeTypeName("UINT64")]
        ulong GetRequiresFlags();
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
        [NativeTypeName("HRESULT (D3D11_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_SHADER_DESC*, int> GetDesc;
        [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D11ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;
        [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D11ShaderReflectionConstantBuffer*> GetConstantBufferByName;
        [NativeTypeName("HRESULT (UINT, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDesc;
        [NativeTypeName("HRESULT (UINT, D3D11_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int> GetInputParameterDesc;
        [NativeTypeName("HRESULT (UINT, D3D11_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int> GetOutputParameterDesc;
        [NativeTypeName("HRESULT (UINT, D3D11_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int> GetPatchConstantParameterDesc;
        [NativeTypeName("ID3D11ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D11ShaderReflectionVariable*> GetVariableByName;
        [NativeTypeName("HRESULT (LPCSTR, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDescByName;
        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetMovInstructionCount;
        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetMovcInstructionCount;
        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetConversionInstructionCount;
        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetBitwiseInstructionCount;
        [NativeTypeName("D3D_PRIMITIVE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_PRIMITIVE> GetGSInputPrimitive;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSampleFrequencyShader;
        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNumInterfaceSlots;
        [NativeTypeName("HRESULT (enum D3D_FEATURE_LEVEL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_FEATURE_LEVEL*, int> GetMinFeatureLevel;
        [NativeTypeName("UINT (UINT *, UINT *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, uint> GetThreadGroupSize;
        [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetRequiresFlags;
    }
}