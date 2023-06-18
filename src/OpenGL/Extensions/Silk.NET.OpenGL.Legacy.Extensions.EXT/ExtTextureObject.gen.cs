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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_texture_object")]
    public unsafe partial class ExtTextureObject : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_object";
        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glBindTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glIsTextureEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities);

        public ExtTextureObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

