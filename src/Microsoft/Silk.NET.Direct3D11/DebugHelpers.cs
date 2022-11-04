// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Silk.NET.Core.Native;

namespace Silk.NET.Direct3D11;

public static unsafe class DebugHelpers
{
    public static Task SetInfoQueueCallback<T>
    (
        this ComPtr<T> devicePtr,
        Action<Message> callback,
        CancellationToken cancellationToken = default
    ) where T : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<T>
    {
        if(callback == null)
            throw new NullReferenceException("Callback cannot be null!");

        var infoQueue = ((ID3D11Device*) devicePtr.AsVtblPtr())->QueryInterface<ID3D11InfoQueue>();
        return Task.Run
        (
            () =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    var numMessages = infoQueue.GetNumStoredMessages();
                    if (numMessages == 0)
                    {
                        continue;
                    }
                    
                    for (var i = 0ul; i < numMessages; i++)
                    {
                        nuint msgByteLength = default; 
                        SilkMarshal.ThrowHResult(infoQueue.GetMessageA(i, null, ref msgByteLength));

                        var msgBytes = new byte[msgByteLength];
                        ref var msg = ref Unsafe.As<byte, Message>(ref msgBytes[0]);
                        SilkMarshal.ThrowHResult(infoQueue.GetMessageA(i, ref msg, ref msgByteLength));

                        callback(msg);
                    }

                    infoQueue.ClearStoredMessages();
                }

                infoQueue.Dispose();
            },
            cancellationToken
        );
    }
}
