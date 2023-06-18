using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.OpenGL;

namespace SampleBase
{
    public class Shader
    {
        public readonly uint Handle;

        private readonly Dictionary<string, int> _uniformLocations;
        private readonly GL _gl;

        public unsafe Shader(string vertPath, string fragPath, GL gl, Type type)
        {
            _gl = gl;
            var shaderSource = LoadEmbeddedResource(vertPath, type);

            var vertexShader = _gl.CreateShader(GLEnum.VertexShader);

            fixed (byte* src = Encoding.UTF8.GetBytes(shaderSource))
            {
                var len = shaderSource.Length;
                _gl.ShaderSource(vertexShader, 1, &src, &len);
            }

            CompileShader(vertexShader);

            shaderSource = LoadEmbeddedResource(fragPath, type);
            var fragmentShader = _gl.CreateShader(GLEnum.FragmentShader);

            fixed (byte* src = Encoding.UTF8.GetBytes(shaderSource))
            {
                var len = shaderSource.Length;
                _gl.ShaderSource(fragmentShader, 1, &src, &len);
            }
            CompileShader(fragmentShader);

            Handle = _gl.CreateProgram();

            _gl.AttachShader(Handle, vertexShader);
            _gl.AttachShader(Handle, fragmentShader);

            LinkProgram(Handle);

            _gl.DetachShader(Handle, vertexShader);
            _gl.DetachShader(Handle, fragmentShader);
            _gl.DeleteShader(fragmentShader);
            _gl.DeleteShader(vertexShader);

            int numberOfUniforms;
            _gl.GetProgram(Handle, GLEnum.ActiveUniforms, &numberOfUniforms);

            _uniformLocations = new Dictionary<string, int>();
            
            for (var i = 0u; i < numberOfUniforms; i++)
            {
                string key;
                uint length;
                _gl.GetProgram(Handle, GLEnum.ActiveUniformMaxLength, (int*) &length);

                int location;
                fixed (byte* kPtr = new byte[length == 0 ? 1 : length])
                {
                    int size;
                    GLEnum uType;
                    _gl.GetActiveUniform
                    (
                        Handle, i, length == 0 ? 1 : length, &length, &size, &uType, kPtr
                    );
                    key = SilkMarshal.PtrToString((IntPtr) kPtr);
                    location = _gl.GetUniformLocation(Handle, kPtr);
                }

                _uniformLocations.Add(key, location);
            }
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

        private unsafe void CompileShader(uint shader)
        {
            _gl.CompileShader(shader);

            int code;
            _gl.GetShader(shader, GLEnum.CompileStatus, &code);
            if (code != (int) GLEnum.True)
            {
                uint length;
                _gl.GetShader(shader, GLEnum.InfoLogLength, (int*) &length);
                string info;
                fixed (byte* infoPtr = new byte[length == 0 ? 1 : length * 2])
                {
                    _gl.GetShaderInfoLog(shader, length == 0 ? 1 : length * 2, &length, infoPtr);
                    info = SilkMarshal.PtrToString((IntPtr) infoPtr);
                }
                throw new Exception
                    ($"Error occurred whilst compiling Shader({shader}): \n" + info);
            }
        }

        private unsafe void LinkProgram(uint program)
        {
            _gl.LinkProgram(program);
            
            int code;
            _gl.GetProgram(program, GLEnum.LinkStatus, &code);
            if (code != (int) GLEnum.True)
            {
                uint length;
                _gl.GetProgram(program, GLEnum.InfoLogLength, (int*) &length);
                string info;
                fixed (byte* infoPtr = new byte[length == 0 ? 1 : length * 2])
                {
                    _gl.GetProgramInfoLog(program, length == 0 ? 1 : length * 2, &length, infoPtr);
                    info = SilkMarshal.PtrToString((IntPtr) infoPtr);
                }
                throw new Exception($"Error occurred whilst linking Program({program}): " + info);
            }
        }

        public void Use()
        {
            _gl.UseProgram(Handle);
        }

        public unsafe int GetAttribLocation(string attribName)
        {
            fixed (byte* an = Encoding.UTF8.GetBytes(attribName))
            {
                return _gl.GetAttribLocation(Handle, an);
            }
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

        public unsafe void SetVector3(string name, Vector3 data)
        {
            _gl.UseProgram(Handle);
            _gl.Uniform3(_uniformLocations[name], 1, &data.X);
        }
    }
}
