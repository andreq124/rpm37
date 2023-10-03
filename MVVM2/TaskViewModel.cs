using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM2
{
    public class TaskViewModel
    {
        private string title;
        private bool isCompleted;
        private readonly EventAggregator eventAggregator;
        private TaskModel selectedTask;

        public ObservableCollection<TaskModel> Tasks { get; private set; }

        public ICommand AddTaskCommand { get; private set; }
        public ICommand DeleteTaskCommand { get; private set; }

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                if (isCompleted != value)
                {
                    isCompleted = value;
                    OnPropertyChanged(nameof(IsCompleted));
                }
            }
        }

        public TaskModel SelectedTask
        {
            get { return selectedTask; }
            set
            {
                if (selectedTask != value)
                {
                    selectedTask = value;
                    OnPropertyChanged(nameof(SelectedTask));
                    ((RelayCommand)DeleteTaskCommand).RaiseCanExecuteChanged();
                }
            }
        }

        public TaskViewModel(EventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;

            Tasks = new ObservableCollection<TaskModel>();

            AddTaskCommand = new RelayCommand(AddTask);
            DeleteTaskCommand = new RelayCommand(DeleteTask, CanDeleteTask);
        }
        private bool CanDeleteTask(object parameter)
        {
            return SelectedTask != null;
        }

        private void DeleteTask(object parameter)
        {
            if (SelectedTask != null)
            {
                Tasks.Remove(SelectedTask);
            }
        }

        private void AddTask(object parameter)
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                Tasks.Add(new TaskModel { Title = Title, IsCompleted = IsCompleted });
                Title = string.Empty;
                IsCompleted = false;
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Title))
                {
                    if (string.IsNullOrWhiteSpace(Title))
                    {
                        return "Title is required.";
                    }
                }
                return null;
            }
        }

        public string Error => null;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
