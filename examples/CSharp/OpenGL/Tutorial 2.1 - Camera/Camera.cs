using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace Tutorial
{
    public interface ICameraLens
    {
        Matrix4x4 ViewMatrix { get; }
    }

    public class PerspectiveLens : ICameraLens
    {
        public PerspectiveLens(Size size)
        {
            ViewMatrix = Matrix4x4.CreatePerspective(size.Width, size.Height, 0.001f, 100f);
        }
        
        public Matrix4x4 ViewMatrix { get; }
    }
    
    public class Camera
    {
        private ICameraLens Lens { get; }
        
        private Transform Transform { get; }
        
        public Camera(Transform transform, ICameraLens lens)
        {
            Transform = transform;
            Lens = lens;
        }
    }
}
