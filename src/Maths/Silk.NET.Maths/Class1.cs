namespace Silk.NET.Maths
{
    public struct Vector2<T> where T:unmanaged { public T X; public T Y;}
    public struct Vector3<T> where T:unmanaged { public T X; public T Y; public T Z;}
    public struct Vector4<T> where T:unmanaged { public T X; public T Y; public T Z; public T W;}
    public struct Quaternion<T> where T:unmanaged { public T X; public T Y; public T Z; public T W;}
    public struct Matrix2X2<T> where T:unmanaged { public Vector2<T> Row0; public Vector2<T> Row1; }
    public struct Matrix3X3<T> where T:unmanaged { public Vector3<T> Row0; public Vector3<T> Row1; public Vector3<T> Row2; }
    public struct Matrix4X4<T> where T:unmanaged { public Vector4<T> Row0; public Vector4<T> Row1; public Vector4<T> Row2; public Vector4<T> Row3; }
    public struct Matrix3X2<T> where T:unmanaged { public Vector2<T> Row0; public Vector2<T> Row1; public Vector2<T> Row2; }
    public struct Matrix4X2<T> where T:unmanaged { public Vector2<T> Row0; public Vector2<T> Row1; public Vector2<T> Row2; public Vector2<T> Row3; }
    public struct Matrix2X3<T> where T:unmanaged { public Vector3<T> Row0; public Vector3<T> Row1; }
    public struct Matrix4X3<T> where T:unmanaged { public Vector3<T> Row0; public Vector3<T> Row1; public Vector3<T> Row2; public Vector3<T> Row3; }
    public struct Matrix2X4<T> where T:unmanaged { public Vector4<T> Row0; public Vector4<T> Row1; }
    public struct Matrix3X4<T> where T:unmanaged { public Vector4<T> Row0; public Vector4<T> Row1; public Vector4<T> Row2; }
}
