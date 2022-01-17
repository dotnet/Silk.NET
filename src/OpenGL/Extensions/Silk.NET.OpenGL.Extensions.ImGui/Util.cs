using System.Diagnostics;
using System.Diagnostics.Contracts;
#if GLES
using Silk.NET.OpenGLES;
#elif GL
using Silk.NET.OpenGL;
#endif

namespace Silk.NET.OpenGL.Extensions.ImGui
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
    }
}
