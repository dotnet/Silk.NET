// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input;

internal partial class InputTesting
{
    private static InputContext InitInput(INativeWindow window) => window.CreateInput();

    private static void ExecuteInput(InputContext? context, INativeWindow window)
    {
        if (context == null)
            return;

        context.Update();

    }

    private static void OnInputConnectionChanged(ConnectionEvent obj)
    {
        Console.WriteLine($"{obj.Device.Name} {obj.Device.Id} {(obj.IsConnected ? "connected" : "disconnected")}");
    }


}
