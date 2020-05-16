using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Silk.NET.OpenGL;

namespace Ultz.SilkExtensions.ImGui.OpenGL
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
        private readonly Dictionary<string, int> UniformToLocation = new Dictionary<string, int>();
        private bool Initialized = false;
        private GL GL;
        private (ShaderType Type, string Path)[] Files;

        public Shader(GL gl, string name, string vertexShader, string fragmentShader)
        {
            GL = gl;
            Name = name;
            Files = new[]{
                (ShaderType.VertexShader, vertexShader),
                (ShaderType.FragmentShader, fragmentShader),
            };
            Program = CreateProgram(name, Files);
        }
        public void UseShader()
        {
            GL.UseProgram(Program);
        }

        public void Dispose()
        {
            if (Initialized)
            {
                GL.DeleteProgram(Program);
                Initialized = false;
            }
        }

        public UniformFieldInfo[] GetUniforms()
        {
            GL.GetProgram(Program, GLEnum.ActiveUniforms, out var UnifromCount);

            UniformFieldInfo[] Uniforms = new UniformFieldInfo[UnifromCount];

            for (int i = 0; i < UnifromCount; i++)
            {
                string Name = GL.GetActiveUniform(Program, (uint) i, out int Size, out UniformType Type);

                UniformFieldInfo FieldInfo;
                FieldInfo.Location = GetUniformLocation(Name);
                FieldInfo.Name = Name;
                FieldInfo.Size = Size;
                FieldInfo.Type = Type;

                Uniforms[i] = FieldInfo;
            }

            return Uniforms;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetUniformLocation(string uniform)
        {
            if (UniformToLocation.TryGetValue(uniform, out int location) == false)
            {
                location = GL.GetUniformLocation(Program, uniform);
                UniformToLocation.Add(uniform, location);

                if (location == -1)
                {
                    Debug.Print($"The uniform '{uniform}' does not exist in the shader '{Name}'!");
                }
            }
            
            return location;
        }

        private uint CreateProgram(string name, params (ShaderType Type, string source)[] shaderPaths)
        {
            GL.CreateProgram(name, out var Program);

            Span<uint> Shaders = stackalloc uint[shaderPaths.Length];
            for (int i = 0; i < shaderPaths.Length; i++)
            {
                Shaders[i] = CompileShader(name, shaderPaths[i].Type, shaderPaths[i].source);
            }

            foreach (var shader in Shaders)
                GL.AttachShader(Program, shader);

            GL.LinkProgram(Program);

            GL.GetProgram(Program, GLEnum.LinkStatus, out var Success);
            if (Success == 0)
            {
                string Info = GL.GetProgramInfoLog(Program);
                Debug.WriteLine($"GL.LinkProgram had info log [{name}]:\n{Info}");
            }

            foreach (var Shader in Shaders)
            {
                GL.DetachShader(Program, Shader);
                GL.DeleteShader(Shader);
            }

            Initialized = true;

            return Program;
        }

        private uint CompileShader(string name, ShaderType type, string source)
        {
            GL.CreateShader(type, name, out var Shader);
            GL.ShaderSource(Shader, source);
            GL.CompileShader(Shader);

            GL.GetShader(Shader, ShaderParameterName.CompileStatus, out var success);
            if (success == 0)
            {
                string Info = GL.GetShaderInfoLog(Shader);
                Debug.WriteLine($"GL.CompileShader for shader '{Name}' [{type}] had info log:\n{Info}");
            }
            
            return Shader;
        }
    }
}
