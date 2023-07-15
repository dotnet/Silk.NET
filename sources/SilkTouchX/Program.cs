using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SilkTouchX;
using SilkTouchX.Clang;
using SilkTouchX.Mods;

var logging = new Option<LogLevel>(new[] { "--log-level", "-l" }, () => LogLevel.Information);
var configs = new Argument<string[]>("configs",
    "Path(s) to JSON SilkTouch configuration(s)") { Arity = ArgumentArity.OneOrMore };
var configOverrides = new Argument<string[]>("overrides",
    Array.Empty<string>,
    "Arguments recognisable by Microsoft.Extensions.Configuration.CommandLine to override JSON configuration items.") {
    Arity = ArgumentArity.ZeroOrMore,
};
var rootCommand = new RootCommand { configs, configOverrides, logging };
rootCommand.SetHandler(async ctx => {
    // Create the ConfigurationBuilder with support for env var & command line overrides
    var cb = new ConfigurationBuilder()
        .AddEnvironmentVariables(source => source.Prefix = "SILKDOTNET_")
        .AddCommandLine(ctx.ParseResult.GetValueForArgument(configOverrides));

    // Add the JSON files to the ConfigurationBuilder
    cb = ctx.ParseResult.GetValueForArgument(configs)
        .Aggregate(cb, (current, file) => current.AddJsonFile(Path.GetFullPath(file)));
    var config = cb.Build();

    // TODO After building the config, do a first pass for loading mods
    foreach (var job in config.GetSection("Jobs").GetChildren())
    {
        foreach (var m in job.GetSection("Mods").Get<string[]>() ?? Array.Empty<string>())
        {
            var modSection = job.GetSection(m);
            // register something with DI using modSection for configuration and m as the type
        }
    }

    var sp = new ServiceCollection().AddLogging(builder => {
            builder.AddSimpleConsole(opts => {
                opts.SingleLine = true;
            });
            builder.SetMinimumLevel(ctx.ParseResult.GetValueForOption(logging));
        }).AddSingleton<ClangScraper>().AddSingleton<ResponseFileHandler>().AddSingleton<SilkTouchGenerator>()
        .BuildServiceProvider();
    var generator = sp.GetRequiredService<SilkTouchGenerator>();
    foreach (var job in config.GetSection("Jobs").GetChildren())
    {
        await generator.OutputBindingsAsync(job.Get<SilkTouchConfiguration>() ??
                                            throw new InvalidOperationException("failed to bind configuration"));
    }

    // var serviceCollection = new ServiceCollection()
    //     .AddLogging(builder =>
    //         {
    //             builder.AddConsole();
    //             builder.SetMinimumLevel(ctx.ParseResult.GetValueForOption(logging));
    //         }
    //     )
    //     // services.AddSingleton<IOptionsChangeTokenSource<TOptions>>(new ConfigurationChangeTokenSource<TOptions>(name, config));
    //     // return services.AddSingleton<IConfigureOptions<TOptions>>(new NamedConfigureFromConfigurationOptions<TOptions>(name, config, configureBinder));
    //     .Configure<SilkTouchConfiguration>(config);
    // if (OperatingSystem.IsWindows())
    // {
    //     serviceCollection.AddSingleton<IStdIncludeResolver, WindowsStdIncludeResolver>();
    // }
    // else if (OperatingSystem.IsMacOS())
    // {
    //     serviceCollection.AddSingleton<IStdIncludeResolver, MacOSStdIncludeResolver>();
    // }
    // else
    // {
    //     serviceCollection.AddSingleton<IStdIncludeResolver, UnixStdIncludeResolver>();
    // }
    // var serviceProvider = serviceCollection
    //     .AddSingleton<ClangScraper>()
    //     .AddSingleton<ResponseFileHandler>()
    //     .BuildServiceProvider();
});

await rootCommand.InvokeAsync(args);
