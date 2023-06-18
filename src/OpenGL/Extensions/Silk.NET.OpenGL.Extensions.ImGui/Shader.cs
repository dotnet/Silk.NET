// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
#if GLES
using Silk.NET.OpenGLES;
#elif GL
using Silk.NET.OpenGL;
#elif LEGACY
using Silk.NET.OpenGL.Legacy;

#endif

#if GL
namespace Silk.NET.OpenGL.Extensions.ImGui
#elif GLES
namespace Silk.NET.OpenGLES.Extensions.ImGui
#elif LEGACY
namespace Silk.NET.OpenGL.Legacy.Extensions.ImGui
#endif
{
    struct UniformFieldInfo
    {
        public int Location;
        public string Name;
        public int Size;
        public UniformType Type;
    }

    class Shader
    {
        public uint Program { get; private set; }
        private readonly Dictionary<string, int> _uniformToLocation = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _attribLocation = new Dictionary<string, int>();
        private bool _initialized = false;
        private GL _gl;
        private (ShaderType Type, string Path)[] _files;

        public Shader(GL gl, string vertexShader, string fragmentShader)
        {
            _gl = gl;
            _files = new[]{
                (ShaderType.VertexShader, vertexShader),
                (ShaderType.FragmentShader, fragmentShader),
            };
            Program = CreateProgram(_files);
        }
        public void UseShader()
        {
            _gl.UseProgram(Program);
        }

        public void Dispose()
        {
            if (_initialized)
            {
                _gl.DeleteProgram(Program);
                _initialized = false;
            }
        }

        public unsafe UniformFieldInfo[] GetUniforms()
        {
            int uniformCount;
            _gl.GetProgram(Program, GLEnum.ActiveUniforms, &uniformCount);

            UniformFieldInfo[] uniforms = new UniformFieldInfo[uniformCount];

            for (int i = 0; i < uniformCount; i++)
            {
                uint length;
                _gl.GetProgram(Program, GLEnum.ActiveUniformMaxLength, (int*) &length);
                int size;
                GLEnum type;
                string name;
                fixed (byte* namePtr = new byte[length])
                {
                    _gl.GetActiveUniform(Program, (uint) i, length == 0 ? 1 : length, &length, &size, &type, namePtr);
                    name = SilkMarshal.PtrToString((nint) namePtr);
                }

                UniformFieldInfo fieldInfo;
                fieldInfo.Location = GetUniformLocation(name);
                fieldInfo.Name = name;
                fieldInfo.Size = size;
                fieldInfo.Type = (UniformType) type;

                uniforms[i] = fieldInfo;
            }

            return uniforms;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe int GetUniformLocation(string uniform)
        {
            if (_uniformToLocation.TryGetValue(uniform, out int location) == false)
            {
                fixed (byte* uniformPtr = Encoding.UTF8.GetBytes(uniform))
                {
                    location = _gl.GetUniformLocation(Program, uniformPtr);
                }

                _uniformToLocation.Add(uniform, location);

                if (location == -1)
                {
                    Debug.Print($"The uniform '{uniform}' does not exist in the shader!");
                }
            }

            return location;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe int GetAttribLocation(string attrib)
        {
            if (_attribLocation.TryGetValue(attrib, out int location) == false)
            {
                fixed (byte* attribPtr = Encoding.UTF8.GetBytes(attrib))
                {
                    location = _gl.GetAttribLocation(Program, attribPtr);
                }

                _attribLocation.Add(attrib, location);

                if (location == -1)
                {
                    Debug.Print($"The attrib '{attrib}' does not exist in the shader!");
                }
            }

            return location;
        }

        private unsafe uint CreateProgram(params (ShaderType Type, string source)[] shaderPaths)
        {
            var program = _gl.CreateProgram();

            Span<uint> shaders = stackalloc uint[shaderPaths.Length];
            for (int i = 0; i < shaderPaths.Length; i++)
            {
                shaders[i] = CompileShader(shaderPaths[i].Type, shaderPaths[i].source);
            }

            foreach (var shader in shaders)
                _gl.AttachShader(program, shader);

            _gl.LinkProgram(program);

            int success;
            _gl.GetProgram(program, GLEnum.LinkStatus, &success);
            if (success == 0)
            {
                uint length;
                _gl.GetProgram(program, GLEnum.InfoLogLength, (int*) &length);
                string info;
                fixed (byte* infoPtr = new byte[length == 0 ? 1 : length * 2])
                {
                    _gl.GetProgramInfoLog(program, length == 0 ? 1 : length * 2, &length, infoPtr);
                    info = SilkMarshal.PtrToString((nint) infoPtr);
                }

                Debug.WriteLine($"GL.LinkProgram had info log:\n{info}");
            }

            foreach (var shader in shaders)
            {
                _gl.DetachShader(program, shader);
                _gl.DeleteShader(shader);
            }

            _initialized = true;

            return program;
        }

        private unsafe uint CompileShader(ShaderType type, string source)
        {
            var shader = _gl.CreateShader((GLEnum) type);
            fixed (byte* src = Encoding.UTF8.GetBytes(source))
            {
                var len = source.Length;
                _gl.ShaderSource(shader, 1, &src, &len);
            }

            _gl.CompileShader(shader);

            int success;
            _gl.GetShader(shader, GLEnum.CompileStatus, &success);
            if (success == 0)
            {
                uint length;
                _gl.GetShader(shader, GLEnum.InfoLogLength, (int*) &length);
                string info;
                fixed (byte* infoPtr = new byte[length == 0 ? 1 : length * 2])
                {
                    _gl.GetShaderInfoLog(shader, length == 0 ? 1 : length * 2, &length, infoPtr);
                    info = SilkMarshal.PtrToString((nint) infoPtr);
                }
                Debug.WriteLine($"GL.CompileShader for shader [{type}] had info log:\n{info}");
            }

            return shader;
        }
    }
}
