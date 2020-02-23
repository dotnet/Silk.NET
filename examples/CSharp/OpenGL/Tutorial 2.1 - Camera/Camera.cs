using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace Tutorial
{
    public class Camera
    {
        private Vector3 _front = -Vector3.UnitZ;

        private Vector3 _up = Vector3.UnitY;

        private Vector3 _right = Vector3.UnitX;

        private float _pitch;

        private float _yaw = -(float)(Math.PI / 2f);

        private float _fov = (float)(Math.PI / 2f);

        public Camera(Vector3 position, float aspectRatio)
        {
            Position = position;
            AspectRatio = aspectRatio;
        }

        public Vector3 Position { get; set; }

        public float AspectRatio { private get; set; }

        public Vector3 Front => _front;

        public Vector3 Up => _up;

        public Vector3 Right => _right;

        public float Pitch
        {
            get => ToDeg(_pitch);
            set
            {
                var angle = Math.Clamp(value, -89f, 89f);
                _pitch = ToRad(angle);
                UpdateVectors();
            }
        }

        public float Yaw
        {
            get => ToDeg(_yaw);
            set
            {
                _yaw = ToRad(value);
                UpdateVectors();
            }
        }

        public float Fov
        {
            get => ToDeg(_fov);
            set
            {
                var angle = Math.Clamp(value, 1f, 45f);
                _fov = ToRad(angle);
            }
        }

        public Matrix4x4 GetViewMatrix()
        {
            return Matrix4x4.CreateLookAt(Position, Position + _front, _up);
        }

        public Matrix4x4 GetProjectionMatrix()
        {
            return Matrix4x4.CreatePerspectiveFieldOfView(_fov, AspectRatio, 0.01f, 100f);
        }

        private float ToRad(float f) => f * (float)(Math.PI / 180);
        private float ToDeg(float f) => f * (float)(180 / Math.PI);

        private void UpdateVectors()
        {
            _front.X = (float)Math.Cos(_pitch) * (float)Math.Cos(_yaw);
            _front.Y = (float)Math.Sin(_pitch);
            _front.Z = (float)Math.Cos(_pitch) * (float)Math.Sin(_yaw);
            
            _front = Vector3.Normalize(_front);
            _right = Vector3.Normalize(Vector3.Cross(_front, Vector3.UnitY));
            _up = Vector3.Normalize(Vector3.Cross(_right, _front));
        }
    }
}
