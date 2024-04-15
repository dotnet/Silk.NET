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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_type_2_10_10_10_rev")]
    public unsafe partial class ArbVertexType2101010Rev : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_type_2_10_10_10_rev";
        [NativeApi(EntryPoint = "glColorP3ui", Convention = CallingConvention.Winapi)]
        public partial void ColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP3ui", Convention = CallingConvention.Winapi)]
        public partial void ColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP3uiv", Convention = CallingConvention.Winapi)]
        public partial void ColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint color);

        [NativeApi(EntryPoint = "glColorP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP3uiv", Convention = CallingConvention.Winapi)]
        public partial void ColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint color);

        [NativeApi(EntryPoint = "glColorP4ui", Convention = CallingConvention.Winapi)]
        public partial void ColorP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP4ui", Convention = CallingConvention.Winapi)]
        public partial void ColorP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP4uiv", Convention = CallingConvention.Winapi)]
        public partial void ColorP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint color);

        [NativeApi(EntryPoint = "glColorP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP4uiv", Convention = CallingConvention.Winapi)]
        public partial void ColorP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint color);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glNormalP3ui", Convention = CallingConvention.Winapi)]
        public partial void NormalP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glNormalP3ui", Convention = CallingConvention.Winapi)]
        public partial void NormalP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glNormalP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glNormalP3uiv", Convention = CallingConvention.Winapi)]
        public partial void NormalP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glNormalP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glNormalP3uiv", Convention = CallingConvention.Winapi)]
        public partial void NormalP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glSecondaryColorP3ui", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3ui", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint color);

        [NativeApi(EntryPoint = "glTexCoordP1ui", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1ui", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2ui", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2ui", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3ui", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3ui", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4ui", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4ui", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv", Convention = CallingConvention.Winapi)]
        public partial void TexCoordP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint coords);

        [NativeApi(EntryPoint = "glVertexAttribP1ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexP2ui", Convention = CallingConvention.Winapi)]
        public partial void VertexP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP2ui", Convention = CallingConvention.Winapi)]
        public partial void VertexP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP2uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP2uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexP3ui", Convention = CallingConvention.Winapi)]
        public partial void VertexP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP3ui", Convention = CallingConvention.Winapi)]
        public partial void VertexP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP3uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP3uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexP4ui", Convention = CallingConvention.Winapi)]
        public partial void VertexP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP4ui", Convention = CallingConvention.Winapi)]
        public partial void VertexP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP4uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP4uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        public ArbVertexType2101010Rev(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

