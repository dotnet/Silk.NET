// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    public interface IVTable : IDisposable
    {
        void Initialize(INativeContext ctx, int maxSlots);
        nint Load(int slot, string entryPoint);
        void Purge();
    }
}
