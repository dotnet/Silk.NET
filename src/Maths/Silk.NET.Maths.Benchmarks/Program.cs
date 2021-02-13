using System.Reflection;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;

namespace Silk.NET.Maths.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var job = Job.Default; // for quick measurements replace with Job.ShortRun
            job = job.WithStrategy(RunStrategy.Throughput);
            
            BenchmarkSwitcher.FromAssembly(Assembly.GetEntryAssembly()).Run(args, DefaultConfig.Instance
                .AddLogger(ConsoleLogger.Unicode)
                .AddJob(job.WithRuntime(ClrRuntime.Net48))
                .AddJob(job.WithRuntime(CoreRuntime.Core50))
                .AddJob(job.WithRuntime(CoreRuntime.Core31))
            );
        }
    }
}