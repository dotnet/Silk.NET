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
    [Extension("EXT_histogram")]
    public unsafe partial class ExtHistogram : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_histogram";
        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glResetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void ResetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glResetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void ResetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target);

        [NativeApi(EntryPoint = "glResetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void ResetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glResetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void ResetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target);

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetMinmaxParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetMinmaxParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetMinmaxParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetMinmaxParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public ExtHistogram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

