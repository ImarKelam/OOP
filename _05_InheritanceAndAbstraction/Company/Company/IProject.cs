namespace Company
{
    using System;

    public enum ProjectState
    {
        open, closed
    }

    public interface IProject
    {
        string Name { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        ProjectState State { get; set; }
        void CloseProject();
    }
}
