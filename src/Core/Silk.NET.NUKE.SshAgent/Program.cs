// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Net;
using Renci.SshNet;

namespace Silk.NET.NUKE.SshAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silk.NET SSH Build System");
            Console.WriteLine($"Copyright (C) {DateTime.Now.Year} .NET Foundation");
            Console.WriteLine();
            // TODO | This will be a remote build agent used by our NUKE pipeline. It will be needed because some of our
            // TODO | workloads are operating-system specific. For example, you can only rebuild libSDL2.a on a Mac
            // TODO | using xcodebuild and lipo. You can also only reconvert pretty much all of our bindings generated
            // TODO | from C/C++ headers on Windows as it has a dependency on the Windows SDK baked into the
            // TODO | generator.json file.
            //
            // TODO | This remote agent will have two modes:
            // TODO | Client Mode:
            // TODO |     - This is used by the computer that needs to remote into another computer to complete the
            // TODO |       build. For example, when executing a full build on Windows we should rebuild libSDL2.a, but
            // TODO |       we can only do that from a Mac. Same with our Metal bindings.
            //
            // TODO |     - The Windows machine in that example should spin up the SshAgent in "Client Mode". This
            // TODO |       involves a HTTP server that will:
            // TODO |         - Allow the Mac to download a single-file publish of the SshAgent. (GET /.bin)
            // TODO |         - Allow the Mac to download the current working directory as a GZIP. (GET /cwd.gz)
            // TODO |         - Allow the Mac to download a JSON build script defining commands to run and artifacts to
            // TODO |           upload. (GET /task.json)
            // TODO |         - Allow the Mac to upload build artifacts back to the Windows machine (POST /artifacts.gz)
            // TODO |         - Receive pings from the Mac so that we know it's still alive (GET /)
            //
            // TODO |     - The Windows machine will then connect to the Mac via SSH using credentials passed in args.
            // TODO |       This assumes that SSH is already setup on the remote, which should be the case for a Mac and
            // TODO |       Linux machine. It's unclear what we'll do for a Mac or Linux machine remoting into Windows.
            //
            // TODO |     - Once connected via SSH, it will run:
            // TODO |           wget -O SshAgent http://servermodemachine:<SshAgentPort>/.bin
            // TODO |           ./SshAgent RemoteMode SshAgent.json http://servermodemachine:<SshAgentPort>/task.json
            // TODO |           rm ./SshAgent
            // NOTE |           (Commands may be slightly different for a Windows remote, but again we don't know how
            // NOTE |            that'll work yet)
            //
            // TODO |     - Once the above script has finished, save the returned artifacts.gz somewhere in the build
            // TODO |       folder.
            //
            // TODO | Remote Mode:
            // TODO |     - Basically the other end of the conversation as laid out above.
        }
    }
}
