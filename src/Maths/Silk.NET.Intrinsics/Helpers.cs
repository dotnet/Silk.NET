// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using Silk.NET.Intrinsics.Software;
// ReSharper disable IdentifierTypo

namespace Silk.NET.Intrinsics
{
    public static class Helpers
    {
        public const byte Xxxx = (0 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte Yxxx = (0 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte Zxxx = (0 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte Wxxx = (0 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte Xyxx = (0 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte Yyxx = (0 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte Zyxx = (0 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte Wyxx = (0 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte Xzxx = (0 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte Yzxx = (0 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte Zzxx = (0 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte Wzxx = (0 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte Xwxx = (0 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte Ywxx = (0 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte Zwxx = (0 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte Wwxx = (0 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte Xxyx = (0 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte Yxyx = (0 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte Zxyx = (0 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte Wxyx = (0 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte Xyyx = (0 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte Yyyx = (0 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte Zyyx = (0 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte Wyyx = (0 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte Xzyx = (0 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte Yzyx = (0 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte Zzyx = (0 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte Wzyx = (0 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte Xwyx = (0 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte Ywyx = (0 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte Zwyx = (0 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte Wwyx = (0 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte Xxzx = (0 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte Yxzx = (0 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte Zxzx = (0 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte Wxzx = (0 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte Xyzx = (0 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte Yyzx = (0 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte Zyzx = (0 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte Wyzx = (0 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte Xzzx = (0 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte Yzzx = (0 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte Zzzx = (0 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte Wzzx = (0 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte Xwzx = (0 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte Ywzx = (0 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte Zwzx = (0 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte Wwzx = (0 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte Xxwx = (0 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte Yxwx = (0 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte Zxwx = (0 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte Wxwx = (0 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte Xywx = (0 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte Yywx = (0 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte Zywx = (0 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte Wywx = (0 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte Xzwx = (0 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte Yzwx = (0 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte Zzwx = (0 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte Wzwx = (0 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte Xwwx = (0 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte Ywwx = (0 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte Zwwx = (0 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte Wwwx = (0 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte Xxxy = (1 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte Yxxy = (1 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte Zxxy = (1 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte Wxxy = (1 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte Xyxy = (1 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte Yyxy = (1 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte Zyxy = (1 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte Wyxy = (1 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte Xzxy = (1 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte Yzxy = (1 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte Zzxy = (1 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte Wzxy = (1 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte Xwxy = (1 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte Ywxy = (1 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte Zwxy = (1 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte Wwxy = (1 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte Xxyy = (1 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte Yxyy = (1 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte Zxyy = (1 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte Wxyy = (1 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte Xyyy = (1 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte Yyyy = (1 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte Zyyy = (1 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte Wyyy = (1 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte Xzyy = (1 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte Yzyy = (1 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte Zzyy = (1 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte Wzyy = (1 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte Xwyy = (1 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte Ywyy = (1 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte Zwyy = (1 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte Wwyy = (1 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte Xxzy = (1 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte Yxzy = (1 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte Zxzy = (1 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte Wxzy = (1 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte Xyzy = (1 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte Yyzy = (1 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte Zyzy = (1 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte Wyzy = (1 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte Xzzy = (1 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte Yzzy = (1 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte Zzzy = (1 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte Wzzy = (1 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte Xwzy = (1 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte Ywzy = (1 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte Zwzy = (1 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte Wwzy = (1 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte Xxwy = (1 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte Yxwy = (1 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte Zxwy = (1 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte Wxwy = (1 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte Xywy = (1 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte Yywy = (1 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte Zywy = (1 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte Wywy = (1 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte Xzwy = (1 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte Yzwy = (1 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte Zzwy = (1 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte Wzwy = (1 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte Xwwy = (1 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte Ywwy = (1 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte Zwwy = (1 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte Wwwy = (1 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte Xxxz = (2 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte Yxxz = (2 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte Zxxz = (2 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte Wxxz = (2 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte Xyxz = (2 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte Yyxz = (2 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte Zyxz = (2 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte Wyxz = (2 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte Xzxz = (2 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte Yzxz = (2 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte Zzxz = (2 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte Wzxz = (2 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte Xwxz = (2 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte Ywxz = (2 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte Zwxz = (2 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte Wwxz = (2 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte Xxyz = (2 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte Yxyz = (2 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte Zxyz = (2 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte Wxyz = (2 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte Xyyz = (2 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte Yyyz = (2 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte Zyyz = (2 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte Wyyz = (2 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte Xzyz = (2 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte Yzyz = (2 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte Zzyz = (2 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte Wzyz = (2 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte Xwyz = (2 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte Ywyz = (2 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte Zwyz = (2 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte Wwyz = (2 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte Xxzz = (2 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte Yxzz = (2 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte Zxzz = (2 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte Wxzz = (2 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte Xyzz = (2 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte Yyzz = (2 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte Zyzz = (2 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte Wyzz = (2 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte Xzzz = (2 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte Yzzz = (2 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte Zzzz = (2 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte Wzzz = (2 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte Xwzz = (2 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte Ywzz = (2 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte Zwzz = (2 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte Wwzz = (2 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte Xxwz = (2 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte Yxwz = (2 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte Zxwz = (2 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte Wxwz = (2 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte Xywz = (2 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte Yywz = (2 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte Zywz = (2 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte Wywz = (2 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte Xzwz = (2 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte Yzwz = (2 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte Zzwz = (2 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte Wzwz = (2 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte Xwwz = (2 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte Ywwz = (2 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte Zwwz = (2 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte Wwwz = (2 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte Xxxw = (3 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte Yxxw = (3 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte Zxxw = (3 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte Wxxw = (3 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte Xyxw = (3 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte Yyxw = (3 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte Zyxw = (3 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte Wyxw = (3 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte Xzxw = (3 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte Yzxw = (3 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte Zzxw = (3 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte Wzxw = (3 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte Xwxw = (3 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte Ywxw = (3 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte Zwxw = (3 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte Wwxw = (3 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte Xxyw = (3 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte Yxyw = (3 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte Zxyw = (3 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte Wxyw = (3 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte Xyyw = (3 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte Yyyw = (3 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte Zyyw = (3 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte Wyyw = (3 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte Xzyw = (3 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte Yzyw = (3 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte Zzyw = (3 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte Wzyw = (3 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte Xwyw = (3 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte Ywyw = (3 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte Zwyw = (3 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte Wwyw = (3 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte Xxzw = (3 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte Yxzw = (3 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte Zxzw = (3 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte Wxzw = (3 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte Xyzw = (3 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte Yyzw = (3 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte Zyzw = (3 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte Wyzw = (3 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte Xzzw = (3 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte Yzzw = (3 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte Zzzw = (3 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte Wzzw = (3 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte Xwzw = (3 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte Ywzw = (3 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte Zwzw = (3 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte Wwzw = (3 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte Xxww = (3 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte Yxww = (3 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte Zxww = (3 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte Wxww = (3 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte Xyww = (3 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte Yyww = (3 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte Zyww = (3 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte Wyww = (3 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte Xzww = (3 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte Yzww = (3 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte Zzww = (3 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte Wzww = (3 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte Xwww = (3 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte Ywww = (3 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte Zwww = (3 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte Wwww = (3 << 6) | (3 << 4) | (3 << 2) | 3;
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T X<T>(this Vector128<T> vector) where T : struct => vector.GetElement(0);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T Y<T>(this Vector128<T> vector) where T : struct => vector.GetElement(1);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T Z<T>(this Vector128<T> vector) where T : struct => vector.GetElement(2);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T W<T>(this Vector128<T> vector) where T : struct => vector.GetElement(3);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T X<T>(this Vector256<T> vector) where T : struct => vector.GetElement(0);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T Y<T>(this Vector256<T> vector) where T : struct => vector.GetElement(1);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T Z<T>(this Vector256<T> vector) where T : struct => vector.GetElement(2);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T W<T>(this Vector256<T> vector) where T : struct => vector.GetElement(3);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float X(this SoftwareWorkUnit128F vector) => X(vector._vector128);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float Y(this SoftwareWorkUnit128F vector) => Y(vector._vector128);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float Z(this SoftwareWorkUnit128F vector) => Z(vector._vector128);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float W(this SoftwareWorkUnit128F vector) => W(vector._vector128);

        public static unsafe T Scalar<T>(this IWorkUnit<T> unit) where T : unmanaged
        {
            T ret; 
            unit.StoreScalar(&ret);
            return ret;
        }
        
        public static IWorkUnit<T> Normalize2<T>(this IWorkUnit<T> vector) where T:unmanaged => vector.Divide(vector.Length2());
        public static IWorkUnit<T> Normalize3<T>(this IWorkUnit<T> vector) where T:unmanaged => vector.Divide(vector.Length3());
        public static IWorkUnit<T> Normalize4<T>(this IWorkUnit<T> vector) where T:unmanaged => vector.Divide(vector.Length4());
        public static IWorkUnit<T> NormalizeApprox2<T>(this IWorkUnit<T> vector) where T:unmanaged => throw new NotImplementedException();
        public static IWorkUnit<T> NormalizeApprox3<T>(this IWorkUnit<T> vector) where T:unmanaged => throw new NotImplementedException();
        public static IWorkUnit<T> NormalizeApprox4<T>(this IWorkUnit<T> vector) where T:unmanaged => throw new NotImplementedException();
        public static IWorkUnit<T> Length2<T>(this IWorkUnit<T> vector) where T:unmanaged => vector.DotProduct2(vector).Sqrt();
        public static IWorkUnit<T> Length3<T>(this IWorkUnit<T> vector) where T:unmanaged => vector.DotProduct2(vector).Sqrt();
        public static IWorkUnit<T> Length4<T>(this IWorkUnit<T> vector) where T:unmanaged => vector.DotProduct2(vector).Sqrt();
    }
}
