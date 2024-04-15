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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_pixel_texture")]
    public unsafe partial class SgisPixelTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_pixel_texture";
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public partial void GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        public unsafe int GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetPixelTexGenParameter(pname, &ret);
            return ret;
        }

        public unsafe int GetPixelTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenParameterNameSGIS pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetPixelTexGenParameter(pname, &ret);
            return ret;
        }

        public SgisPixelTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

