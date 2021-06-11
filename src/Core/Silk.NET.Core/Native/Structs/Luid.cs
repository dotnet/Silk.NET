// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core.Native
{
    public struct Luid
    {
        public uint Low;
        public int High;

        // TODO REMOVE THESE IN 3.0! THESE ARE FOR COMPATIBILITY TO SOFTEN THE BLOW OF THE BREAKING CHANGE IN 2.6!
        public static implicit operator (ulong, long)(Luid instance) => (instance.Low, instance.High);

        public static implicit operator Luid((ulong, long) instance)
            => new() {Low = (uint) instance.Item1, High = (int) instance.Item2};

        public void Deconstruct(out ulong low, out long high) => (low, high) = (Low, High);
    }
}
