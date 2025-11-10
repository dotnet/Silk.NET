using NAudio.Wave;
using Silk.NET.OpenAL;

var device = ALContext.OpenDevice("");
if (device == nullptr)
{
    Console.WriteLine("Could not create device");
    return;
}

var context = ALContext.CreateContext(device, nullptr);
if (context == nullptr)
{
    Console.WriteLine("Could not create context");
    return;
}

if (!ALContext.MakeContextCurrent(context))
{
    Console.WriteLine("Could not make context current");
    return;
}

foreach (
    var pname in (IEnumerable<StringPName>)
        [StringPName.Vendor, StringPName.Extensions, StringPName.Renderer, StringPName.Version]
)
{
    Console.WriteLine($"{pname}: {AL.GetString(pname).ReadToString()}");
}

var source = AL.GenSource();
var buffer = AL.GenBuffer();

// TODO Use Vorbis instead
using var wavReader = new WaveFileReader(Path.Combine(AppContext.BaseDirectory, "beep.wav"));
var sampleSize = wavReader.WaveFormat.Channels * (wavReader.WaveFormat.BitsPerSample / 8);
var sampleBuffer = new byte[sampleSize * wavReader.SampleCount];
for (var i = 0; i < sampleSize; i += wavReader.Read(sampleBuffer, i, sampleBuffer.Length - i))
{
    // do nothing
}

var format = ConvertFormat(wavReader.WaveFormat);
AL.BufferData(buffer, format, sampleBuffer, sampleBuffer.Length, wavReader.WaveFormat.SampleRate);
AL.ThrowError();

// TODO this is crap
AL.Source(source, (ALEnum)SourceBoolean.Looping, 1);
AL.Source(source, SourceInteger.Buffer, (int)buffer);
AL.SourcePlay(source);
AL.ThrowError();

Console.WriteLine("Press Enter to Exit...");
Console.ReadLine();

AL.SourceStop(source);

AL.DeleteSource(source);
AL.DeleteBuffer(buffer);
ALContext.DestroyContext(context);
ALContext.CloseDevice(device);
return;

static Format ConvertFormat(WaveFormat format) =>
    format switch
    {
        { Encoding: WaveFormatEncoding.Pcm, Channels: 1, BitsPerSample: 8 } => Format.FormatMono8,
        { Encoding: WaveFormatEncoding.Pcm, Channels: 1, BitsPerSample: 16 } => Format.FormatMono16,
        { Encoding: WaveFormatEncoding.Pcm, Channels: 2, BitsPerSample: 8 } => Format.FormatStereo8,
        { Encoding: WaveFormatEncoding.Pcm, Channels: 2, BitsPerSample: 16 } =>
            Format.FormatStereo16,
        { Encoding: WaveFormatEncoding.MuLaw, Channels: 1 } => Format.FormatMonoMulaw,
        { Encoding: WaveFormatEncoding.MuLaw, Channels: 2 } => Format.FormatStereoMulaw,
        _ => throw new ArgumentOutOfRangeException(nameof(format), format, null),
    };
