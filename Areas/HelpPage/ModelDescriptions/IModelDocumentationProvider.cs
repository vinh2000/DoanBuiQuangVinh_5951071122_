using System;
using System.Reflection;

namespace DoanBuiQuangVinh_5951071122.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}