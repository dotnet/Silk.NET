// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Microsoft.Extensions.DependencyModel;
using Silk.NET.Core;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Maths;

namespace Silk.NET.OpenGL
{
    public partial class GL
    {
        /// <summary>
        ///     Creates a <see cref="GL" /> instance from an <see cref="IGLContextSource" />.
        /// </summary>
        /// <param name="contextSource">
        /// <see cref="IGLContextSource" /> to create <see cref="GL" /> from.
        /// </param>
        /// <returns>
        ///     A <see cref="GL" /> instance.
        /// </returns>
        public static GL GetApi(IGLContextSource contextSource) => GetApi
        (
             contextSource.GLContext ??
             throw new InvalidOperationException("The given IGLContextSource is not configured with a context.")
        );

        /// <summary>
        ///     Creates a <see cref="GL" /> instance from an <see cref="IGLContext" />.
        /// </summary>
        /// <param name="ctx">
        ///     <see cref="IGLContext" /> to create <see cref="GL" /> from.
        /// </param>
        /// <returns>
        ///     A <see cref="GL" /> instance.
        /// </returns>
        public static GL GetApi(IGLContext ctx) => GetApi((INativeContext) ctx);

        /// <summary>
        ///     Creates a <see cref="GL" /> instance using a function that returns a native OpenGL context.
        /// </summary>
        /// <param name="getProcAddress">
        /// <para>
        ///     Function returning a native OpenGL context.
        /// </para>
        /// <para>
        ///     The <c>string</c> parameter of the <paramref name="getProcAddress" /> function should be the name
        ///     of the native function with needs to be called.
        /// </para>
        /// </param>
        /// <returns>
        ///     A <see cref="GL" /> instance.
        /// </returns>
        public static GL GetApi(Func<string, nint> getProcAddress) => GetApi(new LamdaNativeContext(getProcAddress));

        /// <summary>
        ///     Creates a <see cref="GL" /> instance from an <see cref="INativeContext" />.
        /// </summary>
        /// <param name="ctx">
        ///     <see cref="INativeContext" /> to create <see cref="GL" /> from.
        /// </param>
        /// <returns>
        ///     A <see cref="GL" /> instance.
        /// </returns>
        public static GL GetApi(INativeContext ctx) => new GL(ctx);

        /// <summary>
        ///     Attempts to load a native OpenGL extension of type <typeparamref name="T" />.
        /// </summary>
        /// <param name="ext">
        ///     The loaded extension.
        /// </param>
        /// <typeparam name="T">
        ///     Type of <see cref="NativeExtension{T}" /> to load.
        /// </typeparam>
        /// <returns>
        ///     <c>True</c> if the extension was loaded, otherwise <c>False</c>.
        /// </returns>
#if NET5_0_OR_GREATER
        public bool TryGetExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(out T ext)
#else
        public bool TryGetExtension<T>(out T ext)
#endif
            where T : NativeExtension<GL>
        {
            ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T)Activator.CreateInstance(typeof(T), Context)
                : null;
            return ext != null;
        }

        private List<string> _extensions;

        /// <summary>
        ///     Determines whether a particular OpenGL extension is present on the machine's driver.
        /// </summary>
        /// <param name="extension">
        ///     Standard identifier for the extension.
        /// </param>
        /// <returns>
        ///     <c>True</c> if the extension is present, otherwise <c>False</c>.
        /// </returns>
        public override bool IsExtensionPresent(string extension)
        {
            _extensions ??= Enumerable.Range(0, GetInteger(GLEnum.NumExtensions))
                .Select(x => GetStringS(StringName.Extensions, (uint) x))
                .ToList();

            return _extensions.Contains("GL_" + (extension.StartsWith("GL_") ? extension.Substring(3) : extension));
        }

        /// <summary>
        ///     Invokes a call to <c>glClearColor()</c>, setting the clear color of the OpenGL context.
        /// </summary>
        /// <param name="color">
        ///     New clear color for the OpenGL context.
        /// </param>
        public void ClearColor(Color color)
            => ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);

        /// <summary>
        ///     Invokes a call to <c>glClearColor()</c>, setting the clear color of the OpenGL context.
        /// </summary>
        /// <param name="color">
        ///     New clear color for the OpenGL context.
        /// </param>
        public void ClearColor<T>(Vector4D<T> color) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => ClearColor(Scalar.As<T, float>(color.X) / 255.0f,
                          Scalar.As<T, float>(color.Y) / 255.0f,
                          Scalar.As<T, float>(color.Z) / 255.0f,
                          Scalar.As<T, float>(color.W) / 255.0f);

        /// <summary>
        ///     Invokes a call to <c>glBlendColor()</c>, setting the blend color of the OpenGL context.
        /// </summary>
        /// <param name="color">
        ///     New blend color for the OpenGL context.
        /// </param>
        public void BlendColor(Color color)
            => BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);

        /// <summary>
        ///     Invokes a call to <c>glBlendColor()</c>, setting the blend color of the OpenGL context.
        /// </summary>
        /// <param name="color">
        ///     New blend color for the OpenGL context.
        /// </param>
        public void BlendColor<T>(Vector4D<T> color) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => BlendColor(Scalar.As<T, float>(color.X) / 255.0f,
                          Scalar.As<T, float>(color.Y) / 255.0f,
                          Scalar.As<T, float>(color.Z) / 255.0f,
                          Scalar.As<T, float>(color.W) / 255.0f);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void Uniform2(int location, ref Vector2 vector) => Uniform2(location, vector.X, vector.Y);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void Uniform3(int location, ref Vector3 vector) => Uniform3(location, vector.X, vector.Y, vector.Z);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void Uniform4(int location, ref Vector4 vector)
            => Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void Uniform2(int location, Vector2 vector) => Uniform2(location, vector.X, vector.Y);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void Uniform3(int location, Vector3 vector) => Uniform3(location, vector.X, vector.Y, vector.Z);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void Uniform4(int location, Vector4 vector)
            => Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="quaternion">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void Uniform4(int location, Quaternion quaternion)
            => Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);

        /// <summary>
        ///     Specify the value of a uniform variable for a specified program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glProgramUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void ProgramUniform2(uint program, int location, ref Vector2 vector)
            => ProgramUniform2(program, location, vector.X, vector.Y);

        /// <summary>
        ///     Specify the value of a uniform variable for a specified program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glProgramUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void ProgramUniform3(uint program, int location, ref Vector3 vector)
            => ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);

        /// <summary>
        ///     Specify the value of a uniform variable for a specified program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glProgramUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void ProgramUniform4(uint program, int location, ref Vector4 vector)
        {
            ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        ///     Specify the value of a uniform variable for a specified program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glProgramUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void ProgramUniform2(uint program, int location, Vector2 vector)
            => ProgramUniform2(program, location, vector.X, vector.Y);

        /// <summary>
        ///     Specify the value of a uniform variable for a specified program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glProgramUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void ProgramUniform3(uint program, int location, Vector3 vector)
            => ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);

        /// <summary>
        ///     Specify the value of a uniform variable for a specified program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glProgramUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void ProgramUniform4(uint program, int location, Vector4 vector)
            => ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);

        /// <summary>
        ///     Specify the value of a uniform variable for a specified program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        ///     Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="quaternion">
        ///     The value to update the uniform variable with.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glVertexAttrib.xhtml">
        ///     OpenGL Documentation
        ///     </see>
        /// </remarks>
        public void ProgramUniform4(uint program, int location, Quaternion quaternion)
        {
            ProgramUniform4(program, location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        /// <summary>
        ///      Gets information about an active attribute variable.
        /// </summary>
        /// <param name="program">
        ///      Specifies the program object to be queried.
        /// </param>
        /// <param name="index">
        ///     Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="size">
        ///     Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">
        ///     Returns the data type of the attribute variable.
        /// </param>
        /// <returns>
        ///      <see cref="string" /> containing the name of the attribute variable.
        /// </returns>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/es2.0/xhtml/glGetActiveAttrib.xml">OpenGL Documentation</see>
        /// </remarks>
        public string GetActiveAttrib(uint program, uint index, out int size, out AttributeType type)
        {
            uint length;
            GetProgram(program, GLEnum.ActiveAttributeMaxLength, out var lengthTmp);
            length = (uint) lengthTmp;

            GetActiveAttrib
                (program, index, (uint) (length == 0 ? 1 : length * 2), out length, out size, out type, out string str);

            return str.Substring(0, (int) length);
        }

        /// <summary>
        ///     Gets information about an active uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the program object to be queried.
        /// </param>
        /// <param name="uniformIndex">
        ///     Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="size">
        ///     Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">
        ///     Returns the data type of the uniform variable.
        /// </param>
        /// <returns>
        ///      <see cref="string" /> containing the name of the uniform variable.
        /// </returns>
        /// <remarks>
        ///      <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetActiveUniform.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public string GetActiveUniform(uint program, uint uniformIndex, out int size, out UniformType type)
        {
            uint length;
            GetProgram(program, GLEnum.ActiveUniformMaxLength, out var lengthTmp);
            length = (uint) lengthTmp;

            GetActiveUniform
                (program, uniformIndex, length == 0 ? 1 : length, out length, out size, out type, out string str);

            return str.Substring(0, (int) length);
        }

        /// <summary>
        ///     Replaces the source code in a shader object.
        /// </summary>
        /// <param name="shader">
        ///      Specifies the handle of the shader object whose source code is to be replaced.
        /// </param>
        /// <param name="string">
        ///     Specifies the source code to be loaded into the shader.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glShaderSource.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void ShaderSource(uint shader, string @string)
        {
            unsafe
            {
                var length = @string.Length;
                ShaderSource((uint) shader, 1, new[] { @string }, &length);
            }
        }

        /// <summary>
        ///     Returns the information log for a shader object.
        /// </summary>
        /// <param name="shader">
        ///     Specifies the shader object whose information log is to be queried.
        /// </param>
        /// <returns>
        ///     The information log for the shader object.
        /// </returns>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetShaderInfoLog.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public string GetShaderInfoLog(uint shader)
        {
            GetShaderInfoLog(shader, out var info);
            return info;
        }

        /// <summary>
        ///     Returns the information log for a shader object.
        /// </summary>
        /// <param name="shader">
        ///     Specifies the shader object whose information log is to be queried.
        /// </param>
        /// <param name="info">
        ///     The information log for the shader object.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetShaderInfoLog.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void GetShaderInfoLog(uint shader, out string info)
        {
            GetShader(shader, GLEnum.InfoLogLength, out var length2);
            if (length2 <= 0)
            {
                info = string.Empty;
                return;
            }
            
            var length = (uint) length2;
            GetShaderInfoLog(shader, length * 2, out length, out info);
            info = info.Substring(0, (int) length);
        }

        /// <summary>
        ///     Returns the information log for a program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the program object whose information log is to be queried.
        /// </param>
        /// <returns>
        ///     The information log for the program object.
        /// </returns>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetProgramInfoLog.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public string GetProgramInfoLog(uint program)
        {
            GetProgramInfoLog(program, out var info);
            return info;
        }

        /// <summary>
        ///     Returns the information log for a program object.
        /// </summary>
        /// <param name="program">
        ///     Specifies the program object whose information log is to be queried.
        /// </param>
        /// <param name="info">
        ///     The information log for the program object.
        /// </param>
        /// <remarks>
        ///  <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetProgramInfoLog.xhtml">OpenGL Documentation</see>
        /// </remarks>
        public void GetProgramInfoLog(uint program, out string info)
        {
            GetProgram(program, GLEnum.InfoLogLength, out var length2);
            var length = (uint) length2;
            GetProgramInfoLog(program, length * 2, out length, out info);
            info = info.Substring(0, (int) length);
        }

        /// <summary>
        ///      Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        ///     Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        ///     Value to be used for the generic vertex attribute.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glVertexAttrib.xhtml">OpenGL Documentation</see>
        /// </remarks>
        [CLSCompliant(false)]
        public void VertexAttrib2(uint index, ref Vector2 v) => VertexAttrib2(index, v.X, v.Y);

        /// <summary>
        ///      Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        ///     Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        ///     Value to be used for the generic vertex attribute.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glVertexAttrib.xhtml">
        ///     OpenGL Documentation
        ///     </see>
        /// </remarks>
        [CLSCompliant(false)]
        public void VertexAttrib3(uint index, ref Vector3 v) => VertexAttrib3(index, v.X, v.Y, v.Z);

        /// <summary>
        ///      Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        ///     Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        ///     Value to be used for the generic vertex attribute.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glVertexAttrib.xhtml">
        ///     OpenGL Documentation
        ///     </see>
        /// </remarks>
        [CLSCompliant(false)]
        public void VertexAttrib4(uint index, ref Vector4 v) => VertexAttrib4(index, v.X, v.Y, v.Z, v.W);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        ///     Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        ///     Value to be used for the generic vertex attribute.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glVertexAttrib.xhtml">
        ///     OpenGL Documentation
        ///     </see>
        /// </remarks>
        public void VertexAttrib2(uint index, Vector2 v) => VertexAttrib2(index, v.X, v.Y);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        ///     Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        ///     Value to be used for the generic vertex attribute.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glVertexAttrib.xhtml">
        ///     OpenGL Documentation
        ///     </see>
        /// </remarks>
        public void VertexAttrib3(uint index, Vector3 v) => VertexAttrib3(index, v.X, v.Y, v.Z);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        ///     Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        ///     Value to be used for the generic vertex attribute.
        /// </param>
        /// <remarks>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glVertexAttrib.xhtml">
        ///     OpenGL Documentation
        ///     </see>
        /// </remarks>
        public void VertexAttrib4(uint index, Vector4 v) => VertexAttrib4(index, v.X, v.Y, v.Z, v.W);

        //public unsafe void VertexAttribPointer(uint index, int size, GLEnum type, bool normalized, uint stride, int offset)
        //{
        //    VertexAttribPointer(index, size, type, normalized, stride, (void*)offset);
        //}

        //public unsafe void DrawElements(GLEnum mode, uint count, GLEnum type, int offset)
        //{
        //    DrawElements((GLEnum)mode, count, type, (void*)(offset));
        //}

        /// <summary>
        ///     Gets the values of a selected floating-point parameter.
        /// </summary>
        /// <param name="pname">
        ///     Specifies the parameter value to be returned.
        /// </param>
        /// <param name="vector">
        ///     The returned values.
        /// </param>
        /// <remarks>
        ///  <para>
        ///      A list of valid symbolic constants (parameter names) can be found in the documentation at the provided link.
        ///  </para>
        ///  <para>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl2.1/xhtml/glGet.xml">
        ///     OpenGL Documentation
        ///     </see>
        ///  </para>
        /// </remarks>
        public void GetFloat(GLEnum pname, out Vector2 vector)
        {
            unsafe
            {
                fixed (Vector2* ptr = &vector)
                {
                    GetFloat(pname, (float*) ptr);
                }
            }
        }

        /// <summary>
        ///     Gets the values of a selected floating-point parameter.
        /// </summary>
        /// <param name="pname">
        ///     Specifies the parameter value to be returned.
        /// </param>
        /// <param name="vector">
        ///      The returned values.
        /// </param>
        /// <remarks>
        ///  <para>
        ///      A list of valid symbolic constants (parameter names) can be found in the documentation at the
        ///      provided link.
        ///  </para>
        ///  <para>
        ///      <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl2.1/xhtml/glGet.xml">
        ///      OpenGL Documentation
        ///      </see>
        ///  </para>
        /// </remarks>
        public void GetFloat(GLEnum pname, out Vector3 vector)
        {
            unsafe
            {
                fixed (Vector3* ptr = &vector)
                {
                    GetFloat(pname, (float*) ptr);
                }
            }
        }

        /// <summary>
        ///     Gets the values of a selected floating-point parameter.
        /// </summary>
        /// <param name="pname">
        ///     Specifies the parameter value to be returned.
        /// </param>
        /// <param name="vector">
        ///      The returned values.
        /// </param>
        /// <remarks>
        ///  <para>
        ///      A list of valid symbolic constants (parameter names) can be found in the documentation at the
        ///      provided link.
        ///  </para>
        ///  <para>
        ///      <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl2.1/xhtml/glGet.xml">
        ///      OpenGL Documentation
        ///      </see>
        ///  </para>
        /// </remarks>
        public void GetFloat(GLEnum pname, out Vector4 vector)
        {
            unsafe
            {
                fixed (Vector4* ptr = &vector)
                {
                    GetFloat(pname, (float*) ptr);
                }
            }
        }

        /// <summary>
        ///     Gets the values of a selected floating-point parameter.
        /// </summary>
        /// <param name="pname">
        ///     Specifies the parameter value to be returned.
        /// </param>
        /// <param name="matrix">
        ///      The returned values.
        /// </param>
        /// <remarks>
        ///  <para>
        ///      A list of valid symbolic constants (parameter names) can be found in the documentation at the
        ///      provided link.
        ///  </para>
        ///  <para>
        ///      <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl2.1/xhtml/glGet.xml">
        ///      OpenGL Documentation
        ///      </see>
        ///  </para>
        /// </remarks>
        public void GetFloat(GLEnum pname, out Matrix4x4 matrix)
        {
            unsafe
            {
                fixed (Matrix4x4* ptr = &matrix)
                {
                    GetFloat(pname, (float*) ptr);
                }
            }
        }

        /// <summary>
        ///     Set the viewport for the OpenGL context.
        /// </summary>
        /// <param name="size">
        ///     Specifies the width and height of the viewport.
        /// </param>
        /// <remarks>
        ///  <para>
        ///     The location of the viewport will default to 0,0.
        ///  </para>
        ///  <para>
        ///     When an OpenGL context is first attached to a window, width and height are set to the dimensions of
        ///     that window.
        ///  </para>
        ///  <para>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glViewport.xhtml">
        ///       OpenGL Documentation
        ///     </see>
        ///  </para>
        /// </remarks>
        public void Viewport(Size size) => Viewport(0, 0, (uint) size.Width, (uint) size.Height);

        /// <summary>
        ///     Set the viewport for the OpenGL context.
        /// </summary>
        /// <param name="size">
        ///     Specifies the width and height of the viewport.
        /// </param>
        /// <remarks>
        ///  <para>
        ///     The location of the viewport will default to 0,0.
        ///  </para>
        ///  <para>
        ///     When an OpenGL context is first attached to a window, width and height are set to the dimensions of
        ///     that window.
        ///  </para>
        ///  <para>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glViewport.xhtml">
        ///       OpenGL Documentation
        ///     </see>
        ///  </para>
        /// </remarks>
        public void Viewport(Vector2D<int> size) => Viewport(0, 0, (uint) size.X, (uint) size.Y);

        /// <summary>
        ///      Set the viewport for the OpenGL context.
        /// </summary>
        /// <param name="location">
        ///      Specifies the lower left corner of the viewport rectangle, in pixels.
        /// </param>
        /// <param name="size">
        /// Specifies the width and height of the viewport.
        /// </param>
        /// <remarks>
        ///  <para>
        ///     When an OpenGL context is first attached to a window, width and height are set to the dimensions of
        ///     that window.
        ///  </para>
        ///  <para>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glViewport.xhtml">
        ///       OpenGL Documentation
        ///     </see>
        ///  </para>
        /// </remarks>
        public void Viewport(Point location, Size size)
            => Viewport(location.X, location.Y, (uint) size.Width, (uint) size.Height);

        /// <summary>
        ///      Set the viewport for the OpenGL context.
        /// </summary>
        /// <param name="location">
        ///      Specifies the lower left corner of the viewport rectangle, in pixels.
        /// </param>
        /// <param name="size">
        /// Specifies the width and height of the viewport.
        /// </param>
        /// <remarks>
        ///  <para>
        ///     When an OpenGL context is first attached to a window, width and height are set to the dimensions of
        ///     that window.
        ///  </para>
        ///  <para>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glViewport.xhtml">
        ///       OpenGL Documentation
        ///     </see>
        ///  </para>
        /// </remarks>
        public void Viewport(Vector2D<int> location, Vector2D<int> size)
            => Viewport(location.X, location.Y, (uint) size.X, (uint) size.Y);

        /// <summary>
        ///     Set the viewport for the OpenGL context.
        /// </summary>
        /// <param name="rectangle">
        ///     Specifies the viewport rectangle explicitly.
        /// </param>
        /// <remarks>
        ///  <para>
        ///     When an OpenGL context is first attached to a window, width and height are set to the dimensions of
        ///     that window.
        ///  </para>
        ///  <para>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glViewport.xhtml">
        ///       OpenGL Documentation
        ///     </see>
        ///  </para>
        /// </remarks>
        public void Viewport(System.Drawing.Rectangle rectangle)
            => Viewport(rectangle.X, rectangle.Y, (uint) rectangle.Width, (uint) rectangle.Height);

        /// <summary>
        ///     Set the viewport for the OpenGL context.
        /// </summary>
        /// <param name="rectangle">
        ///     Specifies the viewport rectangle explicitly.
        /// </param>
        /// <remarks>
        ///  <para>
        ///     When an OpenGL context is first attached to a window, width and height are set to the dimensions of
        ///     that window.
        ///  </para>
        ///  <para>
        ///     <see href="https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glViewport.xhtml">
        ///       OpenGL Documentation
        ///     </see>
        ///  </para>
        /// </remarks>
        public void Viewport(Rectangle<int> rectangle)
            => Viewport(rectangle.Origin.X, rectangle.Origin.Y, (uint) rectangle.Size.X, (uint) rectangle.Size.Y);
    }
}
