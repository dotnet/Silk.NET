using NAudio.Wave;
using Silk.NET.OpenAL;

// NOTE: If you prefer, you can use the static ALContext and AL functions instead of creating an API object!
// Learn more: https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings
var alc = ALContext.Create(); // TODO disposable

// Open an audio device.
var device = alc.OpenDevice("");
if (device == nullptr)
{
    Console.WriteLine("Could not create device");
    return;
}

// Create an OpenAL context using that device.
var context = alc.CreateContext(device, nullptr);
if (context == nullptr)
{
    Console.WriteLine("Could not create context");
    return;
}

// Make the context current on this thread.
if (!alc.MakeContextCurrent(context))
{
    Console.WriteLine("Could not make context current");
    return;
}

// Fetch basic metadata about the OpenAL implementation.
foreach (
    var pname in (IEnumerable<StringPName>)
        [StringPName.Vendor, StringPName.Extensions, StringPName.Renderer, StringPName.Version]
)
{
    Console.WriteLine($"{pname}: {AL.GetString(pname).ReadToString()}");
}

// Create an audio source and a buffer to store the audio data played by that source.
var source = AL.GenSource();
var buffer = AL.GenBuffer();

// We're using NAudio to read the WAV file into a buffer we can then pass to OpenAL.
// We do have to do a little bit of work to map wavReader.WaveFormat into OpenAL's Format enum though.
using var wavReader = new WaveFileReader(Path.Combine(AppContext.BaseDirectory, "beep.wav"));
var sampleSize = wavReader.WaveFormat.Channels * (wavReader.WaveFormat.BitsPerSample / 8);
var sampleBuffer = new byte[sampleSize * wavReader.SampleCount];
for (var i = 0; i < sampleSize; i += wavReader.Read(sampleBuffer, i, sampleBuffer.Length - i))
{
    // do nothing
}

// Upload the audio data to the audio device.
var format = ConvertFormat(wavReader.WaveFormat);
AL.BufferData(buffer, format, sampleBuffer, sampleBuffer.Length, wavReader.WaveFormat.SampleRate);
AL.ThrowError();

// Configure the audio source to loop its audio, and play it!
// TODO this is crap - we should have a boolean overload.
AL.Source(source, (ALEnum)SourceBoolean.Looping, 1);
AL.Source(source, SourceInteger.Buffer, (int)buffer);
AL.SourcePlay(source);
AL.ThrowError();

Console.WriteLine("Press Enter to Exit...");
Console.ReadLine();

// Stop playing audio.
AL.SourceStop(source);

// Cleanup!
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
