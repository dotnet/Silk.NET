namespace Silk.NET.WGL;

public struct LayerPlaneDescriptor
{
    public ushort NSize;
    public ushort NVersion;
    public uint DwFlags;
    public byte IPixelType;
    public byte CColorBits;
    public byte CRedBits;
    public byte CRedShift;
    public byte CGreenBits;
    public byte CGreenShift;
    public byte CBlueBits;
    public byte CBlueShift;
    public byte CAlphaBits;
    public byte CAlphaShift;
    public byte CAccumBits;
    public byte CAccumRedBits;
    public byte CAccumGreenBits;
    public byte CAccumBlueBits;
    public byte CAccumAlphaBits;
    public byte CDepthBits;
    public byte CStencilBits;
    public byte CAuxBuffers;
    public byte ILayerType;
    public byte BReserved;
    public uint CrTransparent;
}