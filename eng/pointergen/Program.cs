// See https://aka.ms/new-console-template for more information

using PointerGenerator;

if (!File.Exists("pointergen.csproj"))
{
    throw new InvalidOperationException("Run this in the pointergen directory.");
}

const int maxIndirection = 3;
Generator.GenerateTypes("", maxIndirection);
