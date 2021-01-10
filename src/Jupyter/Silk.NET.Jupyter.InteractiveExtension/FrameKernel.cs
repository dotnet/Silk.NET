// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Commands;
using Microsoft.DotNet.Interactive.Events;
using Microsoft.DotNet.Interactive.Formatting;
using Silk.NET.Windowing;
using static Microsoft.DotNet.Interactive.Formatting.PocketViewTags;

namespace Silk.NET.Jupyter
{
    public class FrameKernel : IKernelExtension
    {
        private IView _view;
        
        public Task OnLoadAsync(Kernel kernel)
        {
            var initCommand = new Command("#!view", "Set the view to use")
            {
                new Option<IView>(new[] {"-v", "--view"}, "The view to use")
            };
            var frameCommand = new Command("#!frame", "Displays and Renders a single frame")
            {
                
            };
            
            initCommand.Handler = CommandHandler.Create(
                (IView view) =>
                {
                    _view = view;
                });
            
            kernel.AddDirective(frameCommand);
            kernel.AddDirective(initCommand);
        
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
