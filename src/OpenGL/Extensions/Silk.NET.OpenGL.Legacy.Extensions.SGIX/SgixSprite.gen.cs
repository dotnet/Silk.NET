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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_sprite")]
    public unsafe partial class SgixSprite : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_sprite";
        [NativeApi(EntryPoint = "glSpriteParameterfSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSpriteParameterfSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glSpriteParameteriSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSpriteParameteriSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteModeSGIX param);

        [NativeApi(EntryPoint = "glSpriteParameteriSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSpriteParameteriSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteModeSGIX param);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteModeSGIX* @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpriteModeSGIX @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteModeSGIX* @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX", Convention = CallingConvention.Winapi)]
        public partial void SpriteParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpriteModeSGIX @params);

        public SgixSprite(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

