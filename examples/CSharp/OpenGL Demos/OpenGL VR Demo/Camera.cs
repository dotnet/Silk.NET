using System;
using System.Numerics;
using OpenGL_VR_Demo.OpenXR;

namespace OpenGL_VR_Demo
{
    public class Camera
    {
        private Renderer _renderer;
    
        public Vector3 Position { get; set; }
        public Camera(Vector3 position, Renderer renderer)
        {
            Position = position;
            _renderer = renderer;
        }

        public Matrix4x4 GetViewMatrix(int eye) => _renderer.GetViewMatrix(eye, Position);
        public Matrix4x4 GetProjectionMatrix(int eye) => _renderer.GetProjectionMatrix(eye);
    }
}