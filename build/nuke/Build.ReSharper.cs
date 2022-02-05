// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;

partial class Build
{
    [Parameter("API Key for JetBrains Plugin Marketplace")] [CanBeNull] string JetbrainsApiKey;
    AbsolutePath ReSharperSource => RootDirectory / "src" / "ReSharper";
    AbsolutePath ReSharperOutput => ReSharperSource / "output";
    Target ReSharper => CommonTarget
    (
        x => x.Before(SignPackages)
            .Executes(() => Gradlew(":buildPlugin", ReSharperSource).AssertZeroExitCode())
    );

    Target RunRider => CommonTarget
    (
        x => x.After(ReSharper)
            .Executes
            (
                () => Gradlew(":runIde -x buildPlugin -x compileKotlin -x compileDotNet", ReSharperSource)
                    .AssertZeroExitCode()
            )
    );

    Target PushToJetbrains => CommonTarget
    (
        x => x.After(ReSharper)
            .After(SignPackages)
            .Executes
            (
                async () =>
                {
                    ControlFlow.Assert(!string.IsNullOrWhiteSpace(JetbrainsApiKey), "API key is needed!");
                    var pluginZip = ReSharperOutput.GlobFiles("silkdotnet-*.zip").First();
                    await PushPackages("https://plugins.jetbrains.com/");
                    using var httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Authorization = new("Bearer", JetbrainsApiKey);
                    var formContent = new MultipartFormDataContent();
                    formContent.Add(new StringContent("18558"), "pluginId");
                    formContent.Add(new StringContent("RC"), "channel");
                    var fileContent = new ByteArrayContent(File.ReadAllBytes(pluginZip));
                    fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                    {
                        FileName = Path.GetFileName(pluginZip)
                    };

                    formContent.Add(fileContent, "file"); 
                    await httpClient.PostAsync("https://plugins.jetbrains.com/plugin/uploadPlugin", formContent);
                }
            )
    );
}
