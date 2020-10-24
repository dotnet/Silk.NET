// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_type_2_10_10_10_rev")]
    public unsafe partial class ArbVertexType2101010Rev : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_type_2_10_10_10_rev";
        [NativeApi(EntryPoint = "glColorP3ui")]
        public partial void ColorP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP3ui")]
        public partial void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public unsafe partial void ColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public partial void ColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public unsafe partial void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public partial void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint color);

        [NativeApi(EntryPoint = "glColorP4ui")]
        public partial void ColorP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP4ui")]
        public partial void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public unsafe partial void ColorP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public partial void ColorP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public unsafe partial void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public partial void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint color);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public unsafe partial void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public unsafe partial void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public unsafe partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public unsafe partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public unsafe partial void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public unsafe partial void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public unsafe partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public unsafe partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public unsafe partial void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public unsafe partial void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public unsafe partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public unsafe partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public unsafe partial void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public unsafe partial void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public unsafe partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public unsafe partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glNormalP3ui")]
        public partial void NormalP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glNormalP3ui")]
        public partial void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public unsafe partial void NormalP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public partial void NormalP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public unsafe partial void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public partial void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public partial void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public partial void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public unsafe partial void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public partial void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public unsafe partial void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public partial void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint color);

        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public partial void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public partial void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public unsafe partial void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public partial void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public unsafe partial void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public partial void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public partial void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public partial void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public unsafe partial void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public partial void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public unsafe partial void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public partial void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public partial void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public partial void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public unsafe partial void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public partial void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public unsafe partial void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public partial void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public partial void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public partial void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public unsafe partial void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public partial void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public unsafe partial void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public partial void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint coords);

        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public unsafe partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public unsafe partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public unsafe partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public unsafe partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public unsafe partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public unsafe partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public unsafe partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public unsafe partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexP2ui")]
        public partial void VertexP2([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP2ui")]
        public partial void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public unsafe partial void VertexP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public partial void VertexP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public unsafe partial void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public partial void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexP3ui")]
        public partial void VertexP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP3ui")]
        public partial void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public unsafe partial void VertexP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public partial void VertexP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public unsafe partial void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public partial void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexP4ui")]
        public partial void VertexP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP4ui")]
        public partial void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public unsafe partial void VertexP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public partial void VertexP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public unsafe partial void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public partial void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] in uint value);

        public ArbVertexType2101010Rev(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

