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
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glBeginVertexShaderEXT")]
        public abstract void BeginVertexShader();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindLightParameterEXT")]
        public abstract uint BindLightParameter([Flow(FlowDirection.In)] EXT light, [Flow(FlowDirection.In)] EXT value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindMaterialParameterEXT")]
        public abstract uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindParameterEXT")]
        public abstract uint BindParameter([Flow(FlowDirection.In)] EXT value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public abstract uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT")]
        public abstract uint BindTextureUnitParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindVertexShaderEXT")]
        public abstract void BindVertexShader([Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteVertexShaderEXT")]
        public abstract void DeleteVertexShader([Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableVariantClientStateEXT")]
        public abstract void DisableVariantClientState([Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableVariantClientStateEXT")]
        public abstract void EnableVariantClientState([Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndVertexShaderEXT")]
        public abstract void EndVertexShader();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="src">
        /// To be added.
        /// </param>
        /// <param name="num">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtractComponentEXT")]
        public abstract void ExtractComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="datatype">
        /// To be added.
        /// </param>
        /// <param name="storagetype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// </param>
        /// <param name="components">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public abstract uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="range">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGenVertexShadersEXT")]
        public abstract uint GenVertexShaders([Flow(FlowDirection.In)] uint range);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public abstract unsafe void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public abstract void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public abstract unsafe void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public abstract void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public abstract unsafe void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public abstract void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public abstract unsafe void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public abstract void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public abstract unsafe void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public abstract void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public abstract unsafe void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public abstract void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public abstract unsafe void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public abstract void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public abstract unsafe void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public abstract void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public abstract unsafe void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public abstract void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public abstract unsafe void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public abstract unsafe void GetVariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out T0* data) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="src">
        /// To be added.
        /// </param>
        /// <param name="num">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInsertComponentEXT")]
        public abstract void InsertComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="cap">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsVariantEnabledEXT")]
        public abstract bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT cap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id and type.
        /// </param>
        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public abstract unsafe void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id and type.
        /// </param>
        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public abstract void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id and type.
        /// </param>
        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public abstract unsafe void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id and type.
        /// </param>
        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public abstract void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderOp1EXT")]
        public abstract void ShaderOp1([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderOp2EXT")]
        public abstract void ShaderOp2([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderOp3EXT")]
        public abstract void ShaderOp3([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="@in">
        /// To be added.
        /// </param>
        /// <param name="outX">
        /// To be added.
        /// </param>
        /// <param name="outY">
        /// To be added.
        /// </param>
        /// <param name="outZ">
        /// To be added.
        /// </param>
        /// <param name="outW">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public abstract void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantbvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] sbyte* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantbvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref sbyte addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantsvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] short* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantsvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref short addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantivEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] int* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantivEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref int addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantfvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] float* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantfvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref float addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantdvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] double* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantdvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref double addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] byte* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref byte addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantusvEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ushort* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantusvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref ushort addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantuivEXT")]
        public abstract unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] uint* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glVariantuivEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref uint addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public abstract unsafe void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public abstract void VariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="@in">
        /// To be added.
        /// </param>
        /// <param name="outX">
        /// To be added.
        /// </param>
        /// <param name="outY">
        /// To be added.
        /// </param>
        /// <param name="outZ">
        /// To be added.
        /// </param>
        /// <param name="outW">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public abstract void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindLightParameterEXT")]
        public abstract uint BindLightParameter([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindMaterialParameterEXT")]
        public abstract uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] MaterialParameter value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindParameterEXT")]
        public abstract uint BindParameter([Flow(FlowDirection.In)] VertexShaderParameterEXT value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindTexGenParameterEXT")]
        public abstract uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT")]
        public abstract uint BindTextureUnitParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] VertexShaderTextureUnitParameter value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="datatype">
        /// To be added.
        /// </param>
        /// <param name="storagetype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// </param>
        /// <param name="components">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGenSymbolsEXT")]
        public abstract uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public abstract unsafe void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT")]
        public abstract void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public abstract unsafe void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT")]
        public abstract void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public abstract unsafe void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT")]
        public abstract void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public abstract unsafe void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT")]
        public abstract void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public abstract unsafe void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT")]
        public abstract void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public abstract unsafe void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT")]
        public abstract void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public abstract unsafe void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT")]
        public abstract void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public abstract unsafe void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantFloatvEXT")]
        public abstract void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public abstract unsafe void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantIntegervEXT")]
        public abstract void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public abstract unsafe void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from id.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantPointervEXT")]
        public abstract unsafe void GetVariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out T0* data) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="cap">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsVariantEnabledEXT")]
        public abstract bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VariantCapEXT cap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id and type.
        /// </param>
        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public abstract unsafe void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id and type.
        /// </param>
        [NativeApi(EntryPoint = "glSetInvariantEXT")]
        public abstract void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id and type.
        /// </param>
        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public abstract unsafe void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id and type.
        /// </param>
        [NativeApi(EntryPoint = "glSetLocalConstantEXT")]
        public abstract void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderOp1EXT")]
        public abstract void ShaderOp1([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderOp2EXT")]
        public abstract void ShaderOp2([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderOp3EXT")]
        public abstract void ShaderOp3([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="@in">
        /// To be added.
        /// </param>
        /// <param name="outX">
        /// To be added.
        /// </param>
        /// <param name="outY">
        /// To be added.
        /// </param>
        /// <param name="outZ">
        /// To be added.
        /// </param>
        /// <param name="outW">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSwizzleEXT")]
        public abstract void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVariantubvEXT")]
        public abstract void Variant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] string addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public abstract unsafe void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="addr">
        /// To be added.
        /// This parameter's element count is computed from id, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVariantPointerEXT")]
        public abstract void VariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="res">
        /// To be added.
        /// </param>
        /// <param name="@in">
        /// To be added.
        /// </param>
        /// <param name="outX">
        /// To be added.
        /// </param>
        /// <param name="outY">
        /// To be added.
        /// </param>
        /// <param name="outZ">
        /// To be added.
        /// </param>
        /// <param name="outW">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWriteMaskEXT")]
        public abstract void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW);

        public ExtVertexShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

