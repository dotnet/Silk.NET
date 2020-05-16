using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Silk.NET.OpenGL;

namespace Ultz.SilkExtensions.ImGui.OpenGL
{
    static class Util
    {
        [Pure]
        public static float Clamp(float value, float min, float max)
        {
            return value < min ? min : value > max ? max : value;
        }

        [Conditional("DEBUG")]
        public static void CheckGLError(this GL GL, string title)
        {
            var error = GL.GetError();
            if (error != GLEnum.NoError)
            {
                Debug.Print($"{title}: {error}");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LabelObject(this GL GL, ObjectIdentifier objLabelIdent, uint glObject, string name)
        {
            GL.ObjectLabel(objLabelIdent, glObject, (uint)name.Length, name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void CreateTexture(this GL GL, TextureTarget target, string Name, out uint Texture)
        {
            Texture = 0u;
            GL.CreateTextures(target, 1, (uint*)Unsafe.AsPointer(ref Texture));
            GL.LabelObject(ObjectIdentifier.Texture, Texture, $"Texture: {Name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateProgram(this GL GL, string Name, out uint Program)
        {
            Program = GL.CreateProgram();
            GL.LabelObject(ObjectIdentifier.Program, Program, $"Program: {Name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateShader(this GL GL, ShaderType type, string Name, out uint Shader)
        {
            Shader = GL.CreateShader(type);
            GL.LabelObject(ObjectIdentifier.Shader, Shader, $"Shader: {type}: {Name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateBuffer(this GL GL, string Name, out uint Buffer)
        {
            Buffer = GL.CreateBuffer();
            GL.LabelObject(ObjectIdentifier.Buffer, Buffer, $"Buffer: {Name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateVertexBuffer(this GL GL, string Name, out uint Buffer) => GL.CreateBuffer($"VBO: {Name}", out Buffer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateElementBuffer(this GL GL, string Name, out uint Buffer) => GL.CreateBuffer($"EBO: {Name}", out Buffer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateVertexArray(this GL GL, string Name, out uint VAO)
        {
            VAO = GL.CreateVertexArray();
        }
    }
}
