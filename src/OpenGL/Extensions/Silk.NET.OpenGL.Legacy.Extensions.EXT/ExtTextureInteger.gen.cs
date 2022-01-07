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
    [Extension("EXT_texture_integer")]
    public unsafe partial class ExtTextureInteger : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_integer";
        [NativeApi(EntryPoint = "glClearColorIiEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearColorI([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearColorIuiEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearColorI([Flow(FlowDirection.In)] uint red, [Flow(FlowDirection.In)] uint green, [Flow(FlowDirection.In)] uint blue, [Flow(FlowDirection.In)] uint alpha);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        public ExtTextureInteger(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

