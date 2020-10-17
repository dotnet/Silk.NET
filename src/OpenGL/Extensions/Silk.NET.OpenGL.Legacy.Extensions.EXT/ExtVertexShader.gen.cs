// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_shader")]
    public unsafe partial class ExtVertexShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_shader";
        [NativeApi(EntryPoint = "glBeginVertexShaderEXT")]
        public partial void BeginVertexShader();

        [NativeApi(EntryPoint = "glBindLightParameterEXT")]
        public partial uint BindLightParameter([Flow(FlowDirection.In)] EXT light, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindLightParameterEXT")]
        public partial uint BindLightParameter([Flow(FlowDirection.In)] EXT light, [Flow(FlowDirection.In)] LightParameter value);

        [NativeApi(EntryPoint = "glBindLightParameterEXT")]
        public partial uint BindLightParameter([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindLightParameterEXT")]
        public partial uint BindLightParameter([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT")]
        public partial uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT")]
        public partial uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] MaterialParameter value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT")]
        public partial uint BindMaterialParameter([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT")]
        public partial uint BindMaterialParameter([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter value);

        [NativeApi(EntryPoint = "glBindParameterEXT")]
        public partial uint BindParameter([Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindParameterEXT")]
        public partial uint BindParameter([Flow(FlowDirection.In)] VertexShaderParameterEXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT")]
        public partial uint BindTextureUnitParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT")]
        public partial uint BindTextureUnitParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] VertexShaderTextureUnitParameter value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT")]
        public partial uint BindTextureUnitParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT")]
        public partial uint BindTextureUnitParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] VertexShaderTextureUnitParameter value);

        [NativeApi(EntryPoint = "glBindVertexShaderEXT")]
        public partial void BindVertexShader([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteVertexShaderEXT")]
        public partial void DeleteVertexShader([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDisableVariantClientStateEXT")]
        public partial void DisableVariantClientState([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEnableVariantClientStateEXT")]
        public partial void EnableVariantClientState([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEndVertexShaderEXT")]
        public partial void EndVertexShader();

        [NativeApi(EntryPoint = "glExtractComponentEXT")]
        public partial void ExtractComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public partial uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public partial uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public partial uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public partial uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public partial uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public partial uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public partial uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public partial uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenVertexShadersEXT")]
        public partial uint GenVertexShaders([Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public unsafe partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public unsafe partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public unsafe partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public unsafe partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public unsafe partial void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public partial void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public unsafe partial void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public partial void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public unsafe partial void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public partial void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public unsafe partial void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public partial void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public unsafe partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public unsafe partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public unsafe partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public unsafe partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public unsafe partial void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public partial void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public unsafe partial void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public partial void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public unsafe partial void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public partial void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public unsafe partial void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public partial void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public unsafe partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public unsafe partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public unsafe partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public unsafe partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public unsafe partial void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public partial void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public unsafe partial void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public partial void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public unsafe partial void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public partial void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public unsafe partial void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public partial void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public unsafe partial void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public unsafe partial void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out void* data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public unsafe partial void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public unsafe partial void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out void* data);

        [NativeApi(EntryPoint = "glInsertComponentEXT")]
        public partial void InsertComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num);

        [NativeApi(EntryPoint = "glIsVariantEnabledEXT")]
        public partial bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT cap);

        [NativeApi(EntryPoint = "glIsVariantEnabledEXT")]
        public partial bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VariantCapEXT cap);

        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public unsafe partial void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public partial void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public unsafe partial void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public partial void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public unsafe partial void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public partial void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public unsafe partial void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public partial void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderOp1EXT")]
        public partial void ShaderOp1([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1);

        [NativeApi(EntryPoint = "glShaderOp1EXT")]
        public partial void ShaderOp1([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1);

        [NativeApi(EntryPoint = "glShaderOp2EXT")]
        public partial void ShaderOp2([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2);

        [NativeApi(EntryPoint = "glShaderOp2EXT")]
        public partial void ShaderOp2([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2);

        [NativeApi(EntryPoint = "glShaderOp3EXT")]
        public partial void ShaderOp3([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3);

        [NativeApi(EntryPoint = "glShaderOp3EXT")]
        public partial void ShaderOp3([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glVariantbvEXT")]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] sbyte* addr);

        [NativeApi(EntryPoint = "glVariantbvEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in sbyte addr);

        [NativeApi(EntryPoint = "glVariantsvEXT")]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] short* addr);

        [NativeApi(EntryPoint = "glVariantsvEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in short addr);

        [NativeApi(EntryPoint = "glVariantivEXT")]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] int* addr);

        [NativeApi(EntryPoint = "glVariantivEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in int addr);

        [NativeApi(EntryPoint = "glVariantfvEXT")]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] float* addr);

        [NativeApi(EntryPoint = "glVariantfvEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in float addr);

        [NativeApi(EntryPoint = "glVariantdvEXT")]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] double* addr);

        [NativeApi(EntryPoint = "glVariantdvEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in double addr);

        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] byte* addr);

        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in byte addr);

        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] string addr);

        [NativeApi(EntryPoint = "glVariantusvEXT")]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ushort* addr);

        [NativeApi(EntryPoint = "glVariantusvEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in ushort addr);

        [NativeApi(EntryPoint = "glVariantuivEXT")]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] uint* addr);

        [NativeApi(EntryPoint = "glVariantuivEXT")]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in uint addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public unsafe partial void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public partial void VariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public unsafe partial void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public partial void VariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        public ExtVertexShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

