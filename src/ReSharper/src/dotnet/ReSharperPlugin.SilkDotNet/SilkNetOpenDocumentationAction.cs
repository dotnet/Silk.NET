// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using JetBrains.Application.DataContext;
using JetBrains.Application.StdApplicationUI;
using JetBrains.Application.UI.Actions;
using JetBrains.Application.UI.ActionsRevised.Menu;
using JetBrains.Application.UI.ActionSystem.ActionsRevised.Menu;
using JetBrains.Diagnostics;
using JetBrains.ProjectModel.DataContext;
using JetBrains.ReSharper.Feature.Services.Util;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.TextControl.DataContext;

namespace ReSharperPlugin.SilkDotNet
{
    [Action("SilkNetOpenDocumentationAction", "Open Native Documentation/Specification")]
    public class SilkNetOpenDocumentationAction : IActionWithExecuteRequirement, IExecutableAction
    {
        public IActionRequirement GetRequirement(IDataContext dataContext)
            => CommitAllDocumentsRequirement.TryGetInstance(dataContext);

        public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
            => true;

        public void Execute(IDataContext context, DelegateExecute nextExecute)
        {
            var solution = context.GetData(ProjectModelDataConstants.SOLUTION).NotNull();
            var textControl = context.GetData(TextControlDataConstants.TEXT_CONTROL).NotNull();
            var services = solution.GetPsiServices();

            var references = TextControlToPsi.GetReferencesAtCaret(solution, textControl);
            if (references?.Length != 1 ||
                references.Single().Resolve().DeclaredElement is not IMethod method)
            {
                return;
            }

            var url = Data.FindHelpUrl(method);
            if (url is null)
            {
                return;
            }
            
            var opensUri = services.GetComponent<OpensUri>();
            opensUri.OpenUri(url);
        }
    }
}
