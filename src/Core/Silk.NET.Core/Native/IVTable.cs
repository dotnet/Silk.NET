// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    public interface IVTable : IDisposable
    {
        [Obsolete("Use method without slot - this method will be removed in 3.0")]
        nint Load(int slot, string entryPoint);
        nint Load(string entryPoint);
        IVTable Clone();
        void Purge();
    }
}
