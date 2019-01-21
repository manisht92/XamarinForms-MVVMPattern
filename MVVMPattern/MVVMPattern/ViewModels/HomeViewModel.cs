using System;
using MVVMPattern.Models;

namespace MVVMPattern.ViewModels
{
    public class HomeViewModel
    {
        public TaskModel TaskModel { get; set; }

        public HomeViewModel()
        {
            TaskModel = new TaskModel
            {
                Title = "First Task",
                Duration = 2
            };
        }
    }
}
