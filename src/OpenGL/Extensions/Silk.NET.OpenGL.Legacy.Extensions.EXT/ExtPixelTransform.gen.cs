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
    [Extension("EXT_pixel_transform")]
    public unsafe partial class ExtPixelTransform : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_pixel_transform";
        [NativeApi(EntryPoint = "glGetPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetPixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetPixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glPixelTransformParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransformParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransformParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransformParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransformParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTransformParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTransformParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTransformParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void PixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        public unsafe int GetPixelTransformParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetPixelTransformParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public ExtPixelTransform(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

