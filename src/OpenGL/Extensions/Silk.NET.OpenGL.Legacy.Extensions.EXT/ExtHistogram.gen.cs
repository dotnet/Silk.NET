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
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glResetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void ResetHistogram([Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glResetHistogramEXT", Convention = CallingConvention.Winapi)]
        public partial void ResetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target);

        [NativeApi(EntryPoint = "glResetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void ResetMinmax([Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glResetMinmaxEXT", Convention = CallingConvention.Winapi)]
        public partial void ResetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target);

        public ExtHistogram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

