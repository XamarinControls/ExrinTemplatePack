using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System.Collections.Generic;
using System.IO;

namespace Exrin.VisualStudio.Wizard
{
    public class ExrinProjectWizard : IWizard
    {
        private DTE _dte = null;
        private string _solutionDir = null;
        private string _projectName = null;
        ProjectSelectionResult _result;

        public void BeforeOpeningFile(ProjectItem projectItem) { }

        public void ProjectFinishedGenerating(Project project)
        {
            //if (_result.HasFlag(ProjectSelectionResult.Android))
            //    CreateProject("Droid");

            //if (_result.HasFlag(ProjectSelectionResult.iOS))
            //    CreateProject("iOS");

            //if (_result.HasFlag(ProjectSelectionResult.UWP))
            //    CreateProject("UWP");
        }

        void CreateProject(string platform)
        {
            //string name = $"{_projectName}.{platform}";
            //string projectPath = Path.Combine(_solutionDir, Path.Combine(_projectName, name));
            //string templatePath = $"{name}.zip\\MyTemplate.vstemplate";
            //_dte.Solution.AddFromTemplate(templatePath, projectPath, name);
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }

        public void RunFinished() { }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                _dte = automationObject as DTE;
               
                _projectName = replacementsDictionary["$safeprojectname$"];
                _solutionDir = Path.GetDirectoryName(replacementsDictionary["$destinationdirectory$"]);

              

                //replacementsDictionary["$safeprojectname$"] = replacementsDictionary["$specifiedsolutionname$"];
                ProjectSelectionDialog dialog = new ProjectSelectionDialog();
                dialog.ShowDialog();
                //_result = dialog.Result;

                //if (_result == ProjectSelectionResult.None)
                //    throw new WizardBackoutException();
            }
            catch
            {
                if (Directory.Exists(_solutionDir))
                    Directory.Delete(_solutionDir, true);

                throw;
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
