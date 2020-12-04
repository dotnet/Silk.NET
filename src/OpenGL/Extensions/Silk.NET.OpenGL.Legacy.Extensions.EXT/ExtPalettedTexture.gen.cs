// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    [Extension("EXT_paletted_texture")]
    public unsafe partial class ExtPalettedTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_paletted_texture";
        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        public ExtPalettedTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

