// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_shader")]
    public abstract unsafe partial class ExtVertexShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_shader";
        [NativeApi(EntryPoint = "glBeginVertexShaderEXT")]
        public abstract void BeginVertexShader();

        [NativeApi(EntryPoint = "glBindLightParameterEXT")]
        public abstract uint BindLightParameter([Flow(FlowDirection.In)] EXT light, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT")]
        public abstract uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindParameterEXT")]
        public abstract uint BindParameter([Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public abstract uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT")]
        public abstract uint BindTextureUnitParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindVertexShaderEXT")]
        public abstract void BindVertexShader([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteVertexShaderEXT")]
        public abstract void DeleteVertexShader([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDisableVariantClientStateEXT")]
        public abstract void DisableVariantClientState([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEnableVariantClientStateEXT")]
        public abstract void EnableVariantClientState([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEndVertexShaderEXT")]
        public abstract void EndVertexShader();

        [NativeApi(EntryPoint = "glExtractComponentEXT")]
        public abstract void ExtractComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public abstract uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenVertexShadersEXT")]
        public abstract uint GenVertexShaders([Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public abstract unsafe void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public abstract void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public abstract unsafe void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public abstract void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public abstract unsafe void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public abstract void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public abstract unsafe void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public abstract void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public abstract unsafe void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public abstract void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public abstract unsafe void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public abstract void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public abstract unsafe void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public abstract void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public abstract unsafe void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public abstract void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public abstract unsafe void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public abstract void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public abstract unsafe void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public abstract unsafe void GetVariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out T0* data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glInsertComponentEXT")]
        public abstract void InsertComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num);

        [NativeApi(EntryPoint = "glIsVariantEnabledEXT")]
        public abstract bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT cap);

        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public abstract unsafe void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public abstract void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public abstract unsafe void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public abstract void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderOp1EXT")]
        public abstract void ShaderOp1([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1);

        [NativeApi(EntryPoint = "glShaderOp2EXT")]
        public abstract void ShaderOp2([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2);

        [NativeApi(EntryPoint = "glShaderOp3EXT")]
        public abstract void ShaderOp3([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public abstract void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glVariantbvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] sbyte* addr);

        [NativeApi(EntryPoint = "glVariantbvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref sbyte addr);

        [NativeApi(EntryPoint = "glVariantsvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] short* addr);

        [NativeApi(EntryPoint = "glVariantsvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref short addr);

        [NativeApi(EntryPoint = "glVariantivEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] int* addr);

        [NativeApi(EntryPoint = "glVariantivEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref int addr);

        [NativeApi(EntryPoint = "glVariantfvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] float* addr);

        [NativeApi(EntryPoint = "glVariantfvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref float addr);

        [NativeApi(EntryPoint = "glVariantdvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] double* addr);

        [NativeApi(EntryPoint = "glVariantdvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref double addr);

        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] byte* addr);

        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref byte addr);

        [NativeApi(EntryPoint = "glVariantusvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ushort* addr);

        [NativeApi(EntryPoint = "glVariantusvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref ushort addr);

        [NativeApi(EntryPoint = "glVariantuivEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] uint* addr);

        [NativeApi(EntryPoint = "glVariantuivEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref uint addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public abstract unsafe void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public abstract void VariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public abstract void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glBindLightParameterEXT")]
        public abstract uint BindLightParameter([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT")]
        public abstract uint BindMaterialParameter([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter value);

        [NativeApi(EntryPoint = "glBindParameterEXT")]
        public abstract uint BindParameter([Flow(FlowDirection.In)] VertexShaderParameterEXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public abstract uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT")]
        public abstract uint BindTextureUnitParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] VertexShaderTextureUnitParameter value);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public abstract uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public abstract unsafe void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public abstract void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public abstract unsafe void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public abstract void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public abstract unsafe void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public abstract void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public abstract unsafe void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public abstract void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public abstract unsafe void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public abstract void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public abstract unsafe void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public abstract void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public abstract unsafe void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public abstract void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public abstract unsafe void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public abstract void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public abstract unsafe void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public abstract void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public abstract unsafe void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public abstract unsafe void GetVariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out T0* data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIsVariantEnabledEXT")]
        public abstract bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VariantCapEXT cap);

        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public abstract unsafe void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public abstract void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public abstract unsafe void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public abstract void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderOp1EXT")]
        public abstract void ShaderOp1([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1);

        [NativeApi(EntryPoint = "glShaderOp2EXT")]
        public abstract void ShaderOp2([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2);

        [NativeApi(EntryPoint = "glShaderOp3EXT")]
        public abstract void ShaderOp3([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public abstract void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] string addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public abstract unsafe void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public abstract void VariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public abstract void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        public ExtVertexShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

