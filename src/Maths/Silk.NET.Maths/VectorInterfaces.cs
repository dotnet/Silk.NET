#region

using System;
#if BTEC_INTRINSICS
using System.Numerics;
#endif
#if INTRINSICS
using System.Runtime.Intrinsics;

#endif

#endregion

namespace Silk.NET.Maths
{
    /*
     * These interfaces are only used for validation purposes
     * Do not use them as variable/parameter anywhere
     */

    internal interface IVector2<T, TVec> : IFormattable, IEquatable<TVec>
        where T : unmanaged, IFormattable where TVec : IVector2<T, TVec>
    {
        public T this[int index] { get; }
        public T Length { get; }
        public T LengthSquared { get; }
        public T X { get; }
        public T Y { get; }
        public Vector2<T> XX { get; }
        public Vector2<T> XY { get; }
        public Vector2<T> YX { get; }
        public Vector2<T> YY { get; }
        public TVec WithX(T x);
        public TVec WithY(T y);
        public TVec Normalized();
        public string ToString();
        public string ToString(string? format);
#if BTEC_INTRINSICS
        Vector<T> AsVector();
#endif

#if INTRINSICS
        Vector64<T> AsVector64();
        Vector128<T> AsVector128();
        Vector256<T> AsVector256();
#endif
    }

    internal interface IVector3<T, TVec> : IVector2<T, TVec>
        where T : unmanaged, IFormattable where TVec : IVector3<T, TVec>
    {
        public T Z { get; }
        public TVec WithZ(T z);

        #region Swizzle

        public Vector3<T> XXX { get; }
        public Vector3<T> XXY { get; }
        public Vector3<T> XXZ { get; }
        public Vector3<T> XYX { get; }
        public Vector3<T> XYY { get; }
        public Vector3<T> XYZ { get; }
        public Vector3<T> XZX { get; }
        public Vector3<T> XZY { get; }
        public Vector3<T> XZZ { get; }
        public Vector3<T> YXX { get; }
        public Vector3<T> YXY { get; }
        public Vector3<T> YXZ { get; }
        public Vector3<T> YYX { get; }
        public Vector3<T> YYY { get; }
        public Vector3<T> YYZ { get; }
        public Vector3<T> YZX { get; }
        public Vector3<T> YZY { get; }
        public Vector3<T> YZZ { get; }
        public Vector3<T> ZXX { get; }
        public Vector3<T> ZXY { get; }
        public Vector3<T> ZXZ { get; }
        public Vector3<T> ZYX { get; }
        public Vector3<T> ZYY { get; }
        public Vector3<T> ZYZ { get; }
        public Vector3<T> ZZX { get; }
        public Vector3<T> ZZY { get; }
        public Vector3<T> ZZZ { get; }

        #endregion
    }

    internal interface IVector4<T, TVec> : IVector3<T, TVec>
        where T : unmanaged, IFormattable where TVec : IVector4<T, TVec>
    {
        T W { get; }
        Vector4<T> WithW(T w);

        #region Swizzle

        Vector4<T> XXXX { get; }
        Vector4<T> XXXY { get; }
        Vector4<T> XXXZ { get; }
        Vector4<T> XXXW { get; }
        Vector4<T> XXYX { get; }
        Vector4<T> XXYY { get; }
        Vector4<T> XXYZ { get; }
        Vector4<T> XXYW { get; }
        Vector4<T> XXZX { get; }
        Vector4<T> XXZY { get; }
        Vector4<T> XXZZ { get; }
        Vector4<T> XXZW { get; }
        Vector4<T> XXWX { get; }
        Vector4<T> XXWY { get; }
        Vector4<T> XXWZ { get; }
        Vector4<T> XXWW { get; }
        Vector4<T> XYXX { get; }
        Vector4<T> XYXY { get; }
        Vector4<T> XYXZ { get; }
        Vector4<T> XYXW { get; }
        Vector4<T> XYYX { get; }
        Vector4<T> XYYY { get; }
        Vector4<T> XYYZ { get; }
        Vector4<T> XYYW { get; }
        Vector4<T> XYZX { get; }
        Vector4<T> XYZY { get; }
        Vector4<T> XYZZ { get; }
        Vector4<T> XYZW { get; }
        Vector4<T> XYWX { get; }
        Vector4<T> XYWY { get; }
        Vector4<T> XYWZ { get; }
        Vector4<T> XYWW { get; }
        Vector4<T> XZXX { get; }
        Vector4<T> XZXY { get; }
        Vector4<T> XZXZ { get; }
        Vector4<T> XZXW { get; }
        Vector4<T> XZYX { get; }
        Vector4<T> XZYY { get; }
        Vector4<T> XZYZ { get; }
        Vector4<T> XZYW { get; }
        Vector4<T> XZZX { get; }
        Vector4<T> XZZY { get; }
        Vector4<T> XZZZ { get; }
        Vector4<T> XZZW { get; }
        Vector4<T> XZWX { get; }
        Vector4<T> XZWY { get; }
        Vector4<T> XZWZ { get; }
        Vector4<T> XZWW { get; }
        Vector4<T> XWXX { get; }
        Vector4<T> XWXY { get; }
        Vector4<T> XWXZ { get; }
        Vector4<T> XWXW { get; }
        Vector4<T> XWYX { get; }
        Vector4<T> XWYY { get; }
        Vector4<T> XWYZ { get; }
        Vector4<T> XWYW { get; }
        Vector4<T> XWZX { get; }
        Vector4<T> XWZY { get; }
        Vector4<T> XWZZ { get; }
        Vector4<T> XWZW { get; }
        Vector4<T> XWWX { get; }
        Vector4<T> XWWY { get; }
        Vector4<T> XWWZ { get; }
        Vector4<T> XWWW { get; }
        Vector4<T> YXXX { get; }
        Vector4<T> YXXY { get; }
        Vector4<T> YXXZ { get; }
        Vector4<T> YXXW { get; }
        Vector4<T> YXYX { get; }
        Vector4<T> YXYY { get; }
        Vector4<T> YXYZ { get; }
        Vector4<T> YXYW { get; }
        Vector4<T> YXZX { get; }
        Vector4<T> YXZY { get; }
        Vector4<T> YXZZ { get; }
        Vector4<T> YXZW { get; }
        Vector4<T> YXWX { get; }
        Vector4<T> YXWY { get; }
        Vector4<T> YXWZ { get; }
        Vector4<T> YXWW { get; }
        Vector4<T> YYXX { get; }
        Vector4<T> YYXY { get; }
        Vector4<T> YYXZ { get; }
        Vector4<T> YYXW { get; }
        Vector4<T> YYYX { get; }
        Vector4<T> YYYY { get; }
        Vector4<T> YYYZ { get; }
        Vector4<T> YYYW { get; }
        Vector4<T> YYZX { get; }
        Vector4<T> YYZY { get; }
        Vector4<T> YYZZ { get; }
        Vector4<T> YYZW { get; }
        Vector4<T> YYWX { get; }
        Vector4<T> YYWY { get; }
        Vector4<T> YYWZ { get; }
        Vector4<T> YYWW { get; }
        Vector4<T> YZXX { get; }
        Vector4<T> YZXY { get; }
        Vector4<T> YZXZ { get; }
        Vector4<T> YZXW { get; }
        Vector4<T> YZYX { get; }
        Vector4<T> YZYY { get; }
        Vector4<T> YZYZ { get; }
        Vector4<T> YZYW { get; }
        Vector4<T> YZZX { get; }
        Vector4<T> YZZY { get; }
        Vector4<T> YZZZ { get; }
        Vector4<T> YZZW { get; }
        Vector4<T> YZWX { get; }
        Vector4<T> YZWY { get; }
        Vector4<T> YZWZ { get; }
        Vector4<T> YZWW { get; }
        Vector4<T> YWXX { get; }
        Vector4<T> YWXY { get; }
        Vector4<T> YWXZ { get; }
        Vector4<T> YWXW { get; }
        Vector4<T> YWYX { get; }
        Vector4<T> YWYY { get; }
        Vector4<T> YWYZ { get; }
        Vector4<T> YWYW { get; }
        Vector4<T> YWZX { get; }
        Vector4<T> YWZY { get; }
        Vector4<T> YWZZ { get; }
        Vector4<T> YWZW { get; }
        Vector4<T> YWWX { get; }
        Vector4<T> YWWY { get; }
        Vector4<T> YWWZ { get; }
        Vector4<T> YWWW { get; }
        Vector4<T> ZXXX { get; }
        Vector4<T> ZXXY { get; }
        Vector4<T> ZXXZ { get; }
        Vector4<T> ZXXW { get; }
        Vector4<T> ZXYX { get; }
        Vector4<T> ZXYY { get; }
        Vector4<T> ZXYZ { get; }
        Vector4<T> ZXYW { get; }
        Vector4<T> ZXZX { get; }
        Vector4<T> ZXZY { get; }
        Vector4<T> ZXZZ { get; }
        Vector4<T> ZXZW { get; }
        Vector4<T> ZXWX { get; }
        Vector4<T> ZXWY { get; }
        Vector4<T> ZXWZ { get; }
        Vector4<T> ZXWW { get; }
        Vector4<T> ZYXX { get; }
        Vector4<T> ZYXY { get; }
        Vector4<T> ZYXZ { get; }
        Vector4<T> ZYXW { get; }
        Vector4<T> ZYYX { get; }
        Vector4<T> ZYYY { get; }
        Vector4<T> ZYYZ { get; }
        Vector4<T> ZYYW { get; }
        Vector4<T> ZYZX { get; }
        Vector4<T> ZYZY { get; }
        Vector4<T> ZYZZ { get; }
        Vector4<T> ZYZW { get; }
        Vector4<T> ZYWX { get; }
        Vector4<T> ZYWY { get; }
        Vector4<T> ZYWZ { get; }
        Vector4<T> ZYWW { get; }
        Vector4<T> ZZXX { get; }
        Vector4<T> ZZXY { get; }
        Vector4<T> ZZXZ { get; }
        Vector4<T> ZZXW { get; }
        Vector4<T> ZZYX { get; }
        Vector4<T> ZZYY { get; }
        Vector4<T> ZZYZ { get; }
        Vector4<T> ZZYW { get; }
        Vector4<T> ZZZX { get; }
        Vector4<T> ZZZY { get; }
        Vector4<T> ZZZZ { get; }
        Vector4<T> ZZZW { get; }
        Vector4<T> ZZWX { get; }
        Vector4<T> ZZWY { get; }
        Vector4<T> ZZWZ { get; }
        Vector4<T> ZZWW { get; }
        Vector4<T> ZWXX { get; }
        Vector4<T> ZWXY { get; }
        Vector4<T> ZWXZ { get; }
        Vector4<T> ZWXW { get; }
        Vector4<T> ZWYX { get; }
        Vector4<T> ZWYY { get; }
        Vector4<T> ZWYZ { get; }
        Vector4<T> ZWYW { get; }
        Vector4<T> ZWZX { get; }
        Vector4<T> ZWZY { get; }
        Vector4<T> ZWZZ { get; }
        Vector4<T> ZWZW { get; }
        Vector4<T> ZWWX { get; }
        Vector4<T> ZWWY { get; }
        Vector4<T> ZWWZ { get; }
        Vector4<T> ZWWW { get; }
        Vector4<T> WXXX { get; }
        Vector4<T> WXXY { get; }
        Vector4<T> WXXZ { get; }
        Vector4<T> WXXW { get; }
        Vector4<T> WXYX { get; }
        Vector4<T> WXYY { get; }
        Vector4<T> WXYZ { get; }
        Vector4<T> WXYW { get; }
        Vector4<T> WXZX { get; }
        Vector4<T> WXZY { get; }
        Vector4<T> WXZZ { get; }
        Vector4<T> WXZW { get; }
        Vector4<T> WXWX { get; }
        Vector4<T> WXWY { get; }
        Vector4<T> WXWZ { get; }
        Vector4<T> WXWW { get; }
        Vector4<T> WYXX { get; }
        Vector4<T> WYXY { get; }
        Vector4<T> WYXZ { get; }
        Vector4<T> WYXW { get; }
        Vector4<T> WYYX { get; }
        Vector4<T> WYYY { get; }
        Vector4<T> WYYZ { get; }
        Vector4<T> WYYW { get; }
        Vector4<T> WYZX { get; }
        Vector4<T> WYZY { get; }
        Vector4<T> WYZZ { get; }
        Vector4<T> WYZW { get; }
        Vector4<T> WYWX { get; }
        Vector4<T> WYWY { get; }
        Vector4<T> WYWZ { get; }
        Vector4<T> WYWW { get; }
        Vector4<T> WZXX { get; }
        Vector4<T> WZXY { get; }
        Vector4<T> WZXZ { get; }
        Vector4<T> WZXW { get; }
        Vector4<T> WZYX { get; }
        Vector4<T> WZYY { get; }
        Vector4<T> WZYZ { get; }
        Vector4<T> WZYW { get; }
        Vector4<T> WZZX { get; }
        Vector4<T> WZZY { get; }
        Vector4<T> WZZZ { get; }
        Vector4<T> WZZW { get; }
        Vector4<T> WZWX { get; }
        Vector4<T> WZWY { get; }
        Vector4<T> WZWZ { get; }
        Vector4<T> WZWW { get; }
        Vector4<T> WWXX { get; }
        Vector4<T> WWXY { get; }
        Vector4<T> WWXZ { get; }
        Vector4<T> WWXW { get; }
        Vector4<T> WWYX { get; }
        Vector4<T> WWYY { get; }
        Vector4<T> WWYZ { get; }
        Vector4<T> WWYW { get; }
        Vector4<T> WWZX { get; }
        Vector4<T> WWZY { get; }
        Vector4<T> WWZZ { get; }
        Vector4<T> WWZW { get; }
        Vector4<T> WWWX { get; }
        Vector4<T> WWWY { get; }
        Vector4<T> WWWZ { get; }
        Vector4<T> WWWW { get; }

        #endregion
    }
}