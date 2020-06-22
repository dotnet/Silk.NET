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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_byte_coordinates")]
    public abstract unsafe partial class OesByteCoordinates : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_byte_coordinates";
        [NativeApi(EntryPoint = "glMultiTexCoord1bOES")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] sbyte s);

        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] ref sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2bOES")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t);

        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3bOES")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r);

        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4bOES")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r, [Flow(FlowDirection.In)] sbyte q);

        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glTexCoord1bOES")]
        public abstract void TexCoord1([Flow(FlowDirection.In)] sbyte s);

        [NativeApi(EntryPoint = "glTexCoord1bvOES")]
        public abstract unsafe void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glTexCoord1bvOES")]
        public abstract void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] ref sbyte coords);

        [NativeApi(EntryPoint = "glTexCoord2bOES")]
        public abstract void TexCoord2([Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t);

        [NativeApi(EntryPoint = "glTexCoord2bvOES")]
        public abstract unsafe void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glTexCoord2bvOES")]
        public abstract void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glTexCoord3bOES")]
        public abstract void TexCoord3([Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r);

        [NativeApi(EntryPoint = "glTexCoord3bvOES")]
        public abstract unsafe void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glTexCoord3bvOES")]
        public abstract void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glTexCoord4bOES")]
        public abstract void TexCoord4([Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r, [Flow(FlowDirection.In)] sbyte q);

        [NativeApi(EntryPoint = "glTexCoord4bvOES")]
        public abstract unsafe void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glTexCoord4bvOES")]
        public abstract void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glVertex2bOES")]
        public abstract void Vertex2([Flow(FlowDirection.In)] sbyte x, [Flow(FlowDirection.In)] sbyte y);

        [NativeApi(EntryPoint = "glVertex2bvOES")]
        public abstract unsafe void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glVertex2bvOES")]
        public abstract void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glVertex3bOES")]
        public abstract void Vertex3([Flow(FlowDirection.In)] sbyte x, [Flow(FlowDirection.In)] sbyte y, [Flow(FlowDirection.In)] sbyte z);

        [NativeApi(EntryPoint = "glVertex3bvOES")]
        public abstract unsafe void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glVertex3bvOES")]
        public abstract void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glVertex4bOES")]
        public abstract void Vertex4([Flow(FlowDirection.In)] sbyte x, [Flow(FlowDirection.In)] sbyte y, [Flow(FlowDirection.In)] sbyte z, [Flow(FlowDirection.In)] sbyte w);

        [NativeApi(EntryPoint = "glVertex4bvOES")]
        public abstract unsafe void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glVertex4bvOES")]
        public abstract void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1bOES")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] sbyte s);

        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] ref sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2bOES")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t);

        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3bOES")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r);

        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4bOES")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r, [Flow(FlowDirection.In)] sbyte q);

        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> coords);

        public OesByteCoordinates(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

