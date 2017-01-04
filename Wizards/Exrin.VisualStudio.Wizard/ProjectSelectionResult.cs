using System;

namespace Exrin.VisualStudio.Wizard
{
    [Flags]
    public enum ProjectSelectionResult
    {
        None = 0,
        Android = 1,
        iOS = 2,
        UWP = 4
    }
}
