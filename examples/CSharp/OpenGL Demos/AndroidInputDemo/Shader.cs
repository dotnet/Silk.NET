// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using Silk.NET.OpenGL;

namespace AndroidInputDemo
{
    public class Shader : IDisposable
    {
        //Our handle and the GL instance this class will use, these are private because they have no reason to be public.
        //Most of the time you would want to abstract items to make things like this invisible.
        private uint _handle;
        private GL _gl;

        public Shader(GL gl, string vertexPath, string fragmentPath)
        {
            _gl = gl;

            //Load the individual shaders.
            uint vertex = LoadShader(ShaderType.VertexShader, vertexPath);
            uint fragment = LoadShader(ShaderType.FragmentShader, fragmentPath);
            //Create the shader program.
            _handle = _gl.CreateProgram();
            //Attach the individual shaders.
            _gl.AttachShader(_handle, vertex);
            _gl.AttachShader(_handle, fragment);
            _gl.LinkProgram(_handle);
            //Check for linking errors.
            _gl.GetProgram(_handle, GLEnum.LinkStatus, out var status);
            if (status == 0)
            {
                throw new Exception($"Program failed to link with error: {_gl.GetProgramInfoLog(_handle)}");
            }
            //Detach and delete the shaders
            _gl.DetachShader(_handle, vertex);
            _gl.DetachShader(_handle, fragment);
            _gl.DeleteShader(vertex);
            _gl.DeleteShader(fragment);
        }

        public void Use()
        {
            //Using the program
            _gl.UseProgram(_handle);
        }

        //Uniforms are properties that applies to the entire geometry
        public void SetUniform(string name, int value)
        {
            //Setting a uniform on a shader using a name.
            int location = _gl.GetUniformLocation(_handle, name);
            if (location == -1) //If GetUniformLocation returns -1 the uniform is not found.
            {
                throw new Exception($"{name} uniform not found on shader.");
            }
            _gl.Uniform1(location, value);
        }

        public void SetUniform(string name, float value)
        {
            int location = _gl.GetUniformLocation(_handle, name);
            if (location == -1)
            {
                throw new Exception($"{name} uniform not found on shader.");
            }
            _gl.Uniform1(location, value);
        }

        public unsafe void SetUniform(string name, Matrix4x4 value)
        {
            //A new overload has been created for setting a uniform so we can use the transform in our shader.
            int location = _gl.GetUniformLocation(_handle, name);
            if (location == -1)
            {
                throw new Exception($"{name} uniform not found on shader.");
            }
            Use();
            _gl.UniformMatrix4(location, 1, false, (float*) &value);
        }

        public void Dispose()
        {
            //Remember to delete the program when we are done.
            _gl.DeleteProgram(_handle);
        }

        private uint LoadShader(ShaderType type, string path)
        {
            string src = FileManager.LoadString(path);
            uint handle = _gl.CreateShader(type);
            _gl.ShaderSource(handle, src);
            _gl.CompileShader(handle);
            string infoLog = _gl.GetShaderInfoLog(handle);
            if (!string.IsNullOrWhiteSpace(infoLog))
            {
                throw new Exception($"Error compiling shader of type {type}, failed with error {infoLog}");
            }

            return handle;
        }
    }
}
