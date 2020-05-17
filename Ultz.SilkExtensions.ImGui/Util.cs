using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Silk.NET.OpenGL;

namespace Ultz.SilkExtensions.ImGui
{
    static class Util
    {
        [Pure]
        public static float Clamp(float value, float min, float max)
        {
            return value < min ? min : value > max ? max : value;
        }

        [Conditional("DEBUG")]
        public static void CheckGlError(this GL gl, string title)
        {
            var error = gl.GetError();
            if (error != GLEnum.NoError)
            {
                Debug.Print($"{title}: {error}");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LabelObject(this GL gl, ObjectIdentifier objLabelIdent, uint glObject, string name)
        {
            gl.ObjectLabel(objLabelIdent, glObject, (uint)name.Length, name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void CreateTexture(this GL gl, TextureTarget target, string name, out uint texture)
        {
            texture = 0u;
            gl.CreateTextures(target, 1, (uint*)Unsafe.AsPointer(ref texture));
            gl.LabelObject(ObjectIdentifier.Texture, texture, $"Texture: {name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateProgram(this GL gl, string name, out uint program)
        {
            program = gl.CreateProgram();
            gl.LabelObject(ObjectIdentifier.Program, program, $"Program: {name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateShader(this GL gl, ShaderType type, string name, out uint shader)
        {
            shader = gl.CreateShader(type);
            gl.LabelObject(ObjectIdentifier.Shader, shader, $"Shader: {type}: {name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateBuffer(this GL gl, string name, out uint buffer)
        {
            buffer = gl.CreateBuffer();
            gl.LabelObject(ObjectIdentifier.Buffer, buffer, $"Buffer: {name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateVertexBuffer(this GL gl, string name, out uint buffer) => gl.CreateBuffer($"VBO: {name}", out buffer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateElementBuffer(this GL gl, string name, out uint buffer) => gl.CreateBuffer($"EBO: {name}", out buffer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateVertexArray(this GL gl, string name, out uint vao)
        {
            vao = gl.CreateVertexArray();
        }
    }
}
