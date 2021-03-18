// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Text;

namespace Silk.NET.Core.Native
{
    public partial struct ID3D10Blob
    {
        public unsafe ReadOnlySpan<byte> Buffer => new ReadOnlySpan<byte>(GetBufferPointer(), (int) GetBufferSize());
        private unsafe string AsString => Encoding.UTF8.GetString((byte*) GetBufferPointer(), (int) GetBufferSize());
    }
}
