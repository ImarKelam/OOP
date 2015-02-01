namespace Company
{
    using System.Collections.Generic;

    public interface IDeveloper
    {
        IList<Project> Projects { get; }
        void AddProject(Project pr);
    }
}
