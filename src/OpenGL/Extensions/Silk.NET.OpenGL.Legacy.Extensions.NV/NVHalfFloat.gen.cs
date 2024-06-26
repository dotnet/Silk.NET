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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_half_float")]
    public unsafe partial class NVHalfFloat : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_half_float";
        [NativeApi(EntryPoint = "glColor3hNV", Convention = CallingConvention.Winapi)]
        public partial void Color3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half blue);

        [NativeApi(EntryPoint = "glColor3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glColor3hvNV", Convention = CallingConvention.Winapi)]
        public partial void Color3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glColor4hNV", Convention = CallingConvention.Winapi)]
        public partial void Color4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half alpha);

        [NativeApi(EntryPoint = "glColor4hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4h([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glColor4hvNV", Convention = CallingConvention.Winapi)]
        public partial void Color4h([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glFogCoordhNV", Convention = CallingConvention.Winapi)]
        public partial void FogCoordh([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half fog);

        [NativeApi(EntryPoint = "glFogCoordhvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordh([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* fog);

        [NativeApi(EntryPoint = "glFogCoordhvNV", Convention = CallingConvention.Winapi)]
        public partial void FogCoordh([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half fog);

        [NativeApi(EntryPoint = "glMultiTexCoord1hNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s);

        [NativeApi(EntryPoint = "glMultiTexCoord1hNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s);

        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord2hNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t);

        [NativeApi(EntryPoint = "glMultiTexCoord2hNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t);

        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord3hNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half r);

        [NativeApi(EntryPoint = "glMultiTexCoord3hNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half r);

        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord4hNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half q);

        [NativeApi(EntryPoint = "glMultiTexCoord4hNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half q);

        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glNormal3hNV", Convention = CallingConvention.Winapi)]
        public partial void Normal3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half nz);

        [NativeApi(EntryPoint = "glNormal3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Normal3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glNormal3hvNV", Convention = CallingConvention.Winapi)]
        public partial void Normal3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glSecondaryColor3hNV", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half blue);

        [NativeApi(EntryPoint = "glSecondaryColor3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glSecondaryColor3hvNV", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glTexCoord1hNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoord1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s);

        [NativeApi(EntryPoint = "glTexCoord1hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord1h([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glTexCoord1hvNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoord1h([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glTexCoord2hNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t);

        [NativeApi(EntryPoint = "glTexCoord2hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2h([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glTexCoord2hvNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2h([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glTexCoord3hNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoord3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half r);

        [NativeApi(EntryPoint = "glTexCoord3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glTexCoord3hvNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoord3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glTexCoord4hNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half q);

        [NativeApi(EntryPoint = "glTexCoord4hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4h([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glTexCoord4hvNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4h([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertex2hNV", Convention = CallingConvention.Winapi)]
        public partial void Vertex2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half y);

        [NativeApi(EntryPoint = "glVertex2hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex2h([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertex2hvNV", Convention = CallingConvention.Winapi)]
        public partial void Vertex2h([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertex3hNV", Convention = CallingConvention.Winapi)]
        public partial void Vertex3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half z);

        [NativeApi(EntryPoint = "glVertex3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertex3hvNV", Convention = CallingConvention.Winapi)]
        public partial void Vertex3h([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertex4hNV", Convention = CallingConvention.Winapi)]
        public partial void Vertex4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half w);

        [NativeApi(EntryPoint = "glVertex4hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex4h([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertex4hvNV", Convention = CallingConvention.Winapi)]
        public partial void Vertex4h([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexAttrib1hNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half x);

        [NativeApi(EntryPoint = "glVertexAttrib1hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttrib1hvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexAttrib2hNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half y);

        [NativeApi(EntryPoint = "glVertexAttrib2hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttrib2hvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexAttrib3hNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half z);

        [NativeApi(EntryPoint = "glVertexAttrib3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttrib3hvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexAttrib4hNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half w);

        [NativeApi(EntryPoint = "glVertexAttrib4hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttrib4hvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexAttribs1hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttribs1hvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexAttribs2hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttribs2hvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexAttribs3hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttribs3hvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexAttribs4hvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttribs4hvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half v);

        [NativeApi(EntryPoint = "glVertexWeighthNV", Convention = CallingConvention.Winapi)]
        public partial void VertexWeighth([Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half weight);

        [NativeApi(EntryPoint = "glVertexWeighthvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexWeighth([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Half* weight);

        [NativeApi(EntryPoint = "glVertexWeighthvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexWeighth([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Half weight);

        public unsafe void VertexAttribs1h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs1h(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs2h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs2h(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs3h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs3h(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs4h([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs4h(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public NVHalfFloat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

