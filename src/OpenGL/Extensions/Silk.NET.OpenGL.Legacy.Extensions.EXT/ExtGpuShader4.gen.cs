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
    [Extension("EXT_gpu_shader4")]
    public unsafe partial class ExtGpuShader4 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_gpu_shader4";
        [NativeApi(EntryPoint = "glBindFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public partial void BindFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public partial void BindFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public partial int GetFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glGetFragDataLocationEXT", Convention = CallingConvention.Winapi)]
        public partial int GetFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetUniformuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glUniform1uiEXT", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glUniform1uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform1uivEXT", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glUniform2uiEXT", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glUniform2uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform2uivEXT", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glUniform3uiEXT", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glUniform3uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform3uivEXT", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glUniform4uiEXT", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glUniform4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform4uivEXT", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribI1iEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertexAttribI1uiEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x);

        [NativeApi(EntryPoint = "glVertexAttribI1ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI1ivEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glVertexAttribI1uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI1uivEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint v);

        [NativeApi(EntryPoint = "glVertexAttribI2iEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertexAttribI2uiEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y);

        [NativeApi(EntryPoint = "glVertexAttribI2ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI2ivEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glVertexAttribI2uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI2uivEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint v);

        [NativeApi(EntryPoint = "glVertexAttribI3iEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertexAttribI3uiEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint z);

        [NativeApi(EntryPoint = "glVertexAttribI3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI3ivEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glVertexAttribI3uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI3uivEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint v);

        [NativeApi(EntryPoint = "glVertexAttribI4iEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glVertexAttribI4uiEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glVertexAttribI4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI4ivEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glVertexAttribI4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI4uivEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint v);

        [NativeApi(EntryPoint = "glVertexAttribI4bvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttribI4bvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte v);

        [NativeApi(EntryPoint = "glVertexAttribI4svEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribI4svEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string v);

        [NativeApi(EntryPoint = "glVertexAttribI4usvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttribI4usvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort v);

        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribIPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribIPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribIType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribIType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        public unsafe void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            Uniform1(location, (uint) value.Length/1, in value.GetPinnableReference());
        }

        public unsafe void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            Uniform2(location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            Uniform3(location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            Uniform4(location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe uint GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location)
        {
            // NonKhrReturnTypeOverloader
            GetUniform(program, location, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexAttribI(index, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexAttribI(index, pname, out int silkRet);
            return silkRet;
        }

        public ExtGpuShader4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

