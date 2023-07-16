// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10StateBlockMaskUnion"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10StateBlockMaskUnion(D3D10_STATE_BLOCK_MASK* pA, D3D10_STATE_BLOCK_MASK* pB, D3D10_STATE_BLOCK_MASK* pResult);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10StateBlockMaskIntersect"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10StateBlockMaskIntersect(D3D10_STATE_BLOCK_MASK* pA, D3D10_STATE_BLOCK_MASK* pB, D3D10_STATE_BLOCK_MASK* pResult);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10StateBlockMaskDifference"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10StateBlockMaskDifference(D3D10_STATE_BLOCK_MASK* pA, D3D10_STATE_BLOCK_MASK* pB, D3D10_STATE_BLOCK_MASK* pResult);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10StateBlockMaskEnableCapture"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10StateBlockMaskEnableCapture(D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10StateBlockMaskDisableCapture"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10StateBlockMaskDisableCapture(D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10StateBlockMaskEnableAll"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10StateBlockMaskEnableAll(D3D10_STATE_BLOCK_MASK* pMask);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10StateBlockMaskDisableAll"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10StateBlockMaskDisableAll(D3D10_STATE_BLOCK_MASK* pMask);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10StateBlockMaskGetSetting"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern BOOL D3D10StateBlockMaskGetSetting(D3D10_STATE_BLOCK_MASK* pMask, D3D10_DEVICE_STATE_TYPES StateType, uint Entry);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CreateStateBlock"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateStateBlock(ID3D10Device* pDevice, D3D10_STATE_BLOCK_MASK* pStateBlockMask, ID3D10StateBlock** ppStateBlock);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CompileEffectFromMemory"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CompileEffectFromMemory(void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, [NativeTypeName("LPCSTR")] sbyte* pSrcFileName, [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("ID3D10Include *")] ID3DInclude* pInclude, uint HLSLFlags, uint FXFlags, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppCompiledEffect, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppErrors);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CreateEffectFromMemory"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateEffectFromMemory(void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, uint FXFlags, ID3D10Device* pDevice, ID3D10EffectPool* pEffectPool, ID3D10Effect** ppEffect);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CreateEffectPoolFromMemory"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateEffectPoolFromMemory(void* pData, [NativeTypeName("SIZE_T")] nuint DataLength, uint FXFlags, ID3D10Device* pDevice, ID3D10EffectPool** ppEffectPool);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10DisassembleEffect"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10DisassembleEffect(ID3D10Effect* pEffect, BOOL EnableColorCode, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppDisassembly);
}