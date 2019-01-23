using System;
using System.ComponentModel;
using MVVMPattern.Models;
using Xamarin.Forms;

namespace MVVMPattern.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string _message;
        private TaskModel _taskModel;

        public TaskModel TaskModel
        {
            get => _taskModel;
            set
            {
                _taskModel = value; OnPropertyChanged("TaskModel");
            }
        }

        public HomeViewModel()
        {
            TaskModel = new TaskModel
            {
                Title = "First Task",
                Duration = 2
            };
        }

        public Command SaveCommand
        {
            get
            {
                return new Command(() =>
                {
                    Message = String.Format("Your Task {0} with {1} has been saved", TaskModel.Title, TaskModel.Duration);
                });
            }
        }

        public Command ChangeCommand
        {
            get
            {
                return new Command(() =>
                {
                    TaskModel.Title = "Second Task";
                    OnPropertyChanged("TaskModel");
                });
            }
        }

        public string Message { get => _message; set { _message = value; OnPropertyChanged("Message"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
