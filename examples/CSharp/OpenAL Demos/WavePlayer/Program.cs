using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenAL;

namespace WavePlayer
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Exactly one argument should be given: the path to the .wav file that should be played.");
                return;
            }
            var filePath = args[0];
            ReadOnlySpan<byte> file = File.ReadAllBytes(filePath);
            int index = 0;
            if (file[index++] != 'R' || file[index++] != 'I' || file[index++] != 'F' || file[index++] != 'F')
            {
                Console.WriteLine("Given file is not in RIFF format");
                return;
            }

            var chunkSize = BinaryPrimitives.ReadInt32LittleEndian(file.Slice(index,  4));
            index += 4;

            if (file[index++] != 'W' || file[index++] != 'A' || file[index++] != 'V' || file[index++] != 'E')
            {
                Console.WriteLine("Given file is not in WAVE format");
                return;
            }

            short numChannels = -1;
            int sampleRate = -1;
            int byteRate = -1;
            short blockAlign = -1;
            short bitsPerSample = -1;
            BufferFormat format = 0;

            var alc = ALContext.GetApi();
            var al = AL.GetApi();
            var device = alc.OpenDevice("");
            if (device == null)
            {
                Console.WriteLine("Could not create device");
                return;
            }

            var context = alc.CreateContext(device, null);
            alc.MakeContextCurrent(context);
            
            al.GetError();
            
            var source = al.GenSource();
            var buffer = al.GenBuffer();
            al.SetSourceProperty(source, SourceBoolean.Looping, true);


            while (index + 4 < file.Length)
            {
                var identifier = "" + (char) file[index++] + (char) file[index++] + (char) file[index++] + (char) file[index++];
                var size = BinaryPrimitives.ReadInt32LittleEndian(file.Slice(index, 4));
                index += 4;
                if (identifier == "fmt ")
                {
                    if (size != 16)
                    {
                        Console.WriteLine($"Unknown Audio Format with subchunk1 size {size}");
                    }
                    else
                    {
                        var audioFormat = BinaryPrimitives.ReadInt16LittleEndian(file.Slice(index, 2));
                        index += 2;
                        if (audioFormat != 1)
                        {
                            Console.WriteLine($"Unknown Audio Format with ID {audioFormat}");
                        }
                        else
                        {
                            numChannels = BinaryPrimitives.ReadInt16LittleEndian(file.Slice(index, 2));
                            index += 2;
                            sampleRate = BinaryPrimitives.ReadInt32LittleEndian(file.Slice(index, 4));
                            index += 4;
                            byteRate = BinaryPrimitives.ReadInt32LittleEndian(file.Slice(index, 4));
                            index += 4;
                            blockAlign = BinaryPrimitives.ReadInt16LittleEndian(file.Slice(index, 2));
                            index += 2;
                            bitsPerSample = BinaryPrimitives.ReadInt16LittleEndian(file.Slice(index, 2));
                            index += 2;
                    
                            if (numChannels == 1)
                            {
                                if (bitsPerSample == 8)
                                    format = BufferFormat.Mono8;
                                else if (bitsPerSample == 16)
                                    format = BufferFormat.Mono16;
                                else
                                {
                                    Console.WriteLine($"Can't Play mono {bitsPerSample} sound.");
                                }
                            }
                            else if (numChannels == 2)
                            {
                                if (bitsPerSample == 8)
                                    format = BufferFormat.Stereo8;
                                else if (bitsPerSample == 16)
                                    format = BufferFormat.Stereo16;
                                else
                                {
                                    Console.WriteLine($"Can't Play stereo {bitsPerSample} sound.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Can't play audio with {numChannels} sound");
                            }
                        }
                    }
                } 
                else if (identifier == "data")
                {
                    var data = file.Slice(index, size);
                    index += size;
                    
                    fixed(byte* pData = data)
                        al.BufferData(buffer, format, pData, size, sampleRate);
                    Console.WriteLine($"Read {size} bytes Data");
                }
                else if (identifier == "JUNK")
                {
                    // this exists to align things
                    index += size;
                }
                else if (identifier == "iXML")
                {
                    var v = file.Slice(index, size);
                    var str = Encoding.ASCII.GetString(v);
                    Console.WriteLine($"iXML Chunk: {str}");
                    index += size;
                }
                else
                {
                    Console.WriteLine($"Unknown Section: {identifier}");
                    index += size;
                }
            }

            Console.WriteLine
            (
                $"Success. Detected RIFF-WAVE audio file, PCM encoding. {numChannels} Channels, {sampleRate} Sample Rate, {byteRate} Byte Rate, {blockAlign} Block Align, {bitsPerSample} Bits per Sample"
            );

            al.SetSourceProperty(source, SourceInteger.Buffer, buffer);
            al.SourcePlay(source);

            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();

            al.SourceStop(source);

            al.DeleteSource(source);
            al.DeleteBuffer(buffer);
            alc.DestroyContext(context);
            alc.CloseDevice(device);
            al.Dispose();
            alc.Dispose();
        }
    }
}
