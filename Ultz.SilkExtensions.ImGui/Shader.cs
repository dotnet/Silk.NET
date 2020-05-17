using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Silk.NET.OpenGL;

namespace Ultz.SilkExtensions.ImGui
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
        public readonly string Name;
        public uint Program { get; private set; }
        private readonly Dictionary<string, int> _uniformToLocation = new Dictionary<string, int>();
        private bool _initialized = false;
        private GL _gl;
        private (ShaderType Type, string Path)[] _files;

        public Shader(GL gl, string name, string vertexShader, string fragmentShader)
        {
            _gl = gl;
            Name = name;
            _files = new[]{
                (ShaderType.VertexShader, vertexShader),
                (ShaderType.FragmentShader, fragmentShader),
            };
            Program = CreateProgram(name, _files);
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

        public UniformFieldInfo[] GetUniforms()
        {
            _gl.GetProgram(Program, GLEnum.ActiveUniforms, out var unifromCount);

            UniformFieldInfo[] uniforms = new UniformFieldInfo[unifromCount];

            for (int i = 0; i < unifromCount; i++)
            {
                string name = _gl.GetActiveUniform(Program, (uint) i, out int size, out UniformType type);

                UniformFieldInfo fieldInfo;
                fieldInfo.Location = GetUniformLocation(name);
                fieldInfo.Name = name;
                fieldInfo.Size = size;
                fieldInfo.Type = type;

                uniforms[i] = fieldInfo;
            }

            return uniforms;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetUniformLocation(string uniform)
        {
            if (_uniformToLocation.TryGetValue(uniform, out int location) == false)
            {
                location = _gl.GetUniformLocation(Program, uniform);
                _uniformToLocation.Add(uniform, location);

                if (location == -1)
                {
                    Debug.Print($"The uniform '{uniform}' does not exist in the shader '{Name}'!");
                }
            }
            
            return location;
        }

        private uint CreateProgram(string name, params (ShaderType Type, string source)[] shaderPaths)
        {
            _gl.CreateProgram(name, out var program);

            Span<uint> shaders = stackalloc uint[shaderPaths.Length];
            for (int i = 0; i < shaderPaths.Length; i++)
            {
                shaders[i] = CompileShader(name, shaderPaths[i].Type, shaderPaths[i].source);
            }

            foreach (var shader in shaders)
                _gl.AttachShader(program, shader);

            _gl.LinkProgram(program);

            _gl.GetProgram(program, GLEnum.LinkStatus, out var success);
            if (success == 0)
            {
                string info = _gl.GetProgramInfoLog(program);
                Debug.WriteLine($"GL.LinkProgram had info log [{name}]:\n{info}");
            }

            foreach (var shader in shaders)
            {
                _gl.DetachShader(program, shader);
                _gl.DeleteShader(shader);
            }

            _initialized = true;

            return program;
        }

        private uint CompileShader(string name, ShaderType type, string source)
        {
            _gl.CreateShader(type, name, out var shader);
            _gl.ShaderSource(shader, source);
            _gl.CompileShader(shader);

            _gl.GetShader(shader, ShaderParameterName.CompileStatus, out var success);
            if (success == 0)
            {
                string info = _gl.GetShaderInfoLog(shader);
                Debug.WriteLine($"GL.CompileShader for shader '{Name}' [{type}] had info log:\n{info}");
            }
            
            return shader;
        }
    }
}
