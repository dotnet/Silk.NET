// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_shader")]
    public abstract unsafe partial class ArbVertexShader : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindAttribLocationARB")]
        public abstract unsafe void BindAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindAttribLocationARB")]
        public abstract void BindAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableVertexAttribArrayARB")]
        public abstract void DisableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableVertexAttribArrayARB")]
        public abstract void EnableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAttribARB")]
        public abstract unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAttribARB")]
        public abstract void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttribLocationARB")]
        public abstract unsafe int GetAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttribLocationARB")]
        public abstract int GetAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribdvARB")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribdvARB")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribfvARB")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribfvARB")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribivARB")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribivARB")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB")]
        public abstract unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB")]
        public abstract unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1fARB")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1sARB")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1dARB")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1fvARB")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1fvARB")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1svARB")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1svARB")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1dvARB")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1dvARB")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2fARB")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2sARB")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2dARB")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2fvARB")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2fvARB")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2svARB")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2svARB")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2dvARB")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2dvARB")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3fARB")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3sARB")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3dARB")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3fvARB")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3fvARB")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3svARB")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3svARB")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3dvARB")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3dvARB")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4fARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4sARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4dARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4fvARB")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4fvARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4svARB")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4svARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4dvARB")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4dvARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4ivARB")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4ivARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4bvARB")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4bvARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4usvARB")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4usvARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4uivARB")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4uivARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NubARB")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NbvARB")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NbvARB")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NsvARB")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NsvARB")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NivARB")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NivARB")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NusvARB")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NusvARB")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NuivARB")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NuivARB")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribPointerARB")]
        public abstract unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribPointerARB")]
        public abstract void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindAttribLocationARB")]
        public abstract void BindAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAttribARB")]
        public abstract unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAttribARB")]
        public abstract void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttribLocationARB")]
        public abstract int GetAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribdvARB")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribdvARB")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribfvARB")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribfvARB")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribivARB")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribivARB")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB")]
        public abstract unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB")]
        public abstract unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribPointerARB")]
        public abstract unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribPointerARB")]
        public abstract void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ArbVertexShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

