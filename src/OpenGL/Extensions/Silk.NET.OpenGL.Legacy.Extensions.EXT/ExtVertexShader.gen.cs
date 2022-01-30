// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_shader")]
    public unsafe partial class ExtVertexShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_shader";
        [NativeApi(EntryPoint = "glBeginVertexShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void BeginVertexShader();

        [NativeApi(EntryPoint = "glBindLightParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindLightParameter([Flow(FlowDirection.In)] EXT light, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindLightParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindLightParameter([Flow(FlowDirection.In)] EXT light, [Flow(FlowDirection.In)] LightParameter value);

        [NativeApi(EntryPoint = "glBindLightParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindLightParameter([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindLightParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindLightParameter([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] MaterialParameter value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindMaterialParameter([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindMaterialParameter([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter value);

        [NativeApi(EntryPoint = "glBindParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindParameter([Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindParameter([Flow(FlowDirection.In)] VertexShaderParameterEXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTextureUnitParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTextureUnitParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] VertexShaderTextureUnitParameter value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTextureUnitParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTextureUnitParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] VertexShaderTextureUnitParameter value);

        [NativeApi(EntryPoint = "glBindVertexShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void BindVertexShader([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteVertexShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteVertexShader([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDisableVariantClientStateEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableVariantClientState([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEnableVariantClientStateEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableVariantClientState([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEndVertexShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void EndVertexShader();

        [NativeApi(EntryPoint = "glExtractComponentEXT", Convention = CallingConvention.Winapi)]
        public partial void ExtractComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenVertexShadersEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenVertexShaders([Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT", Convention = CallingConvention.Winapi)]
        public partial void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT", Convention = CallingConvention.Winapi)]
        public partial void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out void* data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out void* data);

        [NativeApi(EntryPoint = "glInsertComponentEXT", Convention = CallingConvention.Winapi)]
        public partial void InsertComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num);

        [NativeApi(EntryPoint = "glIsVariantEnabledEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT cap);

        [NativeApi(EntryPoint = "glIsVariantEnabledEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VariantCapEXT cap);

        [NativeApi(EntryPoint = "glSetInvariantEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetInvariantEXT", Convention = CallingConvention.Winapi)]
        public partial void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSetInvariantEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetInvariantEXT", Convention = CallingConvention.Winapi)]
        public partial void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSetLocalConstantEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetLocalConstantEXT", Convention = CallingConvention.Winapi)]
        public partial void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSetLocalConstantEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetLocalConstantEXT", Convention = CallingConvention.Winapi)]
        public partial void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] in T0 addr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderOp1EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp1([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1);

        [NativeApi(EntryPoint = "glShaderOp1EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp1([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1);

        [NativeApi(EntryPoint = "glShaderOp2EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp2([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2);

        [NativeApi(EntryPoint = "glShaderOp2EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp2([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2);

        [NativeApi(EntryPoint = "glShaderOp3EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp3([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3);

        [NativeApi(EntryPoint = "glShaderOp3EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp3([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        [NativeApi(EntryPoint = "glVariantbvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] sbyte* addr);

        [NativeApi(EntryPoint = "glVariantbvEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in sbyte addr);

        [NativeApi(EntryPoint = "glVariantsvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] short* addr);

        [NativeApi(EntryPoint = "glVariantsvEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in short addr);

        [NativeApi(EntryPoint = "glVariantivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] int* addr);

        [NativeApi(EntryPoint = "glVariantivEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in int addr);

        [NativeApi(EntryPoint = "glVariantfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] float* addr);

        [NativeApi(EntryPoint = "glVariantfvEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in float addr);

        [NativeApi(EntryPoint = "glVariantdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] double* addr);

        [NativeApi(EntryPoint = "glVariantdvEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in double addr);

        [NativeApi(EntryPoint = "glVariantubvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] byte* addr);

        [NativeApi(EntryPoint = "glVariantubvEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in byte addr);

        [NativeApi(EntryPoint = "glVariantubvEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string addr);

        [NativeApi(EntryPoint = "glVariantusvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ushort* addr);

        [NativeApi(EntryPoint = "glVariantusvEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in ushort addr);

        [NativeApi(EntryPoint = "glVariantuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] uint* addr);

        [NativeApi(EntryPoint = "glVariantuivEXT", Convention = CallingConvention.Winapi)]
        public partial void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] in uint addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        public ExtVertexShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

