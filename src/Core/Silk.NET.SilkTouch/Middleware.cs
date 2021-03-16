// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.SilkTouch
{
    public delegate void Middleware(ref IMarshalContext ctx, Action next);
}
