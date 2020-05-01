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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_type_2_10_10_10_rev")]
    public abstract unsafe partial class ArbVertexType2101010Rev : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_type_2_10_10_10_rev";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3ui")]
        public abstract void ColorP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract unsafe void ColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract void ColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4ui")]
        public abstract void ColorP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract unsafe void ColorP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract void ColorP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract unsafe void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract unsafe void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract unsafe void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract unsafe void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3ui")]
        public abstract void NormalP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract unsafe void NormalP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract void NormalP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract unsafe void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract unsafe void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract unsafe void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract unsafe void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract unsafe void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2ui")]
        public abstract void VertexP2([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract unsafe void VertexP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract void VertexP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3ui")]
        public abstract void VertexP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract unsafe void VertexP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract void VertexP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4ui")]
        public abstract void VertexP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract unsafe void VertexP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract void VertexP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3ui")]
        public abstract void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract unsafe void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4ui")]
        public abstract void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract unsafe void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract unsafe void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract unsafe void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract unsafe void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract unsafe void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3ui")]
        public abstract void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract unsafe void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract unsafe void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract unsafe void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract unsafe void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract unsafe void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract unsafe void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2ui")]
        public abstract void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract unsafe void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3ui")]
        public abstract void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract unsafe void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4ui")]
        public abstract void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract unsafe void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        public ArbVertexType2101010Rev(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

