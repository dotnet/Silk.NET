using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Silk.NET.OpenGL;

namespace SampleBase
{
    public class Shader
    {
        public readonly uint Handle;

        private readonly Dictionary<string, int> _uniformLocations;
        private readonly GL _gl;

        public Shader(string vertPath, string fragPath, GL gl, Type type)
        {
            _gl = gl;
            var shaderSource = LoadEmbeddedResource(vertPath, type);

            var vertexShader = _gl.CreateShader(GLEnum.VertexShader);

            _gl.ShaderSource(vertexShader, shaderSource);

            CompileShader(vertexShader);

            shaderSource = LoadEmbeddedResource(fragPath, type);
            var fragmentShader = _gl.CreateShader(GLEnum.FragmentShader);
            _gl.ShaderSource(fragmentShader, shaderSource);
            CompileShader(fragmentShader);

            Handle = _gl.CreateProgram();

            _gl.AttachShader(Handle, vertexShader);
            _gl.AttachShader(Handle, fragmentShader);

            LinkProgram(Handle);

            _gl.DetachShader(Handle, vertexShader);
            _gl.DetachShader(Handle, fragmentShader);
            _gl.DeleteShader(fragmentShader);
            _gl.DeleteShader(vertexShader);

            _gl.GetProgram(Handle, GLEnum.ActiveUniforms, out var numberOfUniforms);

            _uniformLocations = new Dictionary<string, int>();

            for (var i = 0u; i < numberOfUniforms; i++)
            {
                var key = _gl.GetActiveUniform(Handle, i, out _, out _);

                var location = _gl.GetUniformLocation(Handle, key);

                _uniformLocations.Add(key, location);
            }
        }

        public void SetUniform(string name, int value)
        {
            int location = _gl.GetUniformLocation(Handle, name);
            if (location == -1)
            {
                throw new Exception($"{name} uniform not found on shader.");
            }
            _gl.Uniform1(location, value);
        }

        public unsafe void SetUniform(string name, Matrix4x4 value)
        {
            //A new overload has been created for setting a uniform so we can use the transform in our shader.
            int location = _gl.GetUniformLocation(Handle, name);
            if (location == -1)
            {
                throw new Exception($"{name} uniform not found on shader.");
            }
            _gl.UniformMatrix4(location, 1, false, (float*) &value);
        }

        public void SetUniform(string name, float value)
        {
            int location = _gl.GetUniformLocation(Handle, name);
            if (location == -1)
            {
                throw new Exception($"{name} uniform not found on shader.");
            }
            _gl.Uniform1(location, value);
        }

        public void SetUniform(string name, Vector3 value)
        {
            int location = _gl.GetUniformLocation(Handle, name);
            if (location == -1)
            {
                throw new Exception($"{name} uniform not found on shader.");
            }
            _gl.Uniform3(location, value.X, value.Y, value.Z);
        }

        private string LoadEmbeddedResource(string path, Type type)
        {
            using (var s = type.Assembly.GetManifestResourceStream(path))
            {
                using (var sr = new StreamReader(s))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        private void CompileShader(uint shader)
        {
            _gl.CompileShader(shader);

            _gl.GetShader(shader, GLEnum.CompileStatus, out var code);
            if (code != (int) GLEnum.True)
            {
                throw new Exception
                    ($"Error occurred whilst compiling Shader({shader}): \n" + _gl.GetShaderInfoLog(shader));
            }
        }

        private void LinkProgram(uint program)
        {
            _gl.LinkProgram(program);

            _gl.GetProgram(program, GLEnum.LinkStatus, out var code);
            if (code != (int) GLEnum.True)
            {
                throw new Exception($"Error occurred whilst linking Program({program}): " + _gl.GetProgramInfoLog(program));
            }
        }

        public void Use()
        {
            _gl.UseProgram(Handle);
        }

        public int GetAttribLocation(string attribName)
        {
            return _gl.GetAttribLocation(Handle, attribName);
        }

        public void SetInt(string name, int data)
        {
            _gl.UseProgram(Handle);
            _gl.Uniform1(_uniformLocations[name], data);
        }

        public void SetFloat(string name, float data)
        {
            _gl.UseProgram(Handle);
            _gl.Uniform1(_uniformLocations[name], data);
        }

        public unsafe void SetMatrix4(string name, Matrix4x4 data)
        {
            _gl.UseProgram(Handle);
            _gl.UniformMatrix4(_uniformLocations[name], Handle, true, (float*) &data);
        }

        public void SetVector3(string name, Vector3 data)
        {
            _gl.UseProgram(Handle);
            _gl.Uniform3(_uniformLocations[name], data);
        }
    }
}
