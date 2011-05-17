namespace Endjin.TeamCityDemo.Tasks
{
    using Endjin.TeamCityDemo.Contracts;
    using Endjin.TeamCityDemo.Framework;

    public class MyTask : IMyTask
    {
        public void DoSomething(IMyBehaviour behaviour)
        {
            Utility.DoSomething(behaviour);
        }
    }
}