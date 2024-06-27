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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_byte_coordinates")]
    public unsafe partial class OesByteCoordinates : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_byte_coordinates";
        [NativeApi(EntryPoint = "glMultiTexCoord1bOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s);

        [NativeApi(EntryPoint = "glMultiTexCoord1bOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s);

        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2bOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t);

        [NativeApi(EntryPoint = "glMultiTexCoord2bOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t);

        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3bOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte r);

        [NativeApi(EntryPoint = "glMultiTexCoord3bOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte r);

        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4bOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte q);

        [NativeApi(EntryPoint = "glMultiTexCoord4bOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte q);

        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glTexCoord1bOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s);

        [NativeApi(EntryPoint = "glTexCoord1bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord1([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glTexCoord1bvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord1([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glTexCoord2bOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t);

        [NativeApi(EntryPoint = "glTexCoord2bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glTexCoord2bvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glTexCoord3bOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte r);

        [NativeApi(EntryPoint = "glTexCoord3bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glTexCoord3bvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glTexCoord4bOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte q);

        [NativeApi(EntryPoint = "glTexCoord4bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glTexCoord4bvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glVertex2bOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex2([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte y);

        [NativeApi(EntryPoint = "glVertex2bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glVertex2bvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glVertex3bOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte z);

        [NativeApi(EntryPoint = "glVertex3bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glVertex3bvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        [NativeApi(EntryPoint = "glVertex4bOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex4([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte w);

        [NativeApi(EntryPoint = "glVertex4bvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glVertex4bvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte coords);

        public OesByteCoordinates(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

