// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL;

public partial interface IALContext
{
    public DeviceHandle CurrentDevice
    {
        // TODO something better/more descriptive?
        get => throw new NotSupportedException();
        set => throw new NotSupportedException();
    }

    IALContext Clone();
}
