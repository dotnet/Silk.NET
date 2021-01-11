// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Threading.Tasks;
using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Commands;
using Microsoft.DotNet.Interactive.Events;
using Microsoft.DotNet.Interactive.Formatting;
using Silk.NET.OpenGLES;
using Silk.NET.Windowing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using static Microsoft.DotNet.Interactive.Formatting.PocketViewTags;

namespace Silk.NET.Jupyter
{
    public class FrameKernel : IKernelExtension
    {
        public unsafe Task OnLoadAsync(Kernel kernel)
        {
            var frameCommand = new Command("#!frame", "Displays and Renders a single frame");

            frameCommand.Handler = CommandHandler.Create(
                (KernelInvocationContext ctx) =>
                {
                    var view = JupyterView.LastCreated;
                    view.Initialize();
                    view.MakeCurrent();
                    var gl = view.CreateOpenGLES();
                    
                    var width = view.Size.X;
                    var height = view.Size.Y;
                
                    // gl.Finish();
                    var arr = new Rgba32[width * height];
                    
                    fixed (Rgba32* p = arr)
                        gl.ReadPixels(0, 0, (uint)width, (uint)height, PixelFormat.Rgba, PixelType.UnsignedByte, (void*)p);
                    // gl.Finish();

                    var i = Image<Rgba32>.WrapMemory(arr.AsMemory(), width, height);

                    var memoryStream = new MemoryStream();
                    i.SaveAsPng(memoryStream);
                    var arr2 = new byte[memoryStream.Length];
                    memoryStream.Position = 0;
                    memoryStream.Read(arr2);
                    memoryStream.Dispose();
                    
                    var s = Convert.ToBase64String(arr2);
                    s = "data:image/png;base64," + s;
                    
                    ctx.Display((PocketView)img[src: s]);
                });
            
            kernel.AddDirective(frameCommand);
        
            if (KernelInvocationContext.Current is { } context)
            {
                PocketView view = div(
                    code("Silk.NET.Jupyter"),
                    " is loaded. Try it out using",
                    br,
                    code("var view = JupyterView.Create(100, 100);"), br,
                    code("#!view view")
                );

                context.Display(view);
            }
            
            return Task.CompletedTask;
        }
    }
}
