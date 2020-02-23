using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace Tutorial
{
    public class Camera
    {
        // Those vectors are directions pointing outwards from the camera to define how it rotated
        private Vector3 _front = -Vector3.UnitZ;

        private Vector3 _up = Vector3.UnitY;

        private Vector3 _right = Vector3.UnitX;

        // Rotation around the X axis (radians)
        private float _pitch;

        // Rotation around the Y axis (radians)
        private float _yaw = (float) -Math.PI / 2f; // Without this you would be started rotated 90 degrees right

        // The field of view of the camera (radians)
        private float _fov = (float) Math.PI / 2f;

        public Camera(Vector3 position, float aspectRatio)
        {
            Position = position;
            AspectRatio = aspectRatio;
        }

        // The position of the camera
        public Vector3 Position { get; set; }

        // This is simply the aspect ratio of the viewport, used for the projection matrix
        public float AspectRatio { private get; set; }

        public Vector3 Front => _front;

        public Vector3 Up => _up;

        public Vector3 Right => _right;

        // We convert from degrees to radians as soon as the property is set to improve performance
        public float Pitch
        {
            get => _pitch;
            set
            {
                // We clamp the pitch value between -89 and 89 to prevent the camera from going upside down, and a bunch
                // of weird "bugs" when you are using euler angles for rotation.
                // If you want to read more about this you can try researching a topic called gimbal lock
                var angle = (float) Math.Clamp(value, -Math.PI / 1.9f, Math.PI / 1.9f);
                _pitch = angle;
                UpdateVectors();
            }
        }

        // We convert from degrees to radians as soon as the property is set to improve performance
        public float Yaw
        {
            get => _yaw;
            set
            {
                _yaw = value;
                UpdateVectors();
            }
        }

        // The field of view (FOV) is the vertical angle of the camera view, this has been discussed more in depth in a
        // previous tutorial, but in this tutorial you have also learned how we can use this to simulate a zoom feature.
        // We convert from degrees to radians as soon as the property is set to improve performance
        public float Fov
        {
            get => _fov;
            set
            {
                var angle = (float) Math.Clamp(value, 0.1f, Math.PI / 4);
                _fov = angle;
            }
        }

        // Get the view matrix using the amazing LookAt function described more in depth on the web tutorials
        public Matrix4x4 GetViewMatrix()
        {
            return Matrix4x4.CreateLookAt(Position, Position + _front, _up);
        }

        // Get the projection matrix using the same method we have used up until this point
        public Matrix4x4 GetProjectionMatrix()
        {
            return Matrix4x4.CreatePerspectiveFieldOfView(_fov, AspectRatio, 0.01f, 100f);
        }

        // This function is going to update the direction vertices using some of the math learned in the web tutorials
        private void UpdateVectors()
        {
            // First the front matrix is calculated using some basic trigonometry
            _front.X = (float) Math.Cos(_pitch) * (float) Math.Cos(_yaw);
            _front.Y = (float) Math.Sin(_pitch);
            _front.Z = (float) Math.Cos(_pitch) * (float) Math.Sin(_yaw);

            // We need to make sure the vectors are all normalized, as otherwise we would get some funky results
            _front = Vector3.Normalize(_front);

            // Calculate both the right and the up vector using cross product
            // Note that we are calculating the right from the global up, this behaviour might
            // not be what you need for all cameras so keep this in mind if you do not want a FPS camera
            _right = Vector3.Normalize(Vector3.Cross(_front, Vector3.UnitY));
            _up = Vector3.Normalize(Vector3.Cross(_right, _front));
        }
    }
}
