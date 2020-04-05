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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_half_float")]
    public abstract unsafe partial class NVHalfFloat : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColor3hNV")]
        public abstract void Color3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half red, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half green, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColor3hvNV")]
        public abstract unsafe void Color3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColor3hvNV")]
        public abstract void Color3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColor4hNV")]
        public abstract void Color4h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half red, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half green, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half blue, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half alpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColor4hvNV")]
        public abstract unsafe void Color4h([Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColor4hvNV")]
        public abstract void Color4h([Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFogCoordhNV")]
        public abstract void FogCoordh([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half fog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFogCoordhvNV")]
        public abstract unsafe void FogCoordh([Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* fog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFogCoordhvNV")]
        public abstract void FogCoordh([Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half fog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1hNV")]
        public abstract void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        public abstract unsafe void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        public abstract void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2hNV")]
        public abstract void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        public abstract unsafe void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        public abstract void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3hNV")]
        public abstract void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        public abstract unsafe void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        public abstract void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4hNV")]
        public abstract void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        public abstract unsafe void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        public abstract void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormal3hNV")]
        public abstract void Normal3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half nx, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half ny, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormal3hvNV")]
        public abstract unsafe void Normal3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormal3hvNV")]
        public abstract void Normal3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3hNV")]
        public abstract void SecondaryColor3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half red, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half green, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3hvNV")]
        public abstract unsafe void SecondaryColor3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3hvNV")]
        public abstract void SecondaryColor3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord1hNV")]
        public abstract void TexCoord1h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord1hvNV")]
        public abstract unsafe void TexCoord1h([Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord1hvNV")]
        public abstract void TexCoord1h([Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord2hNV")]
        public abstract void TexCoord2h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord2hvNV")]
        public abstract unsafe void TexCoord2h([Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord2hvNV")]
        public abstract void TexCoord2h([Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord3hNV")]
        public abstract void TexCoord3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord3hvNV")]
        public abstract unsafe void TexCoord3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord3hvNV")]
        public abstract void TexCoord3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord4hNV")]
        public abstract void TexCoord4h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord4hvNV")]
        public abstract unsafe void TexCoord4h([Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoord4hvNV")]
        public abstract void TexCoord4h([Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex2hNV")]
        public abstract void Vertex2h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex2hvNV")]
        public abstract unsafe void Vertex2h([Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex2hvNV")]
        public abstract void Vertex2h([Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex3hNV")]
        public abstract void Vertex3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex3hvNV")]
        public abstract unsafe void Vertex3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex3hvNV")]
        public abstract void Vertex3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex4hNV")]
        public abstract void Vertex4h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half z, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex4hvNV")]
        public abstract unsafe void Vertex4h([Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertex4hvNV")]
        public abstract void Vertex4h([Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1hNV")]
        public abstract void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1hvNV")]
        public abstract unsafe void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1hvNV")]
        public abstract void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2hNV")]
        public abstract void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2hvNV")]
        public abstract unsafe void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2hvNV")]
        public abstract void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3hNV")]
        public abstract void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3hvNV")]
        public abstract unsafe void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3hvNV")]
        public abstract void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4hNV")]
        public abstract void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half z, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4hvNV")]
        public abstract unsafe void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4hvNV")]
        public abstract void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribs1hvNV")]
        public abstract unsafe void VertexAttribs1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribs1hvNV")]
        public abstract void VertexAttribs1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribs2hvNV")]
        public abstract unsafe void VertexAttribs2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribs2hvNV")]
        public abstract void VertexAttribs2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribs3hvNV")]
        public abstract unsafe void VertexAttribs3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribs3hvNV")]
        public abstract void VertexAttribs3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribs4hvNV")]
        public abstract unsafe void VertexAttribs4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribs4hvNV")]
        public abstract void VertexAttribs4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexWeighthNV")]
        public abstract void VertexWeighth([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half weight);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexWeighthvNV")]
        public abstract unsafe void VertexWeighth([Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* weight);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexWeighthvNV")]
        public abstract void VertexWeighth([Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half weight);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1hNV")]
        public abstract void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        public abstract unsafe void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        public abstract void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2hNV")]
        public abstract void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        public abstract unsafe void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        public abstract void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3hNV")]
        public abstract void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        public abstract unsafe void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        public abstract void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4hNV")]
        public abstract void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        public abstract unsafe void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        public abstract void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v);

        public NVHalfFloat(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

