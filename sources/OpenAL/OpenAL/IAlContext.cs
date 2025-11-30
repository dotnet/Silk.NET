// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL;

public partial interface IAlContext
{
    public DeviceHandle CurrentDevice { get; set; }

    IAlContext Clone();
}
