// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_shader")]
    public unsafe partial class ExtVertexShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_shader";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glBeginVertexShaderEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginVertexShader()
            => ImplBeginVertexShader();

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindLightParameter([Flow(FlowDirection.In)] EXT light, [Flow(FlowDirection.In)] EXT value)
            => ImplBindLightParameter(light, value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT value)
            => ImplBindMaterialParameter(face, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindParameterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindParameter([Flow(FlowDirection.In)] EXT value)
            => ImplBindParameter(value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindTexGenParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT value)
            => ImplBindTexGenParameter(unit, coord, value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindTextureUnitParameter([Flow(FlowDirection.In)] EXT unit, [Flow(FlowDirection.In)] EXT value)
            => ImplBindTextureUnitParameter(unit, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindVertexShaderEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindVertexShader([Flow(FlowDirection.In)] uint id)
            => ImplBindVertexShader(id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteVertexShaderEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteVertexShader([Flow(FlowDirection.In)] uint id)
            => ImplDeleteVertexShader(id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableVariantClientStateEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableVariantClientState([Flow(FlowDirection.In)] uint id)
            => ImplDisableVariantClientState(id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableVariantClientStateEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableVariantClientState([Flow(FlowDirection.In)] uint id)
            => ImplEnableVariantClientState(id);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndVertexShaderEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndVertexShader()
            => ImplEndVertexShader();

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ExtractComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num)
            => ImplExtractComponent(res, src, num);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GenSymbol([Flow(FlowDirection.In)] EXT datatype, [Flow(FlowDirection.In)] EXT storagetype, [Flow(FlowDirection.In)] EXT range, [Flow(FlowDirection.In)] uint components)
            => ImplGenSymbol(datatype, storagetype, range, components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="range">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGenVertexShadersEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GenVertexShaders([Flow(FlowDirection.In)] uint range)
            => ImplGenVertexShaders(range);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetInvariantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetInvariantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data)
            => ImplGetInvariantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data)
            => ImplGetInvariantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data)
            => ImplGetInvariantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data)
            => ImplGetInvariantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetLocalConstantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetLocalConstantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data)
            => ImplGetLocalConstantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data)
            => ImplGetLocalConstantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data)
            => ImplGetLocalConstantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data)
            => ImplGetLocalConstantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetVariantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetVariantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data)
            => ImplGetVariantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data)
            => ImplGetVariantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data)
            => ImplGetVariantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data)
            => ImplGetVariantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data)
            => ImplGetVariantPointer(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out T0* data) where T0 : unmanaged
            => ImplGetVariantPointer<T0>(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InsertComponent([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint src, [Flow(FlowDirection.In)] uint num)
            => ImplInsertComponent(res, src, num);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT cap)
            => ImplIsVariantEnabled(id, cap);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr)
            => ImplSetInvariant(id, type, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged
            => ImplSetInvariant<T0>(id, type, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr)
            => ImplSetLocalConstant(id, type, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged
            => ImplSetLocalConstant<T0>(id, type, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderOp1([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1)
            => ImplShaderOp1(op, res, arg1);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderOp2([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2)
            => ImplShaderOp2(op, res, arg1, arg2);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderOp3([Flow(FlowDirection.In)] EXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3)
            => ImplShaderOp3(op, res, arg1, arg2, arg3);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW)
            => ImplSwizzle(res, @in, outX, outY, outZ, outW);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] sbyte* addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref sbyte addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] short* addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref short addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] int* addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref int addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] float* addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref float addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] double* addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref double addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] byte* addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref byte addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ushort* addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref ushort addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] uint* addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(FlowDirection.In)] ref uint addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr)
            => ImplVariantPointer(id, type, stride, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged
            => ImplVariantPointer<T0>(id, type, stride, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] EXT outX, [Flow(FlowDirection.In)] EXT outY, [Flow(FlowDirection.In)] EXT outZ, [Flow(FlowDirection.In)] EXT outW)
            => ImplWriteMask(res, @in, outX, outY, outZ, outW);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindLightParameter([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter value)
            => ImplBindLightParameter(light, value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindMaterialParameter([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] MaterialParameter value)
            => ImplBindMaterialParameter(face, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glBindParameterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindParameter([Flow(FlowDirection.In)] VertexShaderParameterEXT value)
            => ImplBindParameter(value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindTexGenParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter value)
            => ImplBindTexGenParameter(unit, coord, value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint BindTextureUnitParameter([Flow(FlowDirection.In)] TextureUnit unit, [Flow(FlowDirection.In)] VertexShaderTextureUnitParameter value)
            => ImplBindTextureUnitParameter(unit, value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GenSymbol([Flow(FlowDirection.In)] DataTypeEXT datatype, [Flow(FlowDirection.In)] VertexShaderStorageTypeEXT storagetype, [Flow(FlowDirection.In)] ParameterRangeEXT range, [Flow(FlowDirection.In)] uint components)
            => ImplGenSymbol(datatype, storagetype, range, components);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetInvariantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInvariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetInvariantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data)
            => ImplGetInvariantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInvariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data)
            => ImplGetInvariantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data)
            => ImplGetInvariantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInvariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data)
            => ImplGetInvariantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetLocalConstantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetLocalConstantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetLocalConstantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data)
            => ImplGetLocalConstantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetLocalConstantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data)
            => ImplGetLocalConstantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data)
            => ImplGetLocalConstantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetLocalConstantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data)
            => ImplGetLocalConstantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetVariantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantBoolean([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetVariantBoolean(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] float* data)
            => ImplGetVariantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantFloat([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out float data)
            => ImplGetVariantFloat(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] int* data)
            => ImplGetVariantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantInteger([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out int data)
            => ImplGetVariantInteger(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] void** data)
            => ImplGetVariantPointer(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(FlowDirection.Out)] out T0* data) where T0 : unmanaged
            => ImplGetVariantPointer<T0>(id, value, data);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsVariantEnabled([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VariantCapEXT cap)
            => ImplIsVariantEnabled(id, cap);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SetInvariant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr)
            => ImplSetInvariant(id, type, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetInvariant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged
            => ImplSetInvariant<T0>(id, type, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SetLocalConstant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] void* addr)
            => ImplSetLocalConstant(id, type, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetLocalConstant<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged
            => ImplSetLocalConstant<T0>(id, type, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderOp1([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1)
            => ImplShaderOp1(op, res, arg1);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderOp2([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2)
            => ImplShaderOp2(op, res, arg1, arg2);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderOp3([Flow(FlowDirection.In)] VertexShaderOpEXT op, [Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg3)
            => ImplShaderOp3(op, res, arg1, arg2, arg3);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Swizzle([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outX, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outY, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outZ, [Flow(FlowDirection.In)] VertexShaderCoordOutEXT outW)
            => ImplSwizzle(res, @in, outX, outY, outZ, outW);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Variant([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] string addr)
            => ImplVariant(id, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VariantPointer([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] void* addr)
            => ImplVariantPointer(id, type, stride, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VariantPointer<T0>([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(FlowDirection.In)] ref T0 addr) where T0 : unmanaged
            => ImplVariantPointer<T0>(id, type, stride, addr);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WriteMask([Flow(FlowDirection.In)] uint res, [Flow(FlowDirection.In)] uint @in, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outX, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outY, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outZ, [Flow(FlowDirection.In)] VertexShaderWriteMaskEXT outW)
            => ImplWriteMask(res, @in, outX, outY, outZ, outW);

        public ExtVertexShader(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

